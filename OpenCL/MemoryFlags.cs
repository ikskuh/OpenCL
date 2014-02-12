using System;
using System.Collections.Generic;

using System.Text;

namespace OpenCL
{
	[Flags]
	public enum MemoryFlags : ulong
	{
		None = 0,
		ReadWrite = (1 << 0),
		WriteOnly = (1 << 1),
		ReadOnly = (1 << 2),
		UseHostPtr = (1 << 3),
		AllocHostPtr = (1 << 4),
		CopyHostPtr = (1 << 5),
	}
}
