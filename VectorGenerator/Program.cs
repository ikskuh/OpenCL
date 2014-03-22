using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VectorGenerator
{
	class Program
	{
		static string[] components = new[] { "X", "Y", "Z", "W" };
		static string[] types = new[] { "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double" };
		static int[] lengths = new[] { 1, 1, 2, 2, 4, 4, 8, 8, 4, 8 };
		static int[] dimensions = new[] { 2, 3, 4 };

		static void Main(string[] args)
		{
			GenerateVectorClasses();
			GenerateSource();
		}

		private static void GenerateSource()
		{
			using (var stream = File.Open("GeneratedSource.cs", FileMode.Create))
			{
				StreamWriter writer = new StreamWriter(stream);
				writer.WriteLine("using System;");
				writer.WriteLine("using System.Runtime.InteropServices;");
				writer.WriteLine("namespace OpenCL");
				writer.WriteLine("{");
				writer.WriteLine("partial class NativeMethods");
				writer.WriteLine("{");

				for (int typeID = 0; typeID < types.Length; typeID++)
				{
					writer.WriteLine(GenerateNativeSetKernelArgs("ref " + types[typeID]));

					for (int dimensionID = 0; dimensionID < dimensions.Length; dimensionID++)
					{
						string typeName = types[typeID] + dimensions[dimensionID];
						writer.WriteLine(GenerateNativeSetKernelArgs("ref " + typeName));
					}
				}

				for (int typeID = 0; typeID < types.Length; typeID++)
				{
					writer.WriteLine(GenerateNativeCreateBuffer("ref " + types[typeID]));
					writer.WriteLine(GenerateNativeCreateBuffer(types[typeID] + "[]"));
					writer.WriteLine(GenerateNativeCreateBuffer(types[typeID] + "[,]"));
					writer.WriteLine(GenerateNativeCreateBuffer(types[typeID] + "[,,]"));

					for (int dimensionID = 0; dimensionID < dimensions.Length; dimensionID++)
					{
						string typeName = types[typeID] + dimensions[dimensionID];
						writer.WriteLine(GenerateNativeCreateBuffer("ref " + typeName));
						writer.WriteLine(GenerateNativeCreateBuffer(typeName + "[]"));
						writer.WriteLine(GenerateNativeCreateBuffer(typeName + "[,]"));
						writer.WriteLine(GenerateNativeCreateBuffer(typeName + "[,,]"));
					}
				}
				writer.WriteLine("}");

				// Kernel
				writer.WriteLine();
				writer.WriteLine("partial struct Kernel");
				writer.WriteLine("{");
				for (int typeID = 0; typeID < types.Length; typeID++)
				{
					writer.WriteLine(GenerateSetKernelArgs(types[typeID]));
					for (int dimensionID = 0; dimensionID < dimensions.Length; dimensionID++)
					{
						string typeName = types[typeID] + dimensions[dimensionID];
						writer.WriteLine(GenerateSetKernelArgs(typeName));
					}
				}
				writer.WriteLine("}");

				// Context
				writer.WriteLine();
				writer.WriteLine("partial struct Context");
				writer.WriteLine("{");
				for (int typeID = 0; typeID < types.Length; typeID++)
				{
					writer.WriteLine(GenerateCreateBuffer(types[typeID], true));
					writer.WriteLine(GenerateCreateBuffer(types[typeID] + "[]", false));
					writer.WriteLine(GenerateCreateBuffer(types[typeID] + "[,]", false));
					writer.WriteLine(GenerateCreateBuffer(types[typeID] + "[,,]", false));

					for (int dimensionID = 0; dimensionID < dimensions.Length; dimensionID++)
					{
						string typeName = types[typeID] + dimensions[dimensionID];
						writer.WriteLine(GenerateCreateBuffer(typeName, true));
						writer.WriteLine(GenerateCreateBuffer(typeName + "[]", false));
						writer.WriteLine(GenerateCreateBuffer(typeName + "[,]", false));
						writer.WriteLine(GenerateCreateBuffer(typeName + "[,,]", false));
					}
				}
				writer.WriteLine("}");


				writer.WriteLine("}");
				writer.Flush();
			}
		}

		private static void GenerateVectorClasses()
		{
			using (var stream = File.Open("VectorTypes.cs", FileMode.Create))
			{
				StreamWriter writer = new StreamWriter(stream);
				writer.WriteLine("using System;");
				writer.WriteLine("using System.Runtime.InteropServices;");
				writer.WriteLine("namespace OpenCL");
				writer.WriteLine("{");
				int indent = 1;
				for (int typeID = 0; typeID < types.Length; typeID++)
				{
					for (int dimensionID = 0; dimensionID < dimensions.Length; dimensionID++)
					{
						string code = GenerateVectorClass(types[typeID], lengths[typeID], dimensions[dimensionID], (types[typeID] == "float" || types[typeID] == "double"));
						foreach (var srcLine in code.Split('\n'))
						{
							var line = srcLine.Trim();
							// Simple auto-format
							if (line.StartsWith("}") && indent > 0) --indent;
							writer.WriteLine(new string('\t', indent) + line);
							if (line.StartsWith("{")) ++indent;
						}
					}
				}
				writer.WriteLine("}");
				writer.Flush();
			}
		}

		private static string GenerateSetKernelArgs(string typeName)
		{
			string code = "";
			code += "public void SetArgument(int argumentID, " + typeName + " value)\n";
			code += "{\n";
			code += "if (argumentID < 0) throw new ArgumentException(\"argumentID can't be smaller 0\", \"argumentID\");\n";
			code += "NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));\n";
			code += "}\n";
			return code;
		}

		private static string GenerateNativeSetKernelArgs(string typeName)
		{
			string code = "";
			code += "[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]\n";
			code += "public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, " + typeName + " arg_value);\n";
			return code;
		}

		private static string GenerateNativeCreateBuffer(string typeName)
		{
			string code = "";
			code += "[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]\n";
			code += "public static extern Memory clCreateBuffer(\n";
			code += "	Context context,\n";
			code += "MemoryFlags flags,\n";
			code += "uint size,\n";
			code += "[In] [MarshalAs(UnmanagedType.LPArray)] " + typeName + " data,\n";
			code += "out int errcode_ret);\n";
			return code;
		}

		private static string GenerateCreateBuffer(string typeName, bool isRef)
		{
			string code = "";
			code += "public Memory CreateBuffer(MemoryFlags flags, " + typeName + " value)\n";
			code += "{\n";
			code += "int error;\n";
			if (!isRef)
				code += "Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);\n";
			else
				code += "Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);\n";
			code += "NativeMethods.ThrowError(error);\n";
			code += "return memory;\n";
			code += "}\n";
			return code;
		}

		/// <summary>
		/// Generates a vector class
		/// </summary>
		/// <param name="typeName"></param>
		/// <param name="size"></param>
		/// <param name="dimension"></param>
		/// <param name="generateAux"></param>
		/// <returns></returns>
		private static string GenerateVectorClass(string typeName, int size, int dimension, bool generateAux)
		{
			string vectorType = typeName + dimension;

			string[] vectorComponents = new string[dimension];
			for (int i = 0; i < dimension; i++)
			{
				vectorComponents[i] = components[i];
			}

			string code = string.Format(
@"[StructLayout(LayoutKind.Explicit)]
public struct {0} : IEquatable<{0}>
{{" + "\n", vectorType);

			code += GenerateUnitVectors(typeName, vectorType, vectorComponents) + "\n";

			for (int i = 0; i < dimension; i++)
			{
				code += string.Format(
@"[FieldOffset({0})]
public {1} {2};" + "\n",
			   size * i,
			   typeName,
			   components[i].ToUpper());
			}
			if (dimension == 3)
			{
				code += string.Format(
@"[FieldOffset({0})]
private {1} {2};" + "\n",
			   size * 3,
			   typeName,
			   components[3].ToUpper());
			}
			code += "public " + vectorType + "(";
			for (int i = 0; i < dimension; i++)
			{
				code += typeName + " " + components[i].ToLower();
				if (i < dimension - 1)
					code += ", ";
			}
			code += ")\n{\n";
			for (int i = 0; i < dimension; i++)
			{
				code += "this." + components[i].ToUpper() + " = " + components[i].ToLower() + ";\n";
			}
			if (dimension == 3)
				code += "this.W = 0;\n";
			code += "}\n";

			code += GenerateOperator(typeName, vectorType, dimension, "Add", "+") + "\n";
			code += GenerateOperator(typeName, vectorType, dimension, "Subtract", "-") + "\n";
			code += GenerateOperator(typeName, vectorType, dimension, "Multiply", "*") + "\n";
			code += GenerateOperator(typeName, vectorType, dimension, "Divide", "/") + "\n";

			code += GenerateSimpleCast(typeName, vectorType, vectorComponents);

			if (dimension == 3)
			{
				// 3D Vectors have explicit cast to and from 4d vector
				code += GenerateComplexCast(typeName + "3", typeName + "4", components);
				code += GenerateComplexCast(typeName + "4", typeName + "3", components);

			}

			code += GenerateDefaultOverrides(typeName, vectorType, vectorComponents) + "\n";

			if (generateAux)
			{
				code += GenerateAuxiliary(typeName, vectorType, vectorComponents) + "\n";

				if (dimension == 3)
				{
					// Cross product
					code += GenerateCrossProduct(typeName, vectorType, vectorComponents) + "\n";
				}
			}


			code += "public " + typeName + "[] ToArray()\n";
			code += "{\n";
			code += "return new [] { " + string.Join(", ", vectorComponents) + "};\n";
			code += "}\n";

			code += "}";

			return code;
		}

		/// <summary>
		/// Generates a simple value to vector cast
		/// </summary>
		/// <param name="typeName"></param>
		/// <param name="vectorType"></param>
		/// <param name="vectorComponents"></param>
		/// <returns></returns>
		private static string GenerateSimpleCast(string typeName, string vectorType, string[] vectorComponents)
		{
			string code = "";

			string[] values = new string[vectorComponents.Length];
			for (int i = 0; i < values.Length; i++)
			{
				values[i] = "value";
			}
			code += "public static implicit operator " + vectorType + "(" + typeName + " value)\n";
			code += "{\n";
			code += "return new " + vectorType + "(" + string.Join(", ", values) + ");\n";
			code += "}\n";
			return code;
		}

		/// <summary>
		/// Creates a unit vector array
		/// </summary>
		/// <param name="length"></param>
		/// <param name="ix"></param>
		/// <returns></returns>
		private static string[] Unit(int length, int ix)
		{
			string[] unitVec = new string[length];
			for (int i = 0; i < length; i++)
			{
				if ((i == ix || ix == -2) && (ix != -1))
					unitVec[i] = "1";
				else
					unitVec[i] = "0";
			}
			return unitVec;
		}

		/// <summary>
		/// Generates unit vector definitions
		/// </summary>
		/// <param name="typeName"></param>
		/// <param name="vectorType"></param>
		/// <param name="vectorComponents"></param>
		/// <returns></returns>
		private static string GenerateUnitVectors(string typeName, string vectorType, string[] vectorComponents)
		{
			string code = "";

			code += "public static " + vectorType + " Zero { get { return new " + vectorType + "(" + string.Join(", ", Unit(vectorComponents.Length, -1)) + "); } }\n";
			code += "public static " + vectorType + " One { get { return new " + vectorType + "(" + string.Join(", ", Unit(vectorComponents.Length, -2)) + "); } }\n";
			for (int i = 0; i < vectorComponents.Length; i++)
			{
				code += "public static " + vectorType + " Unit" + vectorComponents[i] + " { get { return new " + vectorType + "(" + string.Join(", ", Unit(vectorComponents.Length, i)) + "); } }\n";
			}

			return code;
		}

		/// <summary>
		/// Generates auxiliary methods for floating point types
		/// </summary>
		/// <param name="typeName"></param>
		/// <param name="vectorType"></param>
		/// <param name="vectorComponents"></param>
		/// <returns></returns>
		private static string GenerateAuxiliary(string typeName, string vectorType, string[] vectorComponents)
		{
			string code = "";

			string[] multipliers = new string[vectorComponents.Length];
			for (int i = 0; i < multipliers.Length; i++)
			{
				multipliers[i] = vectorComponents[i] + "*" + vectorComponents[i];
			}

			code += "public " + typeName + " Length { get { return (" + typeName + ")Math.Sqrt(" + string.Join("+", multipliers) + "); } }\n";

			code += "public void Normalize()\n";
			code += "{\n";
			code += typeName + " l = this.Length;\n";
			code += "if(l == 0) return;\n";
			for (int i = 0; i < vectorComponents.Length; i++)
			{
				code += "this." + vectorComponents[i] + " = this." + vectorComponents[i] + " / l;\n";
			}
			code += "}\n";

			code += "public " + vectorType + " Normalized()\n";
			code += "{\n";
			code += vectorType + " val = this;\n";
			code += "val.Normalize();\n";
			code += "return val;\n";
			code += "}\n";

			code += "public static " + typeName + " Distance(" + vectorType + " a, " + vectorType + "  b)\n";
			code += "{\n";
			code += "return (a - b).Length;\n";
			code += "}\n";

			string[] dotAdditions = new string[vectorComponents.Length];
			for (int i = 0; i < dotAdditions.Length; i++)
			{
				dotAdditions[i] = "(a." + vectorComponents[i] + " * b." + vectorComponents[i] + ")";
			}

			code += "public static " + typeName + " Dot(" + vectorType + " a, " + vectorType + "  b)\n";
			code += "{\n";
			code += "return " + string.Join(" + ", dotAdditions) + ";\n";
			code += "}\n";

			code += "public static " + vectorType + " Lerp(" + vectorType + " a, " + vectorType + " b, " + typeName + " factor)\n";
			code += "{\n";
			code += "" + vectorType + " result = new " + vectorType + "();\n";
			for (int i = 0; i < vectorComponents.Length; i++)
			{
				code += string.Format("result.{0} = a.{0} + factor * (b.{0} - a.{0});\n", vectorComponents[i]);
			}
			code += "return result;\n";
			code += "}\n";

			code += "public static " + vectorType + " Max(" + vectorType + " a, " + vectorType + " b)\n";
			code += "{\n";
			code += vectorType + " result = new " + vectorType + "();\n";
			for (int i = 0; i < vectorComponents.Length; i++)
			{
				code += string.Format("result.{0} = (a.{0} > b.{0}) ? a.{0} : b.{0};\n", vectorComponents[i]);
			}
			code += "return result;\n";
			code += "}\n";

			code += "public static " + vectorType + " Min(" + vectorType + " a, " + vectorType + " b)\n";
			code += "{\n";
			code += vectorType + " result = new " + vectorType + "();\n";
			for (int i = 0; i < vectorComponents.Length; i++)
			{
				code += string.Format("result.{0} = (a.{0} < b.{0}) ? a.{0} : b.{0};\n", vectorComponents[i]);
			}
			code += "return result;\n";
			code += "}\n";

			code += "public static " + vectorType + " Clamp(" + vectorType + " value, " + vectorType + " min, " + vectorType + " max)\n";
			code += "{\n";
			code += "return " + vectorType + ".Max(min, " + vectorType + ".Min(max, value));\n";
			code += "}\n";

			code += "public void Negate()\n";
			code += "{\n";
			for (int i = 0; i < vectorComponents.Length; i++)
			{
				code += string.Format("this.{0} = -this.{0};\n", vectorComponents[i]);
			}

			code += "}\n";

			code += "public " + vectorType + " Negated()\n";
			code += "{\n";
			code += vectorType + " result = this;\n";
			code += "result.Negate();\n";
			code += "return result;\n";
			code += "}\n";

			return code;
		}

		/// <summary>
		/// Generates a cast for 3d to 4d or 4d to 3d.
		/// </summary>
		/// <param name="vectorTypeA"></param>
		/// <param name="vectorTypeB"></param>
		/// <param name="vectorComponents"></param>
		/// <returns></returns>
		private static string GenerateComplexCast(string vectorTypeA, string vectorTypeB, string[] vectorComponents)
		{
			string code = "";
			code += "public static explicit operator " + vectorTypeA + "(" + vectorTypeB + " value)\n";
			code += "{\n";
			code += vectorTypeA + " result;\n";
			for (int i = 0; i < vectorComponents.Length; i++)
			{
				code += string.Format("result.{0} = value.{0};\n", vectorComponents[i]);
			}
			code += "return result;\n";
			code += "}\n";
			return code;
		}

		/// <summary>
		/// Generates an operator method and overload
		/// </summary>
		/// <param name="typeName"></param>
		/// <param name="vectorType"></param>
		/// <param name="dimension"></param>
		/// <param name="operatorName"></param>
		/// <param name="operatorSign"></param>
		/// <returns></returns>
		private static string GenerateOperator(string typeName, string vectorType, int dimension, string operatorName, string operatorSign)
		{
			string code = string.Format(
				"public static {0} {1}({0} left, {0} right)\n{{\nreturn new {0}(" + "\n",
				vectorType,
				operatorName);
			for (int i = 0; i < dimension; i++)
			{
				code += "(" + typeName + ")(left." + components[i].ToUpper() + " " + operatorSign + " right." + components[i].ToUpper() + ")";
				if (i < dimension - 1)
					code += ",\n";
				else
					code += ");\n";
			}
			code += string.Format(
				"}}\n\npublic static {0} operator {1}({0} left, {0} right)\n{{\nreturn {0}.{2}(left, right);\n}}\n",
				vectorType,
				operatorSign,
				operatorName);
			return code;
		}

		/// <summary>
		/// Generates default overrides (Equals, GetHashHode, ToString)
		/// </summary>
		/// <param name="typeName"></param>
		/// <param name="vectorType"></param>
		/// <param name="vectorComponents"></param>
		/// <returns></returns>
		private static string GenerateDefaultOverrides(string typeName, string vectorType, string[] vectorComponents)
		{
			string code = string.Format(
				"private int GetInt({0} v) {{ byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }}\n",
				typeName);

			code += "public override int GetHashCode()\n" +
					"{\n" +
					"return GetInt(this." + string.Join(") ^ GetInt(", vectorComponents) + ");\n" +
					"}\n";

			code += "public override bool Equals(object obj)\n";
			code += "{\n";
			code += "if (!(obj is " + vectorType + "))\n";
			code += "return false;\n";
			code += "return this.Equals((" + vectorType + ")obj);\n";
			code += "}\n";

			code += "public bool Equals(" + vectorType + " other)\n";
			code += "{\n";
			foreach (var comp in vectorComponents)
			{
				code += string.Format("if (this.{0} != other.{0}) return false;\n", comp);
			}
			code += "return true;\n";
			code += "}\n";

			code += string.Format("public static bool operator ==({0} left, {0} right)\n", vectorType);
			code += "{\n";
			code += "return left.Equals(right);\n";
			code += "}\n";

			code += string.Format("public static bool operator !=({0} left, {0} right)\n", vectorType);
			code += "{\n";
			code += "return !left.Equals(right);\n";
			code += "}\n";

			code +=
				"public override string ToString()\n" +
				"{\n" +
				"return \"(\" + this." +
				string.Join(".ToString() + \", \" + this.", vectorComponents) + ".ToString() + \")\";\n" +
				"}\n";
			return code;
		}

		private static string GenerateCrossProduct(string typeName, string vectorType, string[] vectorComponents)
		{
			string code = "";
			code += "public static " + vectorType + " Cross(" + vectorType + " a, " + vectorType + " b)\n";
			code += "{\n";
			code += "" + vectorType + " result = new " + vectorType + "();\n";
			code += "result.X = (a.Y * b.Z) - (a.Z * b.Y);\n";
			code += "result.Y = (a.Z * b.X) - (a.X * b.Z);\n";
			code += "result.Z = (a.X * b.Y) - (a.Y * b.X);\n";
			code += "return result;\n";
			code += "}\n";
			return code;
		}
	}
}
