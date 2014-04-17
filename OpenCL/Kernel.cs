using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public partial struct Kernel : IDisposable
	{
		[FieldOffset(0)]
		private int id;
		public void SetArgument(int argumentID, Memory buffer)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, 4, ref buffer));
		}

		public void SetArgument(int argumentID, IntPtr data, int length)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)length, data));
		}

		public unsafe void SetArgument(int argumentID, void* data, int length)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)length, data));
		}

		public static bool operator ==(Kernel a, Kernel b)
		{
			return a.id == b.id;
		}

		public static bool operator !=(Kernel a, Kernel b)
		{
			return a.id != b.id;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (obj is Kernel)
				return this.id == ((Kernel)obj).id;
			else
				return false;
		}

		public override int GetHashCode()
		{
			return this.id.GetHashCode();
		}

		public int ID
		{
			get { return id; }
			//set { id = value; }
		}

		public void Dispose()
		{
			NativeMethods.ThrowError(NativeMethods.clReleaseKernel(this));
		}

		#region Static Methods

		/// <summary>
		/// Compiles a single kernel from a single source file
		/// </summary>
		/// <param name="context">The context for the kernel.</param>
		/// <param name="device">The device the kernel should be compiled for.</param>
		/// <param name="source">Source file for the kernel.</param>
		/// <param name="kernelName">Kernel name.</param>
		/// <returns>Compiled kernel.</returns>
		public static Kernel CompileFrom(Context context, Device device, string source, string kernelName)
		{
			var program = context.CreateProgram(source);
			try
			{
				program.Build("", device);
			}
			catch(OpenCLException ex)
			{
				string buildlog = program.GetBuildLog(device);
				throw new InvalidOperationException(buildlog, ex);
			}
			return program.CreateKernel(kernelName);
		}

		#endregion
	}
}
