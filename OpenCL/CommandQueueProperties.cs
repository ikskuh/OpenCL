using System;
using System.Collections.Generic;

using System.Text;

namespace OpenCL
{
	public enum CommandQueueProperties : ulong
	{
		None = 0,
		OutOfOrderExecModeEnable = (1 << 0),
		ProfilingEnable = (1 << 1),
	}
}
