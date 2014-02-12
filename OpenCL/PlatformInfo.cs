using System;
using System.Collections.Generic;

using System.Text;

namespace OpenCL
{
	public enum PlatformInfo : uint
	{
		Profile = 0x0900,
		Version = 0x0901,
		Name = 0x0902,
		Vendor = 0x0903,
		Extensions = 0x0904
	}
}
