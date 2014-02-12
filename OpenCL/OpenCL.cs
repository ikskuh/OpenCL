using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;


namespace OpenCL
{
	internal static class OpenCLNative
	{
		public const string Library = "opencl.dll";
		internal static class NativeMethods
		{
			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetPlatformIDs(
				[In] [MarshalAs(UnmanagedType.U4)] uint num_entries,
				[Out] [MarshalAs(UnmanagedType.LPArray)] Platform[] platforms,
				[Out] [MarshalAs(UnmanagedType.U4)] out uint num_platforms);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetPlatformInfo(
				Platform platform,
				PlatformInfo param_name,
				int param_value_size,
				[MarshalAs(UnmanagedType.LPStr)] StringBuilder param_value,
				out int param_value_size_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetDeviceIDs(
				Platform platform,
				DeviceType device_type,
				uint num_entries,
				[Out] [MarshalAs(UnmanagedType.LPArray)] Device[] devices,
				[Out] [MarshalAs(UnmanagedType.U4)] out uint num_devices);

			#region clGetDeviceInfo

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetDeviceInfo(
				Device device,
				DeviceInfo param_name,
				int param_value_size,
				IntPtr param_value,
				out int param_value_size_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetDeviceInfo(
				Device device,
				DeviceInfo param_name,
				int param_value_size,
				out uint param_value,
				out int param_value_size_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetDeviceInfo(
				Device device,
				DeviceInfo param_name,
				int param_value_size,
				out ulong param_value,
				out int param_value_size_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetDeviceInfo(
				Device device,
				DeviceInfo param_name,
				int param_value_size,
				out int param_value,
				out int param_value_size_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetDeviceInfo(
				Device device,
				DeviceInfo param_name,
				int param_value_size,
				out long param_value,
				out int param_value_size_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetDeviceInfo(
				Device device,
				DeviceInfo param_name,
				int param_value_size,
				[MarshalAs(UnmanagedType.LPStr)]StringBuilder param_value,
				out int param_value_size_ret);

			#endregion

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Context clCreateContext(
				IntPtr properties,
				uint num_devices,
				[In] [MarshalAs(UnmanagedType.LPArray)] Device[] devices,
				IntPtr pfn_notify, //void (CL_CALLBACK *pfn_notify)(const char *errinfo, const void *private_info, size_t cb, void *user_data),
				IntPtr user_data,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Context clCreateContext(
				[In] [MarshalAs(UnmanagedType.LPArray)] IntPtr[] properties,
				uint num_devices,
				[In] [MarshalAs(UnmanagedType.LPArray)] Device[] devices,
				IntPtr pfn_notify, //void (CL_CALLBACK *pfn_notify)(const char *errinfo, const void *private_info, size_t cb, void *user_data),
				IntPtr user_data,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern CommandQueue clCreateCommandQueue(
				Context context,
				Device device,
				CommandQueueProperties properties,
				out int errcode_ret);

			#region clCreateBuffer

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Memory clCreateBuffer(
				Context context,
				MemoryFlags flags,
				uint size,
				IntPtr host_ptr,
				out int errcode_ret);


			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public unsafe static extern Memory clCreateBuffer(
				Context context,
				MemoryFlags flags,
				uint size,
				void* host_ptr,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Memory clCreateBuffer(
				Context context,
				MemoryFlags flags,
				uint size,
				[In] [MarshalAs(UnmanagedType.LPArray)] byte[] data,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Memory clCreateBuffer(
				Context context,
				MemoryFlags flags,
				uint size,
				[In] [MarshalAs(UnmanagedType.LPArray)] float[] data,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Memory clCreateBuffer(
				Context context,
				MemoryFlags flags,
				uint size,
				[In] [MarshalAs(UnmanagedType.LPArray)] int[] data,
				out int errcode_ret);

			#endregion

			#region clCreateImage[n]D

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static unsafe extern Memory clCreateImage2D(
				Context context,
				MemoryFlags flags,
				ref ImageFormat image_format,
				uint image_width,
				uint image_height,
				uint image_row_pitch,
				void* host_ptr,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Memory clCreateImage2D(
				Context context,
				MemoryFlags flags,
				ref ImageFormat image_format,
				uint image_width,
				uint image_height,
				uint image_row_pitch,
				IntPtr host_ptr,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static unsafe extern Memory clCreateImage3D(
				Context context,
				MemoryFlags flags,
				ref ImageFormat image_format,
				uint image_width,
				uint image_height,
				uint image_depth,
				uint image_row_pitch,
				uint image_slice_pitch,
				void* host_ptr,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Memory clCreateImage3D(
				Context context,
				MemoryFlags flags,
				ref ImageFormat image_format,
				uint image_width,
				uint image_height,
				uint image_depth,
				uint image_row_pitch,
				uint image_slice_pitch,
				IntPtr host_ptr,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern unsafe int clEnqueueReadImage(
				CommandQueue command_queue,
				Memory image,
				bool blocking_read,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] origin,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] region,
				uint row_pitch,
				uint slice_pitch,
				void* ptr,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent cl_event);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueReadImage(
				CommandQueue command_queue,
				Memory image,
				bool blocking_read,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] origin,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] region,
				uint row_pitch,
				uint slice_pitch,
				IntPtr ptr,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent cl_event);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern unsafe int clEnqueueWriteImage(
				CommandQueue command_queue,
				Memory image,
				bool blocking_write,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] origin,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] region,
				uint input_row_pitch,
				uint input_slice_pitch,
				void* ptr,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent cl_event);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueWriteImage(
				CommandQueue command_queue,
				Memory image,
				bool blocking_write,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] origin,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] region,
				uint input_row_pitch,
				uint input_slice_pitch,
				IntPtr ptr,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent cl_event);

			#endregion

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Program clCreateProgramWithSource(
				Context context,
				uint count,
				[In] [MarshalAs(UnmanagedType.LPArray)] IntPtr[] strings,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] lengths,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clBuildProgram(
				Program program,
				uint num_devices,
				[In] [MarshalAs(UnmanagedType.LPArray)] Device[] device_list,
				[In] [MarshalAs(UnmanagedType.LPStr)] string options,
				IntPtr pfn_notify, //	void (CL_CALLBACK *pfn_notify)(cl_program program, void *user_data)
				IntPtr user_data);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetProgramBuildInfo(
				Program program,
				Device device,
				ProgramBuildInfo param_name,
				uint param_value_size,
				[MarshalAs(UnmanagedType.LPStr)]StringBuilder param_value,
				out uint param_value_size_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clGetProgramBuildInfo(
				Program program,
				Device device,
				ProgramBuildInfo param_name,
				uint param_value_size,
				out BuildStatus param_value,
				out uint param_value_size_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Kernel clCreateKernel(
				Program program,
				[MarshalAs(UnmanagedType.LPStr)]string kernel_name,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clCreateKernelsInProgram(
				Program program,
				uint num_kernels,
				[In] [MarshalAs(UnmanagedType.LPArray)] Kernel[] kernels,
				out uint num_kernels_ret);

			#region clSetKernelArg

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clSetKernelArg(
				Kernel kernel,
				uint arg_index,
				uint arg_size,
				IntPtr arg_value);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public unsafe static extern int clSetKernelArg(
				Kernel kernel,
				uint arg_index,
				uint arg_size,
				void* arg_value);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clSetKernelArg(
				Kernel kernel,
				uint arg_index,
				uint arg_size,
				ref byte arg_value);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clSetKernelArg(
				Kernel kernel,
				uint arg_index,
				uint arg_size,
				ref int arg_value);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clSetKernelArg(
				Kernel kernel,
				uint arg_index,
				uint arg_size,
				ref uint arg_value);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clSetKernelArg(
				Kernel kernel,
				uint arg_index,
				uint arg_size,
				ref float arg_value);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clSetKernelArg(
				Kernel kernel,
				uint arg_index,
				uint arg_size,
				ref Memory arg_value);

			#endregion

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueNDRangeKernel(
				CommandQueue command_queue,
				Kernel kernel,
				uint work_dim,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] global_work_offset,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] global_work_size,
				[In] [MarshalAs(UnmanagedType.LPArray)] uint[] local_work_size,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clFlush(CommandQueue queue);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clFinish(CommandQueue queue);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clWaitForEvents(
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list);

			#region clEnqueueReadBuffer

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueReadBuffer(
				CommandQueue command_queue,
				Memory buffer,
				uint blocking_read,
				uint offset,
				uint cb,
				IntPtr ptr,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public unsafe static extern int clEnqueueReadBuffer(
				CommandQueue command_queue,
				Memory buffer,
				uint blocking_read,
				uint offset,
				uint cb,
				void* ptr,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueReadBuffer(
				CommandQueue command_queue,
				Memory buffer,
				uint blocking_read,
				uint offset,
				uint cb,
				[Out] [MarshalAs(UnmanagedType.LPArray)] byte[] values,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueReadBuffer(
				CommandQueue command_queue,
				Memory buffer,
				uint blocking_read,
				uint offset,
				uint cb,
				[Out] [MarshalAs(UnmanagedType.LPArray)] float[] values,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueReadBuffer(
				CommandQueue command_queue,
				Memory buffer,
				uint blocking_read,
				uint offset,
				uint cb,
				[Out] [MarshalAs(UnmanagedType.LPArray)] int[] values,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			#endregion

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueWriteBuffer(
				CommandQueue command_queue,
				Memory buffer,
				uint blocking_read,
				uint offset,
				uint cb,
				IntPtr ptr,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public unsafe static extern int clEnqueueWriteBuffer(
				CommandQueue command_queue,
				Memory buffer,
				uint blocking_read,
				uint offset,
				uint cb,
				void* ptr,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueWriteBuffer(
				CommandQueue command_queue,
				Memory buffer,
				uint blocking_read,
				uint offset,
				uint cb,
				[In] [MarshalAs(UnmanagedType.LPArray)] byte[] data,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clReleaseContext(Context context);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clReleaseCommandQueue(CommandQueue commandQueue);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clReleaseMemObject(Memory memory);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clReleaseProgram(Program program);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clReleaseKernel(Kernel kernel);


			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern Memory clCreateFromGLTexture2D(
				Context context,
				MemoryFlags flags,
				uint texture_target,
				int miplevel,
				uint texture,
				out int errcode_ret);

			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueAcquireGLObjects(
				CommandQueue command_queue,
				uint num_objects,
				[In] [MarshalAs(UnmanagedType.LPArray)] Memory[] mem_objects,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);


			[DllImport(OpenCLNative.Library, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
			public static extern int clEnqueueReleaseGLObjects(
				CommandQueue command_queue,
				uint num_objects,
				[In] [MarshalAs(UnmanagedType.LPArray)] Memory[] mem_objects,
				uint num_events_in_wait_list,
				[In] [MarshalAs(UnmanagedType.LPArray)] CLEvent[] event_wait_list,
				out CLEvent ev);
		}

		internal static void ThrowError(int errorCode)
		{
			CLError error = (CLError)errorCode;
			if (error == CLError.Success)
				return;
			throw new OpenCLException(error);
		}
	}
}
