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

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref byte data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref byte2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref byte3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref byte4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] byte4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref sbyte data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref sbyte2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref sbyte3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref sbyte4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] sbyte4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref short data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref short2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref short3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref short4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] short4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref ushort data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref ushort2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref ushort3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref ushort4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ushort4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref int data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref int2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref int3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref int4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] int4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref uint data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref uint2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref uint3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref uint4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] uint4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref long data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref long2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref long3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref long4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] long4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref ulong data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref ulong2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref ulong3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref ulong4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ulong4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref float data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref float2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref float3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref float4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] float4[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref double data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref double2 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double2[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double2[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double2[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref double3 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double3[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double3[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double3[, ,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] ref double4 data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double4[] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double4[,] data,
		out int errcode_ret);

		[DllImport(Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern Memory clCreateBuffer(
			Context context,
		MemoryFlags flags,
		uint size,
		[In] [MarshalAs(UnmanagedType.LPArray)] double4[, ,] data,
		out int errcode_ret);

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

	partial struct Context
	{
		public Memory CreateBuffer(MemoryFlags flags, byte value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, sbyte4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, short4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ushort4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, uint4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, long4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, ulong4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double2 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double2[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double2[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double2[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double3 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double3[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double3[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double3[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double4 value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)Marshal.SizeOf(value), ref value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double4[] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double4[,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, double4[, ,] value)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(Helpers.SizeOf(value)), value, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

	}
}
