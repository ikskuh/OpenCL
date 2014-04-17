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

		public static bool operator ==(Memory a, Memory b)
		{
			return a.id == b.id;
		}

		public static bool operator !=(Memory a, Memory b)
		{
			return a.id != b.id;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (obj is Memory)
				return this.id == ((Memory)obj).id;
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
			if (this.id == 0) return;
			NativeMethods.ThrowError(NativeMethods.clReleaseMemObject(this));
			this.id = 0;
		}
	}
}
