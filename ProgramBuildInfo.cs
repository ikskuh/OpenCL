using System;
using System.Collections.Generic;

using System.Text;

namespace OpenCL
{
	public enum ProgramBuildInfo : uint
	{
		Status = 0x1181,
		Options = 0x1182,
		Log = 0x1183,
	}
}
