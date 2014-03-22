using System;
using System.Runtime.InteropServices;
namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct byte2 : IEquatable<byte2>
	{
		public static byte2 Zero { get { return new byte2(0, 0); } }
		public static byte2 One { get { return new byte2(1, 1); } }
		public static byte2 UnitX { get { return new byte2(1, 0); } }
		public static byte2 UnitY { get { return new byte2(0, 1); } }
		
		[FieldOffset(0)]
		public byte X;
		[FieldOffset(1)]
		public byte Y;
		public byte2(byte x, byte y)
		{
			this.X = x;
			this.Y = y;
		}
		public static byte2 Add(byte2 left, byte2 right)
		{
			return new byte2(
			(byte)(left.X + right.X),
			(byte)(left.Y + right.Y));
		}
		
		public static byte2 operator +(byte2 left, byte2 right)
		{
			return byte2.Add(left, right);
		}
		
		public static byte2 Subtract(byte2 left, byte2 right)
		{
			return new byte2(
			(byte)(left.X - right.X),
			(byte)(left.Y - right.Y));
		}
		
		public static byte2 operator -(byte2 left, byte2 right)
		{
			return byte2.Subtract(left, right);
		}
		
		public static byte2 Multiply(byte2 left, byte2 right)
		{
			return new byte2(
			(byte)(left.X * right.X),
			(byte)(left.Y * right.Y));
		}
		
		public static byte2 operator *(byte2 left, byte2 right)
		{
			return byte2.Multiply(left, right);
		}
		
		public static byte2 Divide(byte2 left, byte2 right)
		{
			return new byte2(
			(byte)(left.X / right.X),
			(byte)(left.Y / right.Y));
		}
		
		public static byte2 operator /(byte2 left, byte2 right)
		{
			return byte2.Divide(left, right);
		}
		
		public static implicit operator byte2(byte value)
		{
			return new byte2(value, value);
		}
		private int GetInt(byte v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is byte2))
			return false;
			return this.Equals((byte2)obj);
		}
		public bool Equals(byte2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(byte2 left, byte2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(byte2 left, byte2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct byte3 : IEquatable<byte3>
	{
		public static byte3 Zero { get { return new byte3(0, 0, 0); } }
		public static byte3 One { get { return new byte3(1, 1, 1); } }
		public static byte3 UnitX { get { return new byte3(1, 0, 0); } }
		public static byte3 UnitY { get { return new byte3(0, 1, 0); } }
		public static byte3 UnitZ { get { return new byte3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public byte X;
		[FieldOffset(1)]
		public byte Y;
		[FieldOffset(2)]
		public byte Z;
		[FieldOffset(3)]
		private byte W;
		public byte3(byte x, byte y, byte z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static byte3 Add(byte3 left, byte3 right)
		{
			return new byte3(
			(byte)(left.X + right.X),
			(byte)(left.Y + right.Y),
			(byte)(left.Z + right.Z));
		}
		
		public static byte3 operator +(byte3 left, byte3 right)
		{
			return byte3.Add(left, right);
		}
		
		public static byte3 Subtract(byte3 left, byte3 right)
		{
			return new byte3(
			(byte)(left.X - right.X),
			(byte)(left.Y - right.Y),
			(byte)(left.Z - right.Z));
		}
		
		public static byte3 operator -(byte3 left, byte3 right)
		{
			return byte3.Subtract(left, right);
		}
		
		public static byte3 Multiply(byte3 left, byte3 right)
		{
			return new byte3(
			(byte)(left.X * right.X),
			(byte)(left.Y * right.Y),
			(byte)(left.Z * right.Z));
		}
		
		public static byte3 operator *(byte3 left, byte3 right)
		{
			return byte3.Multiply(left, right);
		}
		
		public static byte3 Divide(byte3 left, byte3 right)
		{
			return new byte3(
			(byte)(left.X / right.X),
			(byte)(left.Y / right.Y),
			(byte)(left.Z / right.Z));
		}
		
		public static byte3 operator /(byte3 left, byte3 right)
		{
			return byte3.Divide(left, right);
		}
		
		public static implicit operator byte3(byte value)
		{
			return new byte3(value, value, value);
		}
		public static explicit operator byte3(byte4 value)
		{
			byte3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator byte4(byte3 value)
		{
			byte4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(byte v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is byte3))
			return false;
			return this.Equals((byte3)obj);
		}
		public bool Equals(byte3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(byte3 left, byte3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(byte3 left, byte3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct byte4 : IEquatable<byte4>
	{
		public static byte4 Zero { get { return new byte4(0, 0, 0, 0); } }
		public static byte4 One { get { return new byte4(1, 1, 1, 1); } }
		public static byte4 UnitX { get { return new byte4(1, 0, 0, 0); } }
		public static byte4 UnitY { get { return new byte4(0, 1, 0, 0); } }
		public static byte4 UnitZ { get { return new byte4(0, 0, 1, 0); } }
		public static byte4 UnitW { get { return new byte4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public byte X;
		[FieldOffset(1)]
		public byte Y;
		[FieldOffset(2)]
		public byte Z;
		[FieldOffset(3)]
		public byte W;
		public byte4(byte x, byte y, byte z, byte w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static byte4 Add(byte4 left, byte4 right)
		{
			return new byte4(
			(byte)(left.X + right.X),
			(byte)(left.Y + right.Y),
			(byte)(left.Z + right.Z),
			(byte)(left.W + right.W));
		}
		
		public static byte4 operator +(byte4 left, byte4 right)
		{
			return byte4.Add(left, right);
		}
		
		public static byte4 Subtract(byte4 left, byte4 right)
		{
			return new byte4(
			(byte)(left.X - right.X),
			(byte)(left.Y - right.Y),
			(byte)(left.Z - right.Z),
			(byte)(left.W - right.W));
		}
		
		public static byte4 operator -(byte4 left, byte4 right)
		{
			return byte4.Subtract(left, right);
		}
		
		public static byte4 Multiply(byte4 left, byte4 right)
		{
			return new byte4(
			(byte)(left.X * right.X),
			(byte)(left.Y * right.Y),
			(byte)(left.Z * right.Z),
			(byte)(left.W * right.W));
		}
		
		public static byte4 operator *(byte4 left, byte4 right)
		{
			return byte4.Multiply(left, right);
		}
		
		public static byte4 Divide(byte4 left, byte4 right)
		{
			return new byte4(
			(byte)(left.X / right.X),
			(byte)(left.Y / right.Y),
			(byte)(left.Z / right.Z),
			(byte)(left.W / right.W));
		}
		
		public static byte4 operator /(byte4 left, byte4 right)
		{
			return byte4.Divide(left, right);
		}
		
		public static implicit operator byte4(byte value)
		{
			return new byte4(value, value, value, value);
		}
		private int GetInt(byte v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is byte4))
			return false;
			return this.Equals((byte4)obj);
		}
		public bool Equals(byte4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(byte4 left, byte4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(byte4 left, byte4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct sbyte2 : IEquatable<sbyte2>
	{
		public static sbyte2 Zero { get { return new sbyte2(0, 0); } }
		public static sbyte2 One { get { return new sbyte2(1, 1); } }
		public static sbyte2 UnitX { get { return new sbyte2(1, 0); } }
		public static sbyte2 UnitY { get { return new sbyte2(0, 1); } }
		
		[FieldOffset(0)]
		public sbyte X;
		[FieldOffset(1)]
		public sbyte Y;
		public sbyte2(sbyte x, sbyte y)
		{
			this.X = x;
			this.Y = y;
		}
		public static sbyte2 Add(sbyte2 left, sbyte2 right)
		{
			return new sbyte2(
			(sbyte)(left.X + right.X),
			(sbyte)(left.Y + right.Y));
		}
		
		public static sbyte2 operator +(sbyte2 left, sbyte2 right)
		{
			return sbyte2.Add(left, right);
		}
		
		public static sbyte2 Subtract(sbyte2 left, sbyte2 right)
		{
			return new sbyte2(
			(sbyte)(left.X - right.X),
			(sbyte)(left.Y - right.Y));
		}
		
		public static sbyte2 operator -(sbyte2 left, sbyte2 right)
		{
			return sbyte2.Subtract(left, right);
		}
		
		public static sbyte2 Multiply(sbyte2 left, sbyte2 right)
		{
			return new sbyte2(
			(sbyte)(left.X * right.X),
			(sbyte)(left.Y * right.Y));
		}
		
		public static sbyte2 operator *(sbyte2 left, sbyte2 right)
		{
			return sbyte2.Multiply(left, right);
		}
		
		public static sbyte2 Divide(sbyte2 left, sbyte2 right)
		{
			return new sbyte2(
			(sbyte)(left.X / right.X),
			(sbyte)(left.Y / right.Y));
		}
		
		public static sbyte2 operator /(sbyte2 left, sbyte2 right)
		{
			return sbyte2.Divide(left, right);
		}
		
		public static implicit operator sbyte2(sbyte value)
		{
			return new sbyte2(value, value);
		}
		private int GetInt(sbyte v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is sbyte2))
			return false;
			return this.Equals((sbyte2)obj);
		}
		public bool Equals(sbyte2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(sbyte2 left, sbyte2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(sbyte2 left, sbyte2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct sbyte3 : IEquatable<sbyte3>
	{
		public static sbyte3 Zero { get { return new sbyte3(0, 0, 0); } }
		public static sbyte3 One { get { return new sbyte3(1, 1, 1); } }
		public static sbyte3 UnitX { get { return new sbyte3(1, 0, 0); } }
		public static sbyte3 UnitY { get { return new sbyte3(0, 1, 0); } }
		public static sbyte3 UnitZ { get { return new sbyte3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public sbyte X;
		[FieldOffset(1)]
		public sbyte Y;
		[FieldOffset(2)]
		public sbyte Z;
		[FieldOffset(3)]
		private sbyte W;
		public sbyte3(sbyte x, sbyte y, sbyte z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static sbyte3 Add(sbyte3 left, sbyte3 right)
		{
			return new sbyte3(
			(sbyte)(left.X + right.X),
			(sbyte)(left.Y + right.Y),
			(sbyte)(left.Z + right.Z));
		}
		
		public static sbyte3 operator +(sbyte3 left, sbyte3 right)
		{
			return sbyte3.Add(left, right);
		}
		
		public static sbyte3 Subtract(sbyte3 left, sbyte3 right)
		{
			return new sbyte3(
			(sbyte)(left.X - right.X),
			(sbyte)(left.Y - right.Y),
			(sbyte)(left.Z - right.Z));
		}
		
		public static sbyte3 operator -(sbyte3 left, sbyte3 right)
		{
			return sbyte3.Subtract(left, right);
		}
		
		public static sbyte3 Multiply(sbyte3 left, sbyte3 right)
		{
			return new sbyte3(
			(sbyte)(left.X * right.X),
			(sbyte)(left.Y * right.Y),
			(sbyte)(left.Z * right.Z));
		}
		
		public static sbyte3 operator *(sbyte3 left, sbyte3 right)
		{
			return sbyte3.Multiply(left, right);
		}
		
		public static sbyte3 Divide(sbyte3 left, sbyte3 right)
		{
			return new sbyte3(
			(sbyte)(left.X / right.X),
			(sbyte)(left.Y / right.Y),
			(sbyte)(left.Z / right.Z));
		}
		
		public static sbyte3 operator /(sbyte3 left, sbyte3 right)
		{
			return sbyte3.Divide(left, right);
		}
		
		public static implicit operator sbyte3(sbyte value)
		{
			return new sbyte3(value, value, value);
		}
		public static explicit operator sbyte3(sbyte4 value)
		{
			sbyte3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator sbyte4(sbyte3 value)
		{
			sbyte4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(sbyte v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is sbyte3))
			return false;
			return this.Equals((sbyte3)obj);
		}
		public bool Equals(sbyte3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(sbyte3 left, sbyte3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(sbyte3 left, sbyte3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct sbyte4 : IEquatable<sbyte4>
	{
		public static sbyte4 Zero { get { return new sbyte4(0, 0, 0, 0); } }
		public static sbyte4 One { get { return new sbyte4(1, 1, 1, 1); } }
		public static sbyte4 UnitX { get { return new sbyte4(1, 0, 0, 0); } }
		public static sbyte4 UnitY { get { return new sbyte4(0, 1, 0, 0); } }
		public static sbyte4 UnitZ { get { return new sbyte4(0, 0, 1, 0); } }
		public static sbyte4 UnitW { get { return new sbyte4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public sbyte X;
		[FieldOffset(1)]
		public sbyte Y;
		[FieldOffset(2)]
		public sbyte Z;
		[FieldOffset(3)]
		public sbyte W;
		public sbyte4(sbyte x, sbyte y, sbyte z, sbyte w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static sbyte4 Add(sbyte4 left, sbyte4 right)
		{
			return new sbyte4(
			(sbyte)(left.X + right.X),
			(sbyte)(left.Y + right.Y),
			(sbyte)(left.Z + right.Z),
			(sbyte)(left.W + right.W));
		}
		
		public static sbyte4 operator +(sbyte4 left, sbyte4 right)
		{
			return sbyte4.Add(left, right);
		}
		
		public static sbyte4 Subtract(sbyte4 left, sbyte4 right)
		{
			return new sbyte4(
			(sbyte)(left.X - right.X),
			(sbyte)(left.Y - right.Y),
			(sbyte)(left.Z - right.Z),
			(sbyte)(left.W - right.W));
		}
		
		public static sbyte4 operator -(sbyte4 left, sbyte4 right)
		{
			return sbyte4.Subtract(left, right);
		}
		
		public static sbyte4 Multiply(sbyte4 left, sbyte4 right)
		{
			return new sbyte4(
			(sbyte)(left.X * right.X),
			(sbyte)(left.Y * right.Y),
			(sbyte)(left.Z * right.Z),
			(sbyte)(left.W * right.W));
		}
		
		public static sbyte4 operator *(sbyte4 left, sbyte4 right)
		{
			return sbyte4.Multiply(left, right);
		}
		
		public static sbyte4 Divide(sbyte4 left, sbyte4 right)
		{
			return new sbyte4(
			(sbyte)(left.X / right.X),
			(sbyte)(left.Y / right.Y),
			(sbyte)(left.Z / right.Z),
			(sbyte)(left.W / right.W));
		}
		
		public static sbyte4 operator /(sbyte4 left, sbyte4 right)
		{
			return sbyte4.Divide(left, right);
		}
		
		public static implicit operator sbyte4(sbyte value)
		{
			return new sbyte4(value, value, value, value);
		}
		private int GetInt(sbyte v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is sbyte4))
			return false;
			return this.Equals((sbyte4)obj);
		}
		public bool Equals(sbyte4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(sbyte4 left, sbyte4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(sbyte4 left, sbyte4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct short2 : IEquatable<short2>
	{
		public static short2 Zero { get { return new short2(0, 0); } }
		public static short2 One { get { return new short2(1, 1); } }
		public static short2 UnitX { get { return new short2(1, 0); } }
		public static short2 UnitY { get { return new short2(0, 1); } }
		
		[FieldOffset(0)]
		public short X;
		[FieldOffset(2)]
		public short Y;
		public short2(short x, short y)
		{
			this.X = x;
			this.Y = y;
		}
		public static short2 Add(short2 left, short2 right)
		{
			return new short2(
			(short)(left.X + right.X),
			(short)(left.Y + right.Y));
		}
		
		public static short2 operator +(short2 left, short2 right)
		{
			return short2.Add(left, right);
		}
		
		public static short2 Subtract(short2 left, short2 right)
		{
			return new short2(
			(short)(left.X - right.X),
			(short)(left.Y - right.Y));
		}
		
		public static short2 operator -(short2 left, short2 right)
		{
			return short2.Subtract(left, right);
		}
		
		public static short2 Multiply(short2 left, short2 right)
		{
			return new short2(
			(short)(left.X * right.X),
			(short)(left.Y * right.Y));
		}
		
		public static short2 operator *(short2 left, short2 right)
		{
			return short2.Multiply(left, right);
		}
		
		public static short2 Divide(short2 left, short2 right)
		{
			return new short2(
			(short)(left.X / right.X),
			(short)(left.Y / right.Y));
		}
		
		public static short2 operator /(short2 left, short2 right)
		{
			return short2.Divide(left, right);
		}
		
		public static implicit operator short2(short value)
		{
			return new short2(value, value);
		}
		private int GetInt(short v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is short2))
			return false;
			return this.Equals((short2)obj);
		}
		public bool Equals(short2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(short2 left, short2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(short2 left, short2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct short3 : IEquatable<short3>
	{
		public static short3 Zero { get { return new short3(0, 0, 0); } }
		public static short3 One { get { return new short3(1, 1, 1); } }
		public static short3 UnitX { get { return new short3(1, 0, 0); } }
		public static short3 UnitY { get { return new short3(0, 1, 0); } }
		public static short3 UnitZ { get { return new short3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public short X;
		[FieldOffset(2)]
		public short Y;
		[FieldOffset(4)]
		public short Z;
		[FieldOffset(6)]
		private short W;
		public short3(short x, short y, short z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static short3 Add(short3 left, short3 right)
		{
			return new short3(
			(short)(left.X + right.X),
			(short)(left.Y + right.Y),
			(short)(left.Z + right.Z));
		}
		
		public static short3 operator +(short3 left, short3 right)
		{
			return short3.Add(left, right);
		}
		
		public static short3 Subtract(short3 left, short3 right)
		{
			return new short3(
			(short)(left.X - right.X),
			(short)(left.Y - right.Y),
			(short)(left.Z - right.Z));
		}
		
		public static short3 operator -(short3 left, short3 right)
		{
			return short3.Subtract(left, right);
		}
		
		public static short3 Multiply(short3 left, short3 right)
		{
			return new short3(
			(short)(left.X * right.X),
			(short)(left.Y * right.Y),
			(short)(left.Z * right.Z));
		}
		
		public static short3 operator *(short3 left, short3 right)
		{
			return short3.Multiply(left, right);
		}
		
		public static short3 Divide(short3 left, short3 right)
		{
			return new short3(
			(short)(left.X / right.X),
			(short)(left.Y / right.Y),
			(short)(left.Z / right.Z));
		}
		
		public static short3 operator /(short3 left, short3 right)
		{
			return short3.Divide(left, right);
		}
		
		public static implicit operator short3(short value)
		{
			return new short3(value, value, value);
		}
		public static explicit operator short3(short4 value)
		{
			short3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator short4(short3 value)
		{
			short4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(short v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is short3))
			return false;
			return this.Equals((short3)obj);
		}
		public bool Equals(short3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(short3 left, short3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(short3 left, short3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct short4 : IEquatable<short4>
	{
		public static short4 Zero { get { return new short4(0, 0, 0, 0); } }
		public static short4 One { get { return new short4(1, 1, 1, 1); } }
		public static short4 UnitX { get { return new short4(1, 0, 0, 0); } }
		public static short4 UnitY { get { return new short4(0, 1, 0, 0); } }
		public static short4 UnitZ { get { return new short4(0, 0, 1, 0); } }
		public static short4 UnitW { get { return new short4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public short X;
		[FieldOffset(2)]
		public short Y;
		[FieldOffset(4)]
		public short Z;
		[FieldOffset(6)]
		public short W;
		public short4(short x, short y, short z, short w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static short4 Add(short4 left, short4 right)
		{
			return new short4(
			(short)(left.X + right.X),
			(short)(left.Y + right.Y),
			(short)(left.Z + right.Z),
			(short)(left.W + right.W));
		}
		
		public static short4 operator +(short4 left, short4 right)
		{
			return short4.Add(left, right);
		}
		
		public static short4 Subtract(short4 left, short4 right)
		{
			return new short4(
			(short)(left.X - right.X),
			(short)(left.Y - right.Y),
			(short)(left.Z - right.Z),
			(short)(left.W - right.W));
		}
		
		public static short4 operator -(short4 left, short4 right)
		{
			return short4.Subtract(left, right);
		}
		
		public static short4 Multiply(short4 left, short4 right)
		{
			return new short4(
			(short)(left.X * right.X),
			(short)(left.Y * right.Y),
			(short)(left.Z * right.Z),
			(short)(left.W * right.W));
		}
		
		public static short4 operator *(short4 left, short4 right)
		{
			return short4.Multiply(left, right);
		}
		
		public static short4 Divide(short4 left, short4 right)
		{
			return new short4(
			(short)(left.X / right.X),
			(short)(left.Y / right.Y),
			(short)(left.Z / right.Z),
			(short)(left.W / right.W));
		}
		
		public static short4 operator /(short4 left, short4 right)
		{
			return short4.Divide(left, right);
		}
		
		public static implicit operator short4(short value)
		{
			return new short4(value, value, value, value);
		}
		private int GetInt(short v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is short4))
			return false;
			return this.Equals((short4)obj);
		}
		public bool Equals(short4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(short4 left, short4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(short4 left, short4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct ushort2 : IEquatable<ushort2>
	{
		public static ushort2 Zero { get { return new ushort2(0, 0); } }
		public static ushort2 One { get { return new ushort2(1, 1); } }
		public static ushort2 UnitX { get { return new ushort2(1, 0); } }
		public static ushort2 UnitY { get { return new ushort2(0, 1); } }
		
		[FieldOffset(0)]
		public ushort X;
		[FieldOffset(2)]
		public ushort Y;
		public ushort2(ushort x, ushort y)
		{
			this.X = x;
			this.Y = y;
		}
		public static ushort2 Add(ushort2 left, ushort2 right)
		{
			return new ushort2(
			(ushort)(left.X + right.X),
			(ushort)(left.Y + right.Y));
		}
		
		public static ushort2 operator +(ushort2 left, ushort2 right)
		{
			return ushort2.Add(left, right);
		}
		
		public static ushort2 Subtract(ushort2 left, ushort2 right)
		{
			return new ushort2(
			(ushort)(left.X - right.X),
			(ushort)(left.Y - right.Y));
		}
		
		public static ushort2 operator -(ushort2 left, ushort2 right)
		{
			return ushort2.Subtract(left, right);
		}
		
		public static ushort2 Multiply(ushort2 left, ushort2 right)
		{
			return new ushort2(
			(ushort)(left.X * right.X),
			(ushort)(left.Y * right.Y));
		}
		
		public static ushort2 operator *(ushort2 left, ushort2 right)
		{
			return ushort2.Multiply(left, right);
		}
		
		public static ushort2 Divide(ushort2 left, ushort2 right)
		{
			return new ushort2(
			(ushort)(left.X / right.X),
			(ushort)(left.Y / right.Y));
		}
		
		public static ushort2 operator /(ushort2 left, ushort2 right)
		{
			return ushort2.Divide(left, right);
		}
		
		public static implicit operator ushort2(ushort value)
		{
			return new ushort2(value, value);
		}
		private int GetInt(ushort v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is ushort2))
			return false;
			return this.Equals((ushort2)obj);
		}
		public bool Equals(ushort2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(ushort2 left, ushort2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(ushort2 left, ushort2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct ushort3 : IEquatable<ushort3>
	{
		public static ushort3 Zero { get { return new ushort3(0, 0, 0); } }
		public static ushort3 One { get { return new ushort3(1, 1, 1); } }
		public static ushort3 UnitX { get { return new ushort3(1, 0, 0); } }
		public static ushort3 UnitY { get { return new ushort3(0, 1, 0); } }
		public static ushort3 UnitZ { get { return new ushort3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public ushort X;
		[FieldOffset(2)]
		public ushort Y;
		[FieldOffset(4)]
		public ushort Z;
		[FieldOffset(6)]
		private ushort W;
		public ushort3(ushort x, ushort y, ushort z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static ushort3 Add(ushort3 left, ushort3 right)
		{
			return new ushort3(
			(ushort)(left.X + right.X),
			(ushort)(left.Y + right.Y),
			(ushort)(left.Z + right.Z));
		}
		
		public static ushort3 operator +(ushort3 left, ushort3 right)
		{
			return ushort3.Add(left, right);
		}
		
		public static ushort3 Subtract(ushort3 left, ushort3 right)
		{
			return new ushort3(
			(ushort)(left.X - right.X),
			(ushort)(left.Y - right.Y),
			(ushort)(left.Z - right.Z));
		}
		
		public static ushort3 operator -(ushort3 left, ushort3 right)
		{
			return ushort3.Subtract(left, right);
		}
		
		public static ushort3 Multiply(ushort3 left, ushort3 right)
		{
			return new ushort3(
			(ushort)(left.X * right.X),
			(ushort)(left.Y * right.Y),
			(ushort)(left.Z * right.Z));
		}
		
		public static ushort3 operator *(ushort3 left, ushort3 right)
		{
			return ushort3.Multiply(left, right);
		}
		
		public static ushort3 Divide(ushort3 left, ushort3 right)
		{
			return new ushort3(
			(ushort)(left.X / right.X),
			(ushort)(left.Y / right.Y),
			(ushort)(left.Z / right.Z));
		}
		
		public static ushort3 operator /(ushort3 left, ushort3 right)
		{
			return ushort3.Divide(left, right);
		}
		
		public static implicit operator ushort3(ushort value)
		{
			return new ushort3(value, value, value);
		}
		public static explicit operator ushort3(ushort4 value)
		{
			ushort3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator ushort4(ushort3 value)
		{
			ushort4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(ushort v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is ushort3))
			return false;
			return this.Equals((ushort3)obj);
		}
		public bool Equals(ushort3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(ushort3 left, ushort3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(ushort3 left, ushort3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct ushort4 : IEquatable<ushort4>
	{
		public static ushort4 Zero { get { return new ushort4(0, 0, 0, 0); } }
		public static ushort4 One { get { return new ushort4(1, 1, 1, 1); } }
		public static ushort4 UnitX { get { return new ushort4(1, 0, 0, 0); } }
		public static ushort4 UnitY { get { return new ushort4(0, 1, 0, 0); } }
		public static ushort4 UnitZ { get { return new ushort4(0, 0, 1, 0); } }
		public static ushort4 UnitW { get { return new ushort4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public ushort X;
		[FieldOffset(2)]
		public ushort Y;
		[FieldOffset(4)]
		public ushort Z;
		[FieldOffset(6)]
		public ushort W;
		public ushort4(ushort x, ushort y, ushort z, ushort w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static ushort4 Add(ushort4 left, ushort4 right)
		{
			return new ushort4(
			(ushort)(left.X + right.X),
			(ushort)(left.Y + right.Y),
			(ushort)(left.Z + right.Z),
			(ushort)(left.W + right.W));
		}
		
		public static ushort4 operator +(ushort4 left, ushort4 right)
		{
			return ushort4.Add(left, right);
		}
		
		public static ushort4 Subtract(ushort4 left, ushort4 right)
		{
			return new ushort4(
			(ushort)(left.X - right.X),
			(ushort)(left.Y - right.Y),
			(ushort)(left.Z - right.Z),
			(ushort)(left.W - right.W));
		}
		
		public static ushort4 operator -(ushort4 left, ushort4 right)
		{
			return ushort4.Subtract(left, right);
		}
		
		public static ushort4 Multiply(ushort4 left, ushort4 right)
		{
			return new ushort4(
			(ushort)(left.X * right.X),
			(ushort)(left.Y * right.Y),
			(ushort)(left.Z * right.Z),
			(ushort)(left.W * right.W));
		}
		
		public static ushort4 operator *(ushort4 left, ushort4 right)
		{
			return ushort4.Multiply(left, right);
		}
		
		public static ushort4 Divide(ushort4 left, ushort4 right)
		{
			return new ushort4(
			(ushort)(left.X / right.X),
			(ushort)(left.Y / right.Y),
			(ushort)(left.Z / right.Z),
			(ushort)(left.W / right.W));
		}
		
		public static ushort4 operator /(ushort4 left, ushort4 right)
		{
			return ushort4.Divide(left, right);
		}
		
		public static implicit operator ushort4(ushort value)
		{
			return new ushort4(value, value, value, value);
		}
		private int GetInt(ushort v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is ushort4))
			return false;
			return this.Equals((ushort4)obj);
		}
		public bool Equals(ushort4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(ushort4 left, ushort4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(ushort4 left, ushort4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct int2 : IEquatable<int2>
	{
		public static int2 Zero { get { return new int2(0, 0); } }
		public static int2 One { get { return new int2(1, 1); } }
		public static int2 UnitX { get { return new int2(1, 0); } }
		public static int2 UnitY { get { return new int2(0, 1); } }
		
		[FieldOffset(0)]
		public int X;
		[FieldOffset(4)]
		public int Y;
		public int2(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
		public static int2 Add(int2 left, int2 right)
		{
			return new int2(
			(int)(left.X + right.X),
			(int)(left.Y + right.Y));
		}
		
		public static int2 operator +(int2 left, int2 right)
		{
			return int2.Add(left, right);
		}
		
		public static int2 Subtract(int2 left, int2 right)
		{
			return new int2(
			(int)(left.X - right.X),
			(int)(left.Y - right.Y));
		}
		
		public static int2 operator -(int2 left, int2 right)
		{
			return int2.Subtract(left, right);
		}
		
		public static int2 Multiply(int2 left, int2 right)
		{
			return new int2(
			(int)(left.X * right.X),
			(int)(left.Y * right.Y));
		}
		
		public static int2 operator *(int2 left, int2 right)
		{
			return int2.Multiply(left, right);
		}
		
		public static int2 Divide(int2 left, int2 right)
		{
			return new int2(
			(int)(left.X / right.X),
			(int)(left.Y / right.Y));
		}
		
		public static int2 operator /(int2 left, int2 right)
		{
			return int2.Divide(left, right);
		}
		
		public static implicit operator int2(int value)
		{
			return new int2(value, value);
		}
		private int GetInt(int v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is int2))
			return false;
			return this.Equals((int2)obj);
		}
		public bool Equals(int2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(int2 left, int2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(int2 left, int2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct int3 : IEquatable<int3>
	{
		public static int3 Zero { get { return new int3(0, 0, 0); } }
		public static int3 One { get { return new int3(1, 1, 1); } }
		public static int3 UnitX { get { return new int3(1, 0, 0); } }
		public static int3 UnitY { get { return new int3(0, 1, 0); } }
		public static int3 UnitZ { get { return new int3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public int X;
		[FieldOffset(4)]
		public int Y;
		[FieldOffset(8)]
		public int Z;
		[FieldOffset(12)]
		private int W;
		public int3(int x, int y, int z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static int3 Add(int3 left, int3 right)
		{
			return new int3(
			(int)(left.X + right.X),
			(int)(left.Y + right.Y),
			(int)(left.Z + right.Z));
		}
		
		public static int3 operator +(int3 left, int3 right)
		{
			return int3.Add(left, right);
		}
		
		public static int3 Subtract(int3 left, int3 right)
		{
			return new int3(
			(int)(left.X - right.X),
			(int)(left.Y - right.Y),
			(int)(left.Z - right.Z));
		}
		
		public static int3 operator -(int3 left, int3 right)
		{
			return int3.Subtract(left, right);
		}
		
		public static int3 Multiply(int3 left, int3 right)
		{
			return new int3(
			(int)(left.X * right.X),
			(int)(left.Y * right.Y),
			(int)(left.Z * right.Z));
		}
		
		public static int3 operator *(int3 left, int3 right)
		{
			return int3.Multiply(left, right);
		}
		
		public static int3 Divide(int3 left, int3 right)
		{
			return new int3(
			(int)(left.X / right.X),
			(int)(left.Y / right.Y),
			(int)(left.Z / right.Z));
		}
		
		public static int3 operator /(int3 left, int3 right)
		{
			return int3.Divide(left, right);
		}
		
		public static implicit operator int3(int value)
		{
			return new int3(value, value, value);
		}
		public static explicit operator int3(int4 value)
		{
			int3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator int4(int3 value)
		{
			int4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(int v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is int3))
			return false;
			return this.Equals((int3)obj);
		}
		public bool Equals(int3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(int3 left, int3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(int3 left, int3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct int4 : IEquatable<int4>
	{
		public static int4 Zero { get { return new int4(0, 0, 0, 0); } }
		public static int4 One { get { return new int4(1, 1, 1, 1); } }
		public static int4 UnitX { get { return new int4(1, 0, 0, 0); } }
		public static int4 UnitY { get { return new int4(0, 1, 0, 0); } }
		public static int4 UnitZ { get { return new int4(0, 0, 1, 0); } }
		public static int4 UnitW { get { return new int4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public int X;
		[FieldOffset(4)]
		public int Y;
		[FieldOffset(8)]
		public int Z;
		[FieldOffset(12)]
		public int W;
		public int4(int x, int y, int z, int w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static int4 Add(int4 left, int4 right)
		{
			return new int4(
			(int)(left.X + right.X),
			(int)(left.Y + right.Y),
			(int)(left.Z + right.Z),
			(int)(left.W + right.W));
		}
		
		public static int4 operator +(int4 left, int4 right)
		{
			return int4.Add(left, right);
		}
		
		public static int4 Subtract(int4 left, int4 right)
		{
			return new int4(
			(int)(left.X - right.X),
			(int)(left.Y - right.Y),
			(int)(left.Z - right.Z),
			(int)(left.W - right.W));
		}
		
		public static int4 operator -(int4 left, int4 right)
		{
			return int4.Subtract(left, right);
		}
		
		public static int4 Multiply(int4 left, int4 right)
		{
			return new int4(
			(int)(left.X * right.X),
			(int)(left.Y * right.Y),
			(int)(left.Z * right.Z),
			(int)(left.W * right.W));
		}
		
		public static int4 operator *(int4 left, int4 right)
		{
			return int4.Multiply(left, right);
		}
		
		public static int4 Divide(int4 left, int4 right)
		{
			return new int4(
			(int)(left.X / right.X),
			(int)(left.Y / right.Y),
			(int)(left.Z / right.Z),
			(int)(left.W / right.W));
		}
		
		public static int4 operator /(int4 left, int4 right)
		{
			return int4.Divide(left, right);
		}
		
		public static implicit operator int4(int value)
		{
			return new int4(value, value, value, value);
		}
		private int GetInt(int v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is int4))
			return false;
			return this.Equals((int4)obj);
		}
		public bool Equals(int4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(int4 left, int4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(int4 left, int4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct uint2 : IEquatable<uint2>
	{
		public static uint2 Zero { get { return new uint2(0, 0); } }
		public static uint2 One { get { return new uint2(1, 1); } }
		public static uint2 UnitX { get { return new uint2(1, 0); } }
		public static uint2 UnitY { get { return new uint2(0, 1); } }
		
		[FieldOffset(0)]
		public uint X;
		[FieldOffset(4)]
		public uint Y;
		public uint2(uint x, uint y)
		{
			this.X = x;
			this.Y = y;
		}
		public static uint2 Add(uint2 left, uint2 right)
		{
			return new uint2(
			(uint)(left.X + right.X),
			(uint)(left.Y + right.Y));
		}
		
		public static uint2 operator +(uint2 left, uint2 right)
		{
			return uint2.Add(left, right);
		}
		
		public static uint2 Subtract(uint2 left, uint2 right)
		{
			return new uint2(
			(uint)(left.X - right.X),
			(uint)(left.Y - right.Y));
		}
		
		public static uint2 operator -(uint2 left, uint2 right)
		{
			return uint2.Subtract(left, right);
		}
		
		public static uint2 Multiply(uint2 left, uint2 right)
		{
			return new uint2(
			(uint)(left.X * right.X),
			(uint)(left.Y * right.Y));
		}
		
		public static uint2 operator *(uint2 left, uint2 right)
		{
			return uint2.Multiply(left, right);
		}
		
		public static uint2 Divide(uint2 left, uint2 right)
		{
			return new uint2(
			(uint)(left.X / right.X),
			(uint)(left.Y / right.Y));
		}
		
		public static uint2 operator /(uint2 left, uint2 right)
		{
			return uint2.Divide(left, right);
		}
		
		public static implicit operator uint2(uint value)
		{
			return new uint2(value, value);
		}
		private int GetInt(uint v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is uint2))
			return false;
			return this.Equals((uint2)obj);
		}
		public bool Equals(uint2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(uint2 left, uint2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(uint2 left, uint2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct uint3 : IEquatable<uint3>
	{
		public static uint3 Zero { get { return new uint3(0, 0, 0); } }
		public static uint3 One { get { return new uint3(1, 1, 1); } }
		public static uint3 UnitX { get { return new uint3(1, 0, 0); } }
		public static uint3 UnitY { get { return new uint3(0, 1, 0); } }
		public static uint3 UnitZ { get { return new uint3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public uint X;
		[FieldOffset(4)]
		public uint Y;
		[FieldOffset(8)]
		public uint Z;
		[FieldOffset(12)]
		private uint W;
		public uint3(uint x, uint y, uint z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static uint3 Add(uint3 left, uint3 right)
		{
			return new uint3(
			(uint)(left.X + right.X),
			(uint)(left.Y + right.Y),
			(uint)(left.Z + right.Z));
		}
		
		public static uint3 operator +(uint3 left, uint3 right)
		{
			return uint3.Add(left, right);
		}
		
		public static uint3 Subtract(uint3 left, uint3 right)
		{
			return new uint3(
			(uint)(left.X - right.X),
			(uint)(left.Y - right.Y),
			(uint)(left.Z - right.Z));
		}
		
		public static uint3 operator -(uint3 left, uint3 right)
		{
			return uint3.Subtract(left, right);
		}
		
		public static uint3 Multiply(uint3 left, uint3 right)
		{
			return new uint3(
			(uint)(left.X * right.X),
			(uint)(left.Y * right.Y),
			(uint)(left.Z * right.Z));
		}
		
		public static uint3 operator *(uint3 left, uint3 right)
		{
			return uint3.Multiply(left, right);
		}
		
		public static uint3 Divide(uint3 left, uint3 right)
		{
			return new uint3(
			(uint)(left.X / right.X),
			(uint)(left.Y / right.Y),
			(uint)(left.Z / right.Z));
		}
		
		public static uint3 operator /(uint3 left, uint3 right)
		{
			return uint3.Divide(left, right);
		}
		
		public static implicit operator uint3(uint value)
		{
			return new uint3(value, value, value);
		}
		public static explicit operator uint3(uint4 value)
		{
			uint3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator uint4(uint3 value)
		{
			uint4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(uint v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is uint3))
			return false;
			return this.Equals((uint3)obj);
		}
		public bool Equals(uint3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(uint3 left, uint3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(uint3 left, uint3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct uint4 : IEquatable<uint4>
	{
		public static uint4 Zero { get { return new uint4(0, 0, 0, 0); } }
		public static uint4 One { get { return new uint4(1, 1, 1, 1); } }
		public static uint4 UnitX { get { return new uint4(1, 0, 0, 0); } }
		public static uint4 UnitY { get { return new uint4(0, 1, 0, 0); } }
		public static uint4 UnitZ { get { return new uint4(0, 0, 1, 0); } }
		public static uint4 UnitW { get { return new uint4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public uint X;
		[FieldOffset(4)]
		public uint Y;
		[FieldOffset(8)]
		public uint Z;
		[FieldOffset(12)]
		public uint W;
		public uint4(uint x, uint y, uint z, uint w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static uint4 Add(uint4 left, uint4 right)
		{
			return new uint4(
			(uint)(left.X + right.X),
			(uint)(left.Y + right.Y),
			(uint)(left.Z + right.Z),
			(uint)(left.W + right.W));
		}
		
		public static uint4 operator +(uint4 left, uint4 right)
		{
			return uint4.Add(left, right);
		}
		
		public static uint4 Subtract(uint4 left, uint4 right)
		{
			return new uint4(
			(uint)(left.X - right.X),
			(uint)(left.Y - right.Y),
			(uint)(left.Z - right.Z),
			(uint)(left.W - right.W));
		}
		
		public static uint4 operator -(uint4 left, uint4 right)
		{
			return uint4.Subtract(left, right);
		}
		
		public static uint4 Multiply(uint4 left, uint4 right)
		{
			return new uint4(
			(uint)(left.X * right.X),
			(uint)(left.Y * right.Y),
			(uint)(left.Z * right.Z),
			(uint)(left.W * right.W));
		}
		
		public static uint4 operator *(uint4 left, uint4 right)
		{
			return uint4.Multiply(left, right);
		}
		
		public static uint4 Divide(uint4 left, uint4 right)
		{
			return new uint4(
			(uint)(left.X / right.X),
			(uint)(left.Y / right.Y),
			(uint)(left.Z / right.Z),
			(uint)(left.W / right.W));
		}
		
		public static uint4 operator /(uint4 left, uint4 right)
		{
			return uint4.Divide(left, right);
		}
		
		public static implicit operator uint4(uint value)
		{
			return new uint4(value, value, value, value);
		}
		private int GetInt(uint v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is uint4))
			return false;
			return this.Equals((uint4)obj);
		}
		public bool Equals(uint4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(uint4 left, uint4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(uint4 left, uint4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct long2 : IEquatable<long2>
	{
		public static long2 Zero { get { return new long2(0, 0); } }
		public static long2 One { get { return new long2(1, 1); } }
		public static long2 UnitX { get { return new long2(1, 0); } }
		public static long2 UnitY { get { return new long2(0, 1); } }
		
		[FieldOffset(0)]
		public long X;
		[FieldOffset(8)]
		public long Y;
		public long2(long x, long y)
		{
			this.X = x;
			this.Y = y;
		}
		public static long2 Add(long2 left, long2 right)
		{
			return new long2(
			(long)(left.X + right.X),
			(long)(left.Y + right.Y));
		}
		
		public static long2 operator +(long2 left, long2 right)
		{
			return long2.Add(left, right);
		}
		
		public static long2 Subtract(long2 left, long2 right)
		{
			return new long2(
			(long)(left.X - right.X),
			(long)(left.Y - right.Y));
		}
		
		public static long2 operator -(long2 left, long2 right)
		{
			return long2.Subtract(left, right);
		}
		
		public static long2 Multiply(long2 left, long2 right)
		{
			return new long2(
			(long)(left.X * right.X),
			(long)(left.Y * right.Y));
		}
		
		public static long2 operator *(long2 left, long2 right)
		{
			return long2.Multiply(left, right);
		}
		
		public static long2 Divide(long2 left, long2 right)
		{
			return new long2(
			(long)(left.X / right.X),
			(long)(left.Y / right.Y));
		}
		
		public static long2 operator /(long2 left, long2 right)
		{
			return long2.Divide(left, right);
		}
		
		public static implicit operator long2(long value)
		{
			return new long2(value, value);
		}
		private int GetInt(long v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is long2))
			return false;
			return this.Equals((long2)obj);
		}
		public bool Equals(long2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(long2 left, long2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(long2 left, long2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct long3 : IEquatable<long3>
	{
		public static long3 Zero { get { return new long3(0, 0, 0); } }
		public static long3 One { get { return new long3(1, 1, 1); } }
		public static long3 UnitX { get { return new long3(1, 0, 0); } }
		public static long3 UnitY { get { return new long3(0, 1, 0); } }
		public static long3 UnitZ { get { return new long3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public long X;
		[FieldOffset(8)]
		public long Y;
		[FieldOffset(16)]
		public long Z;
		[FieldOffset(24)]
		private long W;
		public long3(long x, long y, long z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static long3 Add(long3 left, long3 right)
		{
			return new long3(
			(long)(left.X + right.X),
			(long)(left.Y + right.Y),
			(long)(left.Z + right.Z));
		}
		
		public static long3 operator +(long3 left, long3 right)
		{
			return long3.Add(left, right);
		}
		
		public static long3 Subtract(long3 left, long3 right)
		{
			return new long3(
			(long)(left.X - right.X),
			(long)(left.Y - right.Y),
			(long)(left.Z - right.Z));
		}
		
		public static long3 operator -(long3 left, long3 right)
		{
			return long3.Subtract(left, right);
		}
		
		public static long3 Multiply(long3 left, long3 right)
		{
			return new long3(
			(long)(left.X * right.X),
			(long)(left.Y * right.Y),
			(long)(left.Z * right.Z));
		}
		
		public static long3 operator *(long3 left, long3 right)
		{
			return long3.Multiply(left, right);
		}
		
		public static long3 Divide(long3 left, long3 right)
		{
			return new long3(
			(long)(left.X / right.X),
			(long)(left.Y / right.Y),
			(long)(left.Z / right.Z));
		}
		
		public static long3 operator /(long3 left, long3 right)
		{
			return long3.Divide(left, right);
		}
		
		public static implicit operator long3(long value)
		{
			return new long3(value, value, value);
		}
		public static explicit operator long3(long4 value)
		{
			long3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator long4(long3 value)
		{
			long4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(long v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is long3))
			return false;
			return this.Equals((long3)obj);
		}
		public bool Equals(long3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(long3 left, long3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(long3 left, long3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct long4 : IEquatable<long4>
	{
		public static long4 Zero { get { return new long4(0, 0, 0, 0); } }
		public static long4 One { get { return new long4(1, 1, 1, 1); } }
		public static long4 UnitX { get { return new long4(1, 0, 0, 0); } }
		public static long4 UnitY { get { return new long4(0, 1, 0, 0); } }
		public static long4 UnitZ { get { return new long4(0, 0, 1, 0); } }
		public static long4 UnitW { get { return new long4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public long X;
		[FieldOffset(8)]
		public long Y;
		[FieldOffset(16)]
		public long Z;
		[FieldOffset(24)]
		public long W;
		public long4(long x, long y, long z, long w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static long4 Add(long4 left, long4 right)
		{
			return new long4(
			(long)(left.X + right.X),
			(long)(left.Y + right.Y),
			(long)(left.Z + right.Z),
			(long)(left.W + right.W));
		}
		
		public static long4 operator +(long4 left, long4 right)
		{
			return long4.Add(left, right);
		}
		
		public static long4 Subtract(long4 left, long4 right)
		{
			return new long4(
			(long)(left.X - right.X),
			(long)(left.Y - right.Y),
			(long)(left.Z - right.Z),
			(long)(left.W - right.W));
		}
		
		public static long4 operator -(long4 left, long4 right)
		{
			return long4.Subtract(left, right);
		}
		
		public static long4 Multiply(long4 left, long4 right)
		{
			return new long4(
			(long)(left.X * right.X),
			(long)(left.Y * right.Y),
			(long)(left.Z * right.Z),
			(long)(left.W * right.W));
		}
		
		public static long4 operator *(long4 left, long4 right)
		{
			return long4.Multiply(left, right);
		}
		
		public static long4 Divide(long4 left, long4 right)
		{
			return new long4(
			(long)(left.X / right.X),
			(long)(left.Y / right.Y),
			(long)(left.Z / right.Z),
			(long)(left.W / right.W));
		}
		
		public static long4 operator /(long4 left, long4 right)
		{
			return long4.Divide(left, right);
		}
		
		public static implicit operator long4(long value)
		{
			return new long4(value, value, value, value);
		}
		private int GetInt(long v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is long4))
			return false;
			return this.Equals((long4)obj);
		}
		public bool Equals(long4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(long4 left, long4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(long4 left, long4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct ulong2 : IEquatable<ulong2>
	{
		public static ulong2 Zero { get { return new ulong2(0, 0); } }
		public static ulong2 One { get { return new ulong2(1, 1); } }
		public static ulong2 UnitX { get { return new ulong2(1, 0); } }
		public static ulong2 UnitY { get { return new ulong2(0, 1); } }
		
		[FieldOffset(0)]
		public ulong X;
		[FieldOffset(8)]
		public ulong Y;
		public ulong2(ulong x, ulong y)
		{
			this.X = x;
			this.Y = y;
		}
		public static ulong2 Add(ulong2 left, ulong2 right)
		{
			return new ulong2(
			(ulong)(left.X + right.X),
			(ulong)(left.Y + right.Y));
		}
		
		public static ulong2 operator +(ulong2 left, ulong2 right)
		{
			return ulong2.Add(left, right);
		}
		
		public static ulong2 Subtract(ulong2 left, ulong2 right)
		{
			return new ulong2(
			(ulong)(left.X - right.X),
			(ulong)(left.Y - right.Y));
		}
		
		public static ulong2 operator -(ulong2 left, ulong2 right)
		{
			return ulong2.Subtract(left, right);
		}
		
		public static ulong2 Multiply(ulong2 left, ulong2 right)
		{
			return new ulong2(
			(ulong)(left.X * right.X),
			(ulong)(left.Y * right.Y));
		}
		
		public static ulong2 operator *(ulong2 left, ulong2 right)
		{
			return ulong2.Multiply(left, right);
		}
		
		public static ulong2 Divide(ulong2 left, ulong2 right)
		{
			return new ulong2(
			(ulong)(left.X / right.X),
			(ulong)(left.Y / right.Y));
		}
		
		public static ulong2 operator /(ulong2 left, ulong2 right)
		{
			return ulong2.Divide(left, right);
		}
		
		public static implicit operator ulong2(ulong value)
		{
			return new ulong2(value, value);
		}
		private int GetInt(ulong v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is ulong2))
			return false;
			return this.Equals((ulong2)obj);
		}
		public bool Equals(ulong2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(ulong2 left, ulong2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(ulong2 left, ulong2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct ulong3 : IEquatable<ulong3>
	{
		public static ulong3 Zero { get { return new ulong3(0, 0, 0); } }
		public static ulong3 One { get { return new ulong3(1, 1, 1); } }
		public static ulong3 UnitX { get { return new ulong3(1, 0, 0); } }
		public static ulong3 UnitY { get { return new ulong3(0, 1, 0); } }
		public static ulong3 UnitZ { get { return new ulong3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public ulong X;
		[FieldOffset(8)]
		public ulong Y;
		[FieldOffset(16)]
		public ulong Z;
		[FieldOffset(24)]
		private ulong W;
		public ulong3(ulong x, ulong y, ulong z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static ulong3 Add(ulong3 left, ulong3 right)
		{
			return new ulong3(
			(ulong)(left.X + right.X),
			(ulong)(left.Y + right.Y),
			(ulong)(left.Z + right.Z));
		}
		
		public static ulong3 operator +(ulong3 left, ulong3 right)
		{
			return ulong3.Add(left, right);
		}
		
		public static ulong3 Subtract(ulong3 left, ulong3 right)
		{
			return new ulong3(
			(ulong)(left.X - right.X),
			(ulong)(left.Y - right.Y),
			(ulong)(left.Z - right.Z));
		}
		
		public static ulong3 operator -(ulong3 left, ulong3 right)
		{
			return ulong3.Subtract(left, right);
		}
		
		public static ulong3 Multiply(ulong3 left, ulong3 right)
		{
			return new ulong3(
			(ulong)(left.X * right.X),
			(ulong)(left.Y * right.Y),
			(ulong)(left.Z * right.Z));
		}
		
		public static ulong3 operator *(ulong3 left, ulong3 right)
		{
			return ulong3.Multiply(left, right);
		}
		
		public static ulong3 Divide(ulong3 left, ulong3 right)
		{
			return new ulong3(
			(ulong)(left.X / right.X),
			(ulong)(left.Y / right.Y),
			(ulong)(left.Z / right.Z));
		}
		
		public static ulong3 operator /(ulong3 left, ulong3 right)
		{
			return ulong3.Divide(left, right);
		}
		
		public static implicit operator ulong3(ulong value)
		{
			return new ulong3(value, value, value);
		}
		public static explicit operator ulong3(ulong4 value)
		{
			ulong3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator ulong4(ulong3 value)
		{
			ulong4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(ulong v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is ulong3))
			return false;
			return this.Equals((ulong3)obj);
		}
		public bool Equals(ulong3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(ulong3 left, ulong3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(ulong3 left, ulong3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct ulong4 : IEquatable<ulong4>
	{
		public static ulong4 Zero { get { return new ulong4(0, 0, 0, 0); } }
		public static ulong4 One { get { return new ulong4(1, 1, 1, 1); } }
		public static ulong4 UnitX { get { return new ulong4(1, 0, 0, 0); } }
		public static ulong4 UnitY { get { return new ulong4(0, 1, 0, 0); } }
		public static ulong4 UnitZ { get { return new ulong4(0, 0, 1, 0); } }
		public static ulong4 UnitW { get { return new ulong4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public ulong X;
		[FieldOffset(8)]
		public ulong Y;
		[FieldOffset(16)]
		public ulong Z;
		[FieldOffset(24)]
		public ulong W;
		public ulong4(ulong x, ulong y, ulong z, ulong w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static ulong4 Add(ulong4 left, ulong4 right)
		{
			return new ulong4(
			(ulong)(left.X + right.X),
			(ulong)(left.Y + right.Y),
			(ulong)(left.Z + right.Z),
			(ulong)(left.W + right.W));
		}
		
		public static ulong4 operator +(ulong4 left, ulong4 right)
		{
			return ulong4.Add(left, right);
		}
		
		public static ulong4 Subtract(ulong4 left, ulong4 right)
		{
			return new ulong4(
			(ulong)(left.X - right.X),
			(ulong)(left.Y - right.Y),
			(ulong)(left.Z - right.Z),
			(ulong)(left.W - right.W));
		}
		
		public static ulong4 operator -(ulong4 left, ulong4 right)
		{
			return ulong4.Subtract(left, right);
		}
		
		public static ulong4 Multiply(ulong4 left, ulong4 right)
		{
			return new ulong4(
			(ulong)(left.X * right.X),
			(ulong)(left.Y * right.Y),
			(ulong)(left.Z * right.Z),
			(ulong)(left.W * right.W));
		}
		
		public static ulong4 operator *(ulong4 left, ulong4 right)
		{
			return ulong4.Multiply(left, right);
		}
		
		public static ulong4 Divide(ulong4 left, ulong4 right)
		{
			return new ulong4(
			(ulong)(left.X / right.X),
			(ulong)(left.Y / right.Y),
			(ulong)(left.Z / right.Z),
			(ulong)(left.W / right.W));
		}
		
		public static ulong4 operator /(ulong4 left, ulong4 right)
		{
			return ulong4.Divide(left, right);
		}
		
		public static implicit operator ulong4(ulong value)
		{
			return new ulong4(value, value, value, value);
		}
		private int GetInt(ulong v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is ulong4))
			return false;
			return this.Equals((ulong4)obj);
		}
		public bool Equals(ulong4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(ulong4 left, ulong4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(ulong4 left, ulong4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct float2 : IEquatable<float2>
	{
		public static float2 Zero { get { return new float2(0, 0); } }
		public static float2 One { get { return new float2(1, 1); } }
		public static float2 UnitX { get { return new float2(1, 0); } }
		public static float2 UnitY { get { return new float2(0, 1); } }
		
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		public float2(float x, float y)
		{
			this.X = x;
			this.Y = y;
		}
		public static float2 Add(float2 left, float2 right)
		{
			return new float2(
			(float)(left.X + right.X),
			(float)(left.Y + right.Y));
		}
		
		public static float2 operator +(float2 left, float2 right)
		{
			return float2.Add(left, right);
		}
		
		public static float2 Subtract(float2 left, float2 right)
		{
			return new float2(
			(float)(left.X - right.X),
			(float)(left.Y - right.Y));
		}
		
		public static float2 operator -(float2 left, float2 right)
		{
			return float2.Subtract(left, right);
		}
		
		public static float2 Multiply(float2 left, float2 right)
		{
			return new float2(
			(float)(left.X * right.X),
			(float)(left.Y * right.Y));
		}
		
		public static float2 operator *(float2 left, float2 right)
		{
			return float2.Multiply(left, right);
		}
		
		public static float2 Divide(float2 left, float2 right)
		{
			return new float2(
			(float)(left.X / right.X),
			(float)(left.Y / right.Y));
		}
		
		public static float2 operator /(float2 left, float2 right)
		{
			return float2.Divide(left, right);
		}
		
		public static implicit operator float2(float value)
		{
			return new float2(value, value);
		}
		private int GetInt(float v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is float2))
			return false;
			return this.Equals((float2)obj);
		}
		public bool Equals(float2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(float2 left, float2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(float2 left, float2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
		public float Length { get { return (float)Math.Sqrt(X*X+Y*Y); } }
		public void Normalize()
		{
			float l = this.Length;
			if(l == 0) return;
			this.X = this.X / l;
			this.Y = this.Y / l;
		}
		public float2 Normalized()
		{
			float2 val = this;
			val.Normalize();
			return val;
		}
		public static float Distance(float2 a, float2  b)
		{
			return (a - b).Length;
		}
		public static float Dot(float2 a, float2  b)
		{
			return (a.X * b.X) + (a.Y * b.Y);
		}
		public static float2 Lerp(float2 a, float2 b, float factor)
		{
			float2 result = new float2();
			result.X = a.X + factor * (b.X - a.X);
			result.Y = a.Y + factor * (b.Y - a.Y);
			return result;
		}
		public static float2 Max(float2 a, float2 b)
		{
			float2 result = new float2();
			result.X = (a.X > b.X) ? a.X : b.X;
			result.Y = (a.Y > b.Y) ? a.Y : b.Y;
			return result;
		}
		public static float2 Min(float2 a, float2 b)
		{
			float2 result = new float2();
			result.X = (a.X < b.X) ? a.X : b.X;
			result.Y = (a.Y < b.Y) ? a.Y : b.Y;
			return result;
		}
		public static float2 Clamp(float2 value, float2 min, float2 max)
		{
			return float2.Max(min, float2.Min(max, value));
		}
		public void Negate()
		{
			this.X = -this.X;
			this.Y = -this.Y;
		}
		public float2 Negated()
		{
			float2 result = this;
			result.Negate();
			return result;
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct float3 : IEquatable<float3>
	{
		public static float3 Zero { get { return new float3(0, 0, 0); } }
		public static float3 One { get { return new float3(1, 1, 1); } }
		public static float3 UnitX { get { return new float3(1, 0, 0); } }
		public static float3 UnitY { get { return new float3(0, 1, 0); } }
		public static float3 UnitZ { get { return new float3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		[FieldOffset(8)]
		public float Z;
		[FieldOffset(12)]
		private float W;
		public float3(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static float3 Add(float3 left, float3 right)
		{
			return new float3(
			(float)(left.X + right.X),
			(float)(left.Y + right.Y),
			(float)(left.Z + right.Z));
		}
		
		public static float3 operator +(float3 left, float3 right)
		{
			return float3.Add(left, right);
		}
		
		public static float3 Subtract(float3 left, float3 right)
		{
			return new float3(
			(float)(left.X - right.X),
			(float)(left.Y - right.Y),
			(float)(left.Z - right.Z));
		}
		
		public static float3 operator -(float3 left, float3 right)
		{
			return float3.Subtract(left, right);
		}
		
		public static float3 Multiply(float3 left, float3 right)
		{
			return new float3(
			(float)(left.X * right.X),
			(float)(left.Y * right.Y),
			(float)(left.Z * right.Z));
		}
		
		public static float3 operator *(float3 left, float3 right)
		{
			return float3.Multiply(left, right);
		}
		
		public static float3 Divide(float3 left, float3 right)
		{
			return new float3(
			(float)(left.X / right.X),
			(float)(left.Y / right.Y),
			(float)(left.Z / right.Z));
		}
		
		public static float3 operator /(float3 left, float3 right)
		{
			return float3.Divide(left, right);
		}
		
		public static implicit operator float3(float value)
		{
			return new float3(value, value, value);
		}
		public static explicit operator float3(float4 value)
		{
			float3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator float4(float3 value)
		{
			float4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(float v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is float3))
			return false;
			return this.Equals((float3)obj);
		}
		public bool Equals(float3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(float3 left, float3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(float3 left, float3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
		public float Length { get { return (float)Math.Sqrt(X*X+Y*Y+Z*Z); } }
		public void Normalize()
		{
			float l = this.Length;
			if(l == 0) return;
			this.X = this.X / l;
			this.Y = this.Y / l;
			this.Z = this.Z / l;
		}
		public float3 Normalized()
		{
			float3 val = this;
			val.Normalize();
			return val;
		}
		public static float Distance(float3 a, float3  b)
		{
			return (a - b).Length;
		}
		public static float Dot(float3 a, float3  b)
		{
			return (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
		}
		public static float3 Lerp(float3 a, float3 b, float factor)
		{
			float3 result = new float3();
			result.X = a.X + factor * (b.X - a.X);
			result.Y = a.Y + factor * (b.Y - a.Y);
			result.Z = a.Z + factor * (b.Z - a.Z);
			return result;
		}
		public static float3 Max(float3 a, float3 b)
		{
			float3 result = new float3();
			result.X = (a.X > b.X) ? a.X : b.X;
			result.Y = (a.Y > b.Y) ? a.Y : b.Y;
			result.Z = (a.Z > b.Z) ? a.Z : b.Z;
			return result;
		}
		public static float3 Min(float3 a, float3 b)
		{
			float3 result = new float3();
			result.X = (a.X < b.X) ? a.X : b.X;
			result.Y = (a.Y < b.Y) ? a.Y : b.Y;
			result.Z = (a.Z < b.Z) ? a.Z : b.Z;
			return result;
		}
		public static float3 Clamp(float3 value, float3 min, float3 max)
		{
			return float3.Max(min, float3.Min(max, value));
		}
		public void Negate()
		{
			this.X = -this.X;
			this.Y = -this.Y;
			this.Z = -this.Z;
		}
		public float3 Negated()
		{
			float3 result = this;
			result.Negate();
			return result;
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct float4 : IEquatable<float4>
	{
		public static float4 Zero { get { return new float4(0, 0, 0, 0); } }
		public static float4 One { get { return new float4(1, 1, 1, 1); } }
		public static float4 UnitX { get { return new float4(1, 0, 0, 0); } }
		public static float4 UnitY { get { return new float4(0, 1, 0, 0); } }
		public static float4 UnitZ { get { return new float4(0, 0, 1, 0); } }
		public static float4 UnitW { get { return new float4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		[FieldOffset(8)]
		public float Z;
		[FieldOffset(12)]
		public float W;
		public float4(float x, float y, float z, float w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static float4 Add(float4 left, float4 right)
		{
			return new float4(
			(float)(left.X + right.X),
			(float)(left.Y + right.Y),
			(float)(left.Z + right.Z),
			(float)(left.W + right.W));
		}
		
		public static float4 operator +(float4 left, float4 right)
		{
			return float4.Add(left, right);
		}
		
		public static float4 Subtract(float4 left, float4 right)
		{
			return new float4(
			(float)(left.X - right.X),
			(float)(left.Y - right.Y),
			(float)(left.Z - right.Z),
			(float)(left.W - right.W));
		}
		
		public static float4 operator -(float4 left, float4 right)
		{
			return float4.Subtract(left, right);
		}
		
		public static float4 Multiply(float4 left, float4 right)
		{
			return new float4(
			(float)(left.X * right.X),
			(float)(left.Y * right.Y),
			(float)(left.Z * right.Z),
			(float)(left.W * right.W));
		}
		
		public static float4 operator *(float4 left, float4 right)
		{
			return float4.Multiply(left, right);
		}
		
		public static float4 Divide(float4 left, float4 right)
		{
			return new float4(
			(float)(left.X / right.X),
			(float)(left.Y / right.Y),
			(float)(left.Z / right.Z),
			(float)(left.W / right.W));
		}
		
		public static float4 operator /(float4 left, float4 right)
		{
			return float4.Divide(left, right);
		}
		
		public static implicit operator float4(float value)
		{
			return new float4(value, value, value, value);
		}
		private int GetInt(float v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is float4))
			return false;
			return this.Equals((float4)obj);
		}
		public bool Equals(float4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(float4 left, float4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(float4 left, float4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
		public float Length { get { return (float)Math.Sqrt(X*X+Y*Y+Z*Z+W*W); } }
		public void Normalize()
		{
			float l = this.Length;
			if(l == 0) return;
			this.X = this.X / l;
			this.Y = this.Y / l;
			this.Z = this.Z / l;
			this.W = this.W / l;
		}
		public float4 Normalized()
		{
			float4 val = this;
			val.Normalize();
			return val;
		}
		public static float Distance(float4 a, float4  b)
		{
			return (a - b).Length;
		}
		public static float Dot(float4 a, float4  b)
		{
			return (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z) + (a.W * b.W);
		}
		public static float4 Lerp(float4 a, float4 b, float factor)
		{
			float4 result = new float4();
			result.X = a.X + factor * (b.X - a.X);
			result.Y = a.Y + factor * (b.Y - a.Y);
			result.Z = a.Z + factor * (b.Z - a.Z);
			result.W = a.W + factor * (b.W - a.W);
			return result;
		}
		public static float4 Max(float4 a, float4 b)
		{
			float4 result = new float4();
			result.X = (a.X > b.X) ? a.X : b.X;
			result.Y = (a.Y > b.Y) ? a.Y : b.Y;
			result.Z = (a.Z > b.Z) ? a.Z : b.Z;
			result.W = (a.W > b.W) ? a.W : b.W;
			return result;
		}
		public static float4 Min(float4 a, float4 b)
		{
			float4 result = new float4();
			result.X = (a.X < b.X) ? a.X : b.X;
			result.Y = (a.Y < b.Y) ? a.Y : b.Y;
			result.Z = (a.Z < b.Z) ? a.Z : b.Z;
			result.W = (a.W < b.W) ? a.W : b.W;
			return result;
		}
		public static float4 Clamp(float4 value, float4 min, float4 max)
		{
			return float4.Max(min, float4.Min(max, value));
		}
		public void Negate()
		{
			this.X = -this.X;
			this.Y = -this.Y;
			this.Z = -this.Z;
			this.W = -this.W;
		}
		public float4 Negated()
		{
			float4 result = this;
			result.Negate();
			return result;
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct double2 : IEquatable<double2>
	{
		public static double2 Zero { get { return new double2(0, 0); } }
		public static double2 One { get { return new double2(1, 1); } }
		public static double2 UnitX { get { return new double2(1, 0); } }
		public static double2 UnitY { get { return new double2(0, 1); } }
		
		[FieldOffset(0)]
		public double X;
		[FieldOffset(8)]
		public double Y;
		public double2(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}
		public static double2 Add(double2 left, double2 right)
		{
			return new double2(
			(double)(left.X + right.X),
			(double)(left.Y + right.Y));
		}
		
		public static double2 operator +(double2 left, double2 right)
		{
			return double2.Add(left, right);
		}
		
		public static double2 Subtract(double2 left, double2 right)
		{
			return new double2(
			(double)(left.X - right.X),
			(double)(left.Y - right.Y));
		}
		
		public static double2 operator -(double2 left, double2 right)
		{
			return double2.Subtract(left, right);
		}
		
		public static double2 Multiply(double2 left, double2 right)
		{
			return new double2(
			(double)(left.X * right.X),
			(double)(left.Y * right.Y));
		}
		
		public static double2 operator *(double2 left, double2 right)
		{
			return double2.Multiply(left, right);
		}
		
		public static double2 Divide(double2 left, double2 right)
		{
			return new double2(
			(double)(left.X / right.X),
			(double)(left.Y / right.Y));
		}
		
		public static double2 operator /(double2 left, double2 right)
		{
			return double2.Divide(left, right);
		}
		
		public static implicit operator double2(double value)
		{
			return new double2(value, value);
		}
		private int GetInt(double v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is double2))
			return false;
			return this.Equals((double2)obj);
		}
		public bool Equals(double2 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			return true;
		}
		public static bool operator ==(double2 left, double2 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(double2 left, double2 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ")";
		}
		
		public double Length { get { return (double)Math.Sqrt(X*X+Y*Y); } }
		public void Normalize()
		{
			double l = this.Length;
			if(l == 0) return;
			this.X = this.X / l;
			this.Y = this.Y / l;
		}
		public double2 Normalized()
		{
			double2 val = this;
			val.Normalize();
			return val;
		}
		public static double Distance(double2 a, double2  b)
		{
			return (a - b).Length;
		}
		public static double Dot(double2 a, double2  b)
		{
			return (a.X * b.X) + (a.Y * b.Y);
		}
		public static double2 Lerp(double2 a, double2 b, double factor)
		{
			double2 result = new double2();
			result.X = a.X + factor * (b.X - a.X);
			result.Y = a.Y + factor * (b.Y - a.Y);
			return result;
		}
		public static double2 Max(double2 a, double2 b)
		{
			double2 result = new double2();
			result.X = (a.X > b.X) ? a.X : b.X;
			result.Y = (a.Y > b.Y) ? a.Y : b.Y;
			return result;
		}
		public static double2 Min(double2 a, double2 b)
		{
			double2 result = new double2();
			result.X = (a.X < b.X) ? a.X : b.X;
			result.Y = (a.Y < b.Y) ? a.Y : b.Y;
			return result;
		}
		public static double2 Clamp(double2 value, double2 min, double2 max)
		{
			return double2.Max(min, double2.Min(max, value));
		}
		public void Negate()
		{
			this.X = -this.X;
			this.Y = -this.Y;
		}
		public double2 Negated()
		{
			double2 result = this;
			result.Negate();
			return result;
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct double3 : IEquatable<double3>
	{
		public static double3 Zero { get { return new double3(0, 0, 0); } }
		public static double3 One { get { return new double3(1, 1, 1); } }
		public static double3 UnitX { get { return new double3(1, 0, 0); } }
		public static double3 UnitY { get { return new double3(0, 1, 0); } }
		public static double3 UnitZ { get { return new double3(0, 0, 1); } }
		
		[FieldOffset(0)]
		public double X;
		[FieldOffset(8)]
		public double Y;
		[FieldOffset(16)]
		public double Z;
		[FieldOffset(24)]
		private double W;
		public double3(double x, double y, double z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = 0;
		}
		public static double3 Add(double3 left, double3 right)
		{
			return new double3(
			(double)(left.X + right.X),
			(double)(left.Y + right.Y),
			(double)(left.Z + right.Z));
		}
		
		public static double3 operator +(double3 left, double3 right)
		{
			return double3.Add(left, right);
		}
		
		public static double3 Subtract(double3 left, double3 right)
		{
			return new double3(
			(double)(left.X - right.X),
			(double)(left.Y - right.Y),
			(double)(left.Z - right.Z));
		}
		
		public static double3 operator -(double3 left, double3 right)
		{
			return double3.Subtract(left, right);
		}
		
		public static double3 Multiply(double3 left, double3 right)
		{
			return new double3(
			(double)(left.X * right.X),
			(double)(left.Y * right.Y),
			(double)(left.Z * right.Z));
		}
		
		public static double3 operator *(double3 left, double3 right)
		{
			return double3.Multiply(left, right);
		}
		
		public static double3 Divide(double3 left, double3 right)
		{
			return new double3(
			(double)(left.X / right.X),
			(double)(left.Y / right.Y),
			(double)(left.Z / right.Z));
		}
		
		public static double3 operator /(double3 left, double3 right)
		{
			return double3.Divide(left, right);
		}
		
		public static implicit operator double3(double value)
		{
			return new double3(value, value, value);
		}
		public static explicit operator double3(double4 value)
		{
			double3 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		public static explicit operator double4(double3 value)
		{
			double4 result;
			result.X = value.X;
			result.Y = value.Y;
			result.Z = value.Z;
			result.W = value.W;
			return result;
		}
		private int GetInt(double v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is double3))
			return false;
			return this.Equals((double3)obj);
		}
		public bool Equals(double3 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			return true;
		}
		public static bool operator ==(double3 left, double3 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(double3 left, double3 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ")";
		}
		
		public double Length { get { return (double)Math.Sqrt(X*X+Y*Y+Z*Z); } }
		public void Normalize()
		{
			double l = this.Length;
			if(l == 0) return;
			this.X = this.X / l;
			this.Y = this.Y / l;
			this.Z = this.Z / l;
		}
		public double3 Normalized()
		{
			double3 val = this;
			val.Normalize();
			return val;
		}
		public static double Distance(double3 a, double3  b)
		{
			return (a - b).Length;
		}
		public static double Dot(double3 a, double3  b)
		{
			return (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
		}
		public static double3 Lerp(double3 a, double3 b, double factor)
		{
			double3 result = new double3();
			result.X = a.X + factor * (b.X - a.X);
			result.Y = a.Y + factor * (b.Y - a.Y);
			result.Z = a.Z + factor * (b.Z - a.Z);
			return result;
		}
		public static double3 Max(double3 a, double3 b)
		{
			double3 result = new double3();
			result.X = (a.X > b.X) ? a.X : b.X;
			result.Y = (a.Y > b.Y) ? a.Y : b.Y;
			result.Z = (a.Z > b.Z) ? a.Z : b.Z;
			return result;
		}
		public static double3 Min(double3 a, double3 b)
		{
			double3 result = new double3();
			result.X = (a.X < b.X) ? a.X : b.X;
			result.Y = (a.Y < b.Y) ? a.Y : b.Y;
			result.Z = (a.Z < b.Z) ? a.Z : b.Z;
			return result;
		}
		public static double3 Clamp(double3 value, double3 min, double3 max)
		{
			return double3.Max(min, double3.Min(max, value));
		}
		public void Negate()
		{
			this.X = -this.X;
			this.Y = -this.Y;
			this.Z = -this.Z;
		}
		public double3 Negated()
		{
			double3 result = this;
			result.Negate();
			return result;
		}
		
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct double4 : IEquatable<double4>
	{
		public static double4 Zero { get { return new double4(0, 0, 0, 0); } }
		public static double4 One { get { return new double4(1, 1, 1, 1); } }
		public static double4 UnitX { get { return new double4(1, 0, 0, 0); } }
		public static double4 UnitY { get { return new double4(0, 1, 0, 0); } }
		public static double4 UnitZ { get { return new double4(0, 0, 1, 0); } }
		public static double4 UnitW { get { return new double4(0, 0, 0, 1); } }
		
		[FieldOffset(0)]
		public double X;
		[FieldOffset(8)]
		public double Y;
		[FieldOffset(16)]
		public double Z;
		[FieldOffset(24)]
		public double W;
		public double4(double x, double y, double z, double w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}
		public static double4 Add(double4 left, double4 right)
		{
			return new double4(
			(double)(left.X + right.X),
			(double)(left.Y + right.Y),
			(double)(left.Z + right.Z),
			(double)(left.W + right.W));
		}
		
		public static double4 operator +(double4 left, double4 right)
		{
			return double4.Add(left, right);
		}
		
		public static double4 Subtract(double4 left, double4 right)
		{
			return new double4(
			(double)(left.X - right.X),
			(double)(left.Y - right.Y),
			(double)(left.Z - right.Z),
			(double)(left.W - right.W));
		}
		
		public static double4 operator -(double4 left, double4 right)
		{
			return double4.Subtract(left, right);
		}
		
		public static double4 Multiply(double4 left, double4 right)
		{
			return new double4(
			(double)(left.X * right.X),
			(double)(left.Y * right.Y),
			(double)(left.Z * right.Z),
			(double)(left.W * right.W));
		}
		
		public static double4 operator *(double4 left, double4 right)
		{
			return double4.Multiply(left, right);
		}
		
		public static double4 Divide(double4 left, double4 right)
		{
			return new double4(
			(double)(left.X / right.X),
			(double)(left.Y / right.Y),
			(double)(left.Z / right.Z),
			(double)(left.W / right.W));
		}
		
		public static double4 operator /(double4 left, double4 right)
		{
			return double4.Divide(left, right);
		}
		
		public static implicit operator double4(double value)
		{
			return new double4(value, value, value, value);
		}
		private int GetInt(double v) { byte[] bits = BitConverter.GetBytes(v); Array.Resize(ref bits, 4); return BitConverter.ToInt32(bits, 0); }
		public override int GetHashCode()
		{
			return GetInt(this.X) ^ GetInt(Y) ^ GetInt(Z) ^ GetInt(W);
		}
		public override bool Equals(object obj)
		{
			if (!(obj is double4))
			return false;
			return this.Equals((double4)obj);
		}
		public bool Equals(double4 other)
		{
			if (this.X != other.X) return false;
			if (this.Y != other.Y) return false;
			if (this.Z != other.Z) return false;
			if (this.W != other.W) return false;
			return true;
		}
		public static bool operator ==(double4 left, double4 right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(double4 left, double4 right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return "(" + this.X.ToString() + ", " + this.Y.ToString() + ", " + this.Z.ToString() + ", " + this.W.ToString() + ")";
		}
		
		public double Length { get { return (double)Math.Sqrt(X*X+Y*Y+Z*Z+W*W); } }
		public void Normalize()
		{
			double l = this.Length;
			if(l == 0) return;
			this.X = this.X / l;
			this.Y = this.Y / l;
			this.Z = this.Z / l;
			this.W = this.W / l;
		}
		public double4 Normalized()
		{
			double4 val = this;
			val.Normalize();
			return val;
		}
		public static double Distance(double4 a, double4  b)
		{
			return (a - b).Length;
		}
		public static double Dot(double4 a, double4  b)
		{
			return (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z) + (a.W * b.W);
		}
		public static double4 Lerp(double4 a, double4 b, double factor)
		{
			double4 result = new double4();
			result.X = a.X + factor * (b.X - a.X);
			result.Y = a.Y + factor * (b.Y - a.Y);
			result.Z = a.Z + factor * (b.Z - a.Z);
			result.W = a.W + factor * (b.W - a.W);
			return result;
		}
		public static double4 Max(double4 a, double4 b)
		{
			double4 result = new double4();
			result.X = (a.X > b.X) ? a.X : b.X;
			result.Y = (a.Y > b.Y) ? a.Y : b.Y;
			result.Z = (a.Z > b.Z) ? a.Z : b.Z;
			result.W = (a.W > b.W) ? a.W : b.W;
			return result;
		}
		public static double4 Min(double4 a, double4 b)
		{
			double4 result = new double4();
			result.X = (a.X < b.X) ? a.X : b.X;
			result.Y = (a.Y < b.Y) ? a.Y : b.Y;
			result.Z = (a.Z < b.Z) ? a.Z : b.Z;
			result.W = (a.W < b.W) ? a.W : b.W;
			return result;
		}
		public static double4 Clamp(double4 value, double4 min, double4 max)
		{
			return double4.Max(min, double4.Min(max, value));
		}
		public void Negate()
		{
			this.X = -this.X;
			this.Y = -this.Y;
			this.Z = -this.Z;
			this.W = -this.W;
		}
		public double4 Negated()
		{
			double4 result = this;
			result.Negate();
			return result;
		}
		
	}
}
