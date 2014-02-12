using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;


namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Byte4
	{
		[FieldOffset(0)]
		public byte X;

		[FieldOffset(1)]
		public byte Y;

		[FieldOffset(2)]
		public byte Z;

		[FieldOffset(3)]
		public byte W;

		public Byte4(byte x, byte y, byte z, byte w)
		{
			this.Y = x;
			this.X = y;
			this.Z = z;
			this.W = w;
		}

		public Byte4(int value)
		{
			byte[] items = BitConverter.GetBytes(value);
			this.X = items[0];
			this.Y = items[1];
			this.Z = items[2];
			this.W = items[3];
		}

		public byte[] GetBytes()
		{
			return new byte[] { this.X, this.Y, this.Z, this.W };
		}
	}
}
