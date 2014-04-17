using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Platform
	{
		[FieldOffset(0)]
		private int id;

		public int ID
		{
			get { return id; }
		}

		internal Platform(int id)
		{
			this.id = id;
		}

		public Device[] GetDevices(DeviceType type)
		{
			uint num;
			NativeMethods.ThrowError(NativeMethods.clGetDeviceIDs(this, type, 0,  null, out num));

			Device[] devices = new Device[num];
			NativeMethods.ThrowError(NativeMethods.clGetDeviceIDs(this, type, num, devices, out num));

			return devices;
		}

		private string GetInformation(PlatformInfo info)
		{
			int size;
			NativeMethods.ThrowError(NativeMethods.clGetPlatformInfo(this, info, 0, null, out size));

			StringBuilder sb = new StringBuilder(size + 1);
			NativeMethods.ThrowError(NativeMethods.clGetPlatformInfo(this, info, sb.Capacity, sb, out size));

			return sb.ToString().Trim();
		}

		public string Name
		{
			get { return this.GetInformation(PlatformInfo.Name); }
		}

		public string Vendor
		{
			get { return this.GetInformation(PlatformInfo.Vendor); }
		}

		public string Version
		{
			get { return this.GetInformation(PlatformInfo.Version); }
		}

		public string[] Extensions
		{
			get { return this.GetInformation(PlatformInfo.Extensions).Split(' '); }
		}

		public string Profile
		{
			get { return this.GetInformation(PlatformInfo.Profile); }
		}

		public static bool operator ==(Platform a, Platform b)
		{
			return a.id == b.id;
		}

		public static bool operator !=(Platform a, Platform b)
		{
			return a.id != b.id;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (obj is Platform)
				return this.id == ((Platform)obj).id;
			else
				return false;
		}

		public override int GetHashCode()
		{
			return this.id.GetHashCode();
		}

		public override string ToString()
		{
			return this.Name;
		}

		public static Platform[] GetPlatforms()
		{
			uint num;
			NativeMethods.ThrowError(NativeMethods.clGetPlatformIDs(0, null, out num));

			Platform[] platforms = new Platform[num];
			NativeMethods.ThrowError(NativeMethods.clGetPlatformIDs(num, platforms, out num));

			return platforms;
		}
	}
}
