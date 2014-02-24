﻿using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Kernel : IDisposable
	{
		[FieldOffset(0)]
		private int id;

		public void SetArgument(int argumentID, int value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clSetKernelArg(this, (uint)argumentID, 4, ref value));
		}

		public void SetArgument(int argumentID, byte value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clSetKernelArg(this, (uint)argumentID, 1, ref value));
		}

		public void SetArgument(int argumentID, float value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clSetKernelArg(this, (uint)argumentID, 1, ref value));
		}

		public void SetArgument(int argumentID, uint value)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clSetKernelArg(this, (uint)argumentID, 4, ref value));
		}

		public void SetArgument(int argumentID, Memory buffer)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clSetKernelArg(this, (uint)argumentID, 4, ref buffer));
		}

		public void SetArgument(int argumentID, IntPtr data, int length)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)length, data));
		}

		public unsafe void SetArgument(int argumentID, void *data, int length)
		{
			if (argumentID < 0) throw new ArgumentException("argumentID can't be smaller 0", "argumentID");
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clSetKernelArg(this, (uint)argumentID, (uint)length, data));
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public void Dispose()
		{
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clReleaseKernel(this));
		}
	}
}