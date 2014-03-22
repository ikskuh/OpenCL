using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct CommandQueue : IDisposable
	{
		[FieldOffset(0)]
		private int id;

		public void Flush()
		{
			NativeMethods.ThrowError(NativeMethods.clFlush(this));
		}

		public void Finish()
		{
			NativeMethods.ThrowError(NativeMethods.clFinish(this));
		}

		public CLEvent EnqueueNDRangeKernel(Kernel kernel, int workdim, uint[] workOffset, uint[] globalWorkSize, uint[] localWorkSize, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueNDRangeKernel(
				this,
				kernel,
				(uint)workdim,
				workOffset,
				globalWorkSize,
				localWorkSize,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueNDRangeKernel(Kernel kernel, int workdim, int[] workOffset, int[] globalWorkSize, int[] localWorkSize, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueNDRangeKernel(
				this,
				kernel,
				(uint)workdim,
				workOffset,
				globalWorkSize,
				localWorkSize,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueReadBuffer(Memory memory, bool blocking, int offset, IntPtr data, int size, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueReadBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)size,
				data,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public unsafe CLEvent EnqueueReadBuffer(Memory memory, bool blocking, int offset, void *data, int size, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueReadBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)size,
				data,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueReadBuffer(Memory memory, bool blocking, int offset, byte[] target, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueReadBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)(sizeof(byte) * target.Length),
				target,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueReadBuffer(Memory memory, bool blocking, int offset, int[] target, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueReadBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)(sizeof(int) * target.Length),
				target,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueReadBuffer(Memory memory, bool blocking, int offset, float[] target, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueReadBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)(sizeof(float) * target.Length),
				target,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueWriteBuffer(Memory memory, bool blocking, int offset, IntPtr data,int size, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueWriteBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)size,
				data,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public unsafe CLEvent EnqueueWriteBuffer(Memory memory, bool blocking, int offset, void *data, int size, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueWriteBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)size,
				data,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueWriteBuffer(Memory memory, bool blocking, int offset, byte[] data, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueWriteBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)data.Length,
				data,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueWriteBuffer<T>(Memory memory, bool blocking, int offset, T data, params CLEvent[] wait_event_list) where T : struct
		{
			CLEvent ev;
			int size = Marshal.SizeOf(typeof(T));

			IntPtr mem = Marshal.AllocHGlobal(size);
			Marshal.StructureToPtr(data, mem, false);

			int error = NativeMethods.clEnqueueWriteBuffer(
				this,
				memory,
				(uint)(blocking ? 1 : 0),
				(uint)offset,
				(uint)size,
				mem,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev);
			Marshal.FreeHGlobal(mem);
			NativeMethods.ThrowError(error);
			return ev;
		}

		public unsafe CLEvent EnqueueReadImage(Memory image, bool blocking, uint[] origin, uint[] region, int row_pitch, int slice_pitch, void *ptr, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			int error = NativeMethods.clEnqueueReadImage(
				this,
				image,
				blocking,
				origin,
				region,
				(uint)row_pitch,
				(uint)slice_pitch,
				ptr,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev);
			NativeMethods.ThrowError(error);
			return ev;
		}

		public CLEvent EnqueueReadImage(Memory image, bool blocking, uint[] origin, uint[] region, int row_pitch, int slice_pitch, IntPtr ptr, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			int error = NativeMethods.clEnqueueReadImage(
				this,
				image,
				blocking,
				origin,
				region,
				(uint)row_pitch,
				(uint)slice_pitch,
				ptr,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev);
			NativeMethods.ThrowError(error);
			return ev;
		}

		public CLEvent EnqueueReadImage(Memory image, bool blocking, int[] origin, int[] region, int row_pitch, int slice_pitch, IntPtr ptr, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			int error = NativeMethods.clEnqueueReadImage(
				this,
				image,
				blocking,
				origin,
				region,
				(uint)row_pitch,
				(uint)slice_pitch,
				ptr,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev);
			NativeMethods.ThrowError(error);
			return ev;
		}

		public unsafe CLEvent EnqueueWriteImage(Memory image, bool blocking, uint[] origin, uint[] region, int row_pitch, int slice_pitch, void* ptr, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			int error = NativeMethods.clEnqueueWriteImage(
				this,
				image,
				blocking,
				origin,
				region,
				(uint)row_pitch,
				(uint)slice_pitch,
				ptr,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev);
			NativeMethods.ThrowError(error);
			return ev;
		}

		public CLEvent EnqueueWriteImage(Memory image, bool blocking, uint[] origin, uint[] region, int row_pitch, int slice_pitch, IntPtr ptr, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			int error = NativeMethods.clEnqueueWriteImage(
				this,
				image,
				blocking,
				origin,
				region,
				(uint)row_pitch,
				(uint)slice_pitch,
				ptr,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev);
			NativeMethods.ThrowError(error);
			return ev;
		}

		public CLEvent EnqueueAcquireGLObjects(Memory[] objects, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueAcquireGLObjects(
				this,
				(uint)objects.Length,
				objects,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public CLEvent EnqueueReleaseGLObjects(Memory[] objects, params CLEvent[] wait_event_list)
		{
			CLEvent ev;
			NativeMethods.ThrowError(NativeMethods.clEnqueueReleaseGLObjects(
				this,
				(uint)objects.Length,
				objects,
				(uint)wait_event_list.Length,
				wait_event_list.Length > 0 ? wait_event_list : null,
				out ev));
			return ev;
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public void Dispose()
		{
			NativeMethods.ThrowError(NativeMethods.clReleaseCommandQueue(this));
		}
	}
}
