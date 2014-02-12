using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct CLEvent
	{
		public static void WaitFor(params CLEvent[] events)
		{
			if(events.Length == 0)
				return;
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clWaitForEvents(
				(uint)events.Length,
				events));
		}

		[FieldOffset(0)]
		private int id;

		public void Wait()
		{
			CLEvent.WaitFor(this);
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
	}
}
