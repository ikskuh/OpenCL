using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Context : IDisposable
	{
		//CL_GL_CONTEXT_KHR			0x2008
		//CL_EGL_DISPLAY_KHR		0x2009
		//CL_GLX_DISPLAY_KHR		0x200A
		//CL_WGL_HDC_KHR			0x200B
		//CL_CGL_SHAREGROUP_KHR		0x200C

		public static readonly IntPtr CL_GL_CONTEXT_KHR = (IntPtr)0x2008;
		public static readonly IntPtr CL_WGL_HDC_KHR = (IntPtr)0x200B;
		public static readonly IntPtr CL_CONTEXT_PLATFORM = (IntPtr)0x1084;

		public static Context Create(params Device[] devices)
		{
			int error;
			var context = NativeMethods.clCreateContext(IntPtr.Zero, (uint)devices.Length, devices, IntPtr.Zero, IntPtr.Zero, out error);
			NativeMethods.ThrowError(error);
			return context;
		}

		public static Context Create(IntPtr[] properties, params Device[] devices)
		{
			int error;
			var context = NativeMethods.clCreateContext(properties, (uint)devices.Length, devices, IntPtr.Zero, IntPtr.Zero, out error);
			NativeMethods.ThrowError(error);
			return context;
		}

		[FieldOffset(0)]
		private int id;

		public CommandQueue CreateQueue(Device device, CommandQueueProperties properties)
		{
			int error;
			CommandQueue queue = NativeMethods.clCreateCommandQueue(this, device, properties, out error);
			NativeMethods.ThrowError(error);
			return queue;
		}

		public Memory CreateBuffer(MemoryFlags flags, int size)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)size, IntPtr.Zero, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer<T>(MemoryFlags flags, T value) where T : struct
		{
			int error;
			int size = Marshal.SizeOf(typeof(T));

			IntPtr mem = Marshal.AllocHGlobal(size);
			Marshal.StructureToPtr(value, mem, false);	

			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(size), mem, out error);
			Marshal.FreeHGlobal(mem);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int size, IntPtr data)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)size, data, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public unsafe Memory CreateBuffer(MemoryFlags flags, int size, void *data)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)size, data, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, byte[] values)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(values.Length), values, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, float[] values)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(sizeof(float) * values.Length), values, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateBuffer(MemoryFlags flags, int[] values)
		{
			int error;
			Memory memory = NativeMethods.clCreateBuffer(this, flags, (uint)(sizeof(float) * values.Length), values, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateImage2D(MemoryFlags flags, ImageFormat format,  int width, int height, int row_pitch, IntPtr host_ptr)
		{
			int error;
			Memory memory = NativeMethods.clCreateImage2D(this, flags, ref format, (uint)width, (uint)height, (uint)row_pitch, host_ptr, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public unsafe Memory CreateImage2D(MemoryFlags flags, ImageFormat format, int width, int height, int row_pitch, void *host_ptr)
		{
			int error;
			Memory memory = NativeMethods.clCreateImage2D(this, flags, ref format, (uint)width, (uint)height, (uint)row_pitch, host_ptr, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateImage3D(MemoryFlags flags, ImageFormat format, int width, int height, int depth, int row_pitch, int slice_pitch, IntPtr host_ptr)
		{
			int error;
			Memory memory = NativeMethods.clCreateImage3D(this, flags, ref format, (uint)width, (uint)height, (uint)depth, (uint)row_pitch, (uint)slice_pitch, host_ptr, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public Memory CreateFromGLTexture2D(MemoryFlags flags, uint texture_target, int miplevel, uint texture)
		{
			int error;
			Memory memory = NativeMethods.clCreateFromGLTexture2D(this, flags, texture_target, miplevel, texture, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		public unsafe Memory CreateImage3D(MemoryFlags flags, ImageFormat format, int width, int height, int depth, int row_pitch, int slice_pitch, void* host_ptr)
		{
			int error;
			Memory memory = NativeMethods.clCreateImage3D(this, flags, ref format, (uint)width, (uint)height, (uint)depth, (uint)row_pitch, (uint)slice_pitch, host_ptr, out error);
			NativeMethods.ThrowError(error);
			return memory;
		}

		static List<KeyValuePair<uint[], IntPtr[]>> stuffCollection = new List<KeyValuePair<uint[], IntPtr[]>>();

		public Program CreateProgram(params string[] sources)
		{
			uint[] lengths = new uint[sources.Length];
			IntPtr[] strings = new IntPtr[sources.Length];
			for (int i = 0; i < lengths.Length; i++)
			{
				strings[i] = Marshal.StringToHGlobalAnsi(sources[i]);
				lengths[i] = (uint)sources[i].Length;
			}
			stuffCollection.Add(new KeyValuePair<uint[], IntPtr[]>(lengths, strings));
			int error;
			Program pgm = NativeMethods.clCreateProgramWithSource(this, (uint)sources.Length, strings, lengths, out error);
			NativeMethods.ThrowError(error);
			return pgm;
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public void Dispose()
		{
			NativeMethods.ThrowError(NativeMethods.clReleaseContext(this));
		}
	}
}
