using System;
using System.Collections.Generic;

using System.Text;

namespace OpenCL
{
	public enum DeviceType : ulong
	{
		Default = (1 << 0),
		CPU = (1 << 1),
		GPU = (1 << 2),
		Accelerator = (1 << 3),
		All = 0xFFFFFFFF
	}
}
