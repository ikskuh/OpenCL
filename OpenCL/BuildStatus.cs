using System;
using System.Collections.Generic;

using System.Text;

namespace OpenCL
{
	public enum BuildStatus : int
	{
		Success = 0,
		None = -1,
		Error = -2,
		InProgress = -3,
	}
}
