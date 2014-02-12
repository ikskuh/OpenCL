using System;
using System.Collections.Generic;

using System.Text;

namespace OpenCL
{
	[Serializable]
	public class OpenCLException : Exception
	{
		private CLError error;

		public OpenCLException(CLError error)
			: base(error.ToString())
		{
			this.error = error;
		}

		public CLError ErrorCode
		{
			get { return error; }
		}
	}
}
