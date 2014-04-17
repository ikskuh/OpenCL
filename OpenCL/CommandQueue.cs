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

		public CLEvent NDRangeKernel(Kernel kernel, int workdim, uint[] workOffset, uint[] globalWorkSize, uint[] localWorkSize, params CLEvent[] wait_event_list)
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

		public CLEvent NDRangeKernel(Kernel kernel, int workdim, int[] workOffset, int[] globalWorkSize, int[] localWorkSize, params CLEvent[] wait_event_list)
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

		/// <summary>
		/// Enqueue commands to read from a buffer object to host memory.
		/// </summary>
		/// <param name="memory">Refers to a valid buffer object.</param>
		/// <param name="blocking">
		/// Indicates if the read operations are blocking or non-blocking.
		/// If blocking_read is true i.e. the read command is blocking, ReadBuffer does not return until the buffer data has been read and copied into memory pointed to by ptr.
		/// If blocking is false i.e. the read command is non-blocking, ReadBuffer queues a non-blocking read command and returns.
		/// The contents of the buffer that data points to cannot be used until the read command has completed.
		/// The event argument returns an event object which can be used to query the execution status of the read command. 
		/// When the read command has completed, the contents of the buffer that data points to can be used by the application.</param>
		/// <param name="offset">The offset in bytes in the buffer object to read from.</param>
		/// <param name="data">The pointer to buffer in host memory where data is to be read into.</param>
		/// <param name="size">The size in bytes of data being read.</param>
		/// <param name="wait_event_list">wait_event_list specifies events that need to complete before this particular command can be executed.
		/// The events specified in event_wait_list act as synchronization points. The context associated with events in wait_event_list and this must be the same.</param>
		/// <returns>Returns an event object that identifies this particular read command and can be used to query
		/// or queue a wait for this particular command to complete. event can be NULL in which case it will not be
		/// possible for the application to query the status of this command or queue a wait for this command to complete.</returns>
		public CLEvent ReadBuffer(Memory memory, bool blocking, int offset, IntPtr data, int size, params CLEvent[] wait_event_list)
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

		public unsafe CLEvent ReadBuffer(Memory memory, bool blocking, int offset, void *data, int size, params CLEvent[] wait_event_list)
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

		public CLEvent ReadBuffer(Memory memory, bool blocking, int offset, byte[] target, params CLEvent[] wait_event_list)
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

		public CLEvent ReadBuffer(Memory memory, bool blocking, int offset, int[] target, params CLEvent[] wait_event_list)
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

		public CLEvent ReadBuffer(Memory memory, bool blocking, int offset, float[] target, params CLEvent[] wait_event_list)
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

		public CLEvent WriteBuffer(Memory memory, bool blocking, int offset, IntPtr data,int size, params CLEvent[] wait_event_list)
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

		public unsafe CLEvent WriteBuffer(Memory memory, bool blocking, int offset, void *data, int size, params CLEvent[] wait_event_list)
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

		public CLEvent WriteBuffer(Memory memory, bool blocking, int offset, byte[] data, params CLEvent[] wait_event_list)
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

		public CLEvent WriteBuffer<T>(Memory memory, bool blocking, int offset, T data, params CLEvent[] wait_event_list) where T : struct
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

		public unsafe CLEvent ReadImage(Memory image, bool blocking, uint[] origin, uint[] region, int row_pitch, int slice_pitch, void *ptr, params CLEvent[] wait_event_list)
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

		public CLEvent ReadImage(Memory image, bool blocking, uint[] origin, uint[] region, int row_pitch, int slice_pitch, IntPtr ptr, params CLEvent[] wait_event_list)
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

		public CLEvent ReadImage(Memory image, bool blocking, int[] origin, int[] region, int row_pitch, int slice_pitch, IntPtr ptr, params CLEvent[] wait_event_list)
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

		public unsafe CLEvent WriteImage(Memory image, bool blocking, uint[] origin, uint[] region, int row_pitch, int slice_pitch, void* ptr, params CLEvent[] wait_event_list)
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

		public CLEvent WriteImage(Memory image, bool blocking, uint[] origin, uint[] region, int row_pitch, int slice_pitch, IntPtr ptr, params CLEvent[] wait_event_list)
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

		public CLEvent AcquireGLObjects(Memory[] objects, params CLEvent[] wait_event_list)
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

		public CLEvent ReleaseGLObjects(Memory[] objects, params CLEvent[] wait_event_list)
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

		public static bool operator ==(CommandQueue a, CommandQueue b)
		{
			return a.id == b.id;
		}

		public static bool operator !=(CommandQueue a, CommandQueue b)
		{
			return a.id != b.id;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (obj is CommandQueue)
				return this.id == ((CommandQueue)obj).id;
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
			NativeMethods.ThrowError(NativeMethods.clReleaseCommandQueue(this));
		}
	}
}
