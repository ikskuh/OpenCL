using System;
using System.Runtime.InteropServices;
namespace OpenCL
{
	partial class NativeMethods
	{
		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref byte arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref byte2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref byte3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref byte4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref sbyte arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref sbyte2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref sbyte3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref sbyte4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref short arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref short2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref short3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref short4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref ushort arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref ushort2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref ushort3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref ushort4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref int arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref int2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref int3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref int4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref uint arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref uint2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref uint3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref uint4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref long arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref long2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref long3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref long4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref ulong arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref ulong2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref ulong3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref ulong4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref float arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref float2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref float3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref float4 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref double arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref double2 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref double3 arg_value);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int clSetKernelArg(Kernel kernel, uint arg_index, uint arg_size, ref double4 arg_value);

	}

	partial struct Kernel
	{
		public void SetArgument(int argumentID, byte value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, byte2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, byte3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, byte4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, sbyte value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, sbyte2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, sbyte3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, sbyte4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, short value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, short2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, short3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, short4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, ushort value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, ushort2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, ushort3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, ushort4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, int value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, int2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, int3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, int4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, uint value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, uint2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, uint3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, uint4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, long value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, long2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, long3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, long4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, ulong value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, ulong2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, ulong3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, ulong4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, float value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, float2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, float3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, float4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, double value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, double2 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, double3 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

		public void SetArgument(int argumentID, double4 value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			NativeMethods.ThrowError(NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)Marshal.SizeOf(value), ref value));
		}

	}
}
