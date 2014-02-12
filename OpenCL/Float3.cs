using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;


namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Float3
	{
		[FieldOffset(0)]
		public float X;

		[FieldOffset(4)]
		public float Y;

		[FieldOffset(8)]
		public float Z;

		[FieldOffset(12)]
		private float padding;

		public Float3(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.padding = 0;
		}

		public static float Dot(Float3 left, Float3 right)
		{
			return (((left.X * right.X) + (left.Y * right.Y)) + (left.Z * right.Z));
		}

		public static Float3 Cross(Float3 left, Float3 right)
		{
			Float3 vector;
			vector.X = (left.Y * right.Z) - (left.Z * right.Y);
			vector.Y = (left.Z * right.X) - (left.X * right.Z);
			vector.Z = (left.X * right.Y) - (left.Y * right.X);
			vector.padding = 0;
			return vector;
		}

		public void Normalize()
		{
			float len = this.Length;
			this = new Float3(
				this.X / len,
				this.Y / len,
				this.Z / len);
		}

		public float Length
		{
			get { return (float)Math.Sqrt(this.LengthSquared); }
		}

		public double LengthSquared
		{
			get { return this.X * this.X + this.Y * this.Y + this.Z * this.Z; }
		}

		public static Float3 Zero { get { return new Float3(0, 0, 0); } }
		public static Float3 UnitX { get { return new Float3(1, 0, 0); } }
		public static Float3 UnitY { get { return new Float3(0, 1, 0); } }
		public static Float3 UnitZ { get { return new Float3(0, 0, 1); } }
		public static Float3 One { get { return new Float3(1, 1, 1); } }

		#region Float3 x Float3

		public static Float3 operator +(Float3 left, Float3 right)
		{
			return new Float3(
				left.X + right.X,
				left.Y + right.Y,
				left.Z + right.Z);
		}

		public static Float3 operator -(Float3 left, Float3 right)
		{
			return new Float3(
				left.X - right.X,
				left.Y - right.Y,
				left.Z - right.Z);
		}

		#endregion

		#region Float3 x float

		public static Float3 operator +(Float3 left, float right)
		{
			return new Float3(
				left.X + right,
				left.Y + right,
				left.Z + right);
		}

		public static Float3 operator +(float left, Float3 right)
		{
			return right + left;
		}

		public static Float3 operator -(float left, Float3 right)
		{
			return new Float3(
				left - right.X,
				left - right.Y,
				left - right.Z);
		}

		public static Float3 operator -(Float3 left, float right)
		{
			return new Float3(
				left.X - right,
				left.Y - right,
				left.Z - right);
		}

		public static Float3 operator *(Float3 left, float right)
		{
			return new Float3(
				left.X * right,
				left.Y * right,
				left.Z * right);
		}

		public static Float3 operator *(float left, Float3 right)
		{
			return right * left;
		}

		#endregion
	}
}
