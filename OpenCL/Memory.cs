using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Memory : IDisposable
	{
		[FieldOffset(0)]
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public void Dispose()
		{
			if (this.id == 0) return;
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clReleaseMemObject(this));
			this.id = 0;
		}
	}
}
