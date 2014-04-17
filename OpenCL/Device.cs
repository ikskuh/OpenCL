using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Device
	{
		[FieldOffset(0)]
		private int id;

		private string GetInformationString(DeviceInfo info)
		{
			int size = GetInformationLength(info);
			StringBuilder sb = new StringBuilder(size + 1);
			NativeMethods.ThrowError(NativeMethods.clGetDeviceInfo(this, info, sb.Capacity, sb, out size));
			return sb.ToString().Trim();
		}

		private uint GetInformationUInt32(DeviceInfo info)
		{
			uint value = 0;
			int size;
			NativeMethods.ThrowError(NativeMethods.clGetDeviceInfo(this, info, sizeof(uint), out value, out size));
			return value;
		}

		private int GetInformationInt32(DeviceInfo info)
		{
			int value = 0;
			int size;
			NativeMethods.ThrowError(NativeMethods.clGetDeviceInfo(this, info, sizeof(int), out value, out size));
			return value;
		}

		private ulong GetInformationUInt64(DeviceInfo info)
		{
			ulong value = 0;
			int size;
			NativeMethods.ThrowError(NativeMethods.clGetDeviceInfo(this, info, sizeof(ulong), out value, out size));
			return value;
		}

		private int GetInformationLength(DeviceInfo info)
		{
			int size;
			NativeMethods.ThrowError(NativeMethods.clGetDeviceInfo(this, info, 0, IntPtr.Zero, out size));
			return size;
		}

		public string Name
		{
			get { return this.GetInformationString(DeviceInfo.Name); }
		}

		public string Vendor
		{
			get { return this.GetInformationString(DeviceInfo.Vendor); }
		}

		public string Version
		{
			get { return this.GetInformationString(DeviceInfo.Version); }
		}

		public string Profile
		{
			get { return this.GetInformationString(DeviceInfo.Profile); }
		}

		public DeviceType Type
		{
			get { return (DeviceType)this.GetInformationUInt64(DeviceInfo.Type); }
		}

		public int MaxClockFrequency
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxClockFrequency); }
		}

		public int MaxComputeUnits
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxComputeUnits); }
		}

		public int MaxConstantArgs
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxConstantArgs); }
		}

		public int MaxConstantBufferSize
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxConstantBufferSize); }
		}

		public int MaxMemAllocSize
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxMemAllocSize); }
		}

		public int MaxParameterSize
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxParameterSize); }
		}

		public int MaxReadImageArgs
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxReadImageArgs); }
		}

		public int MaxSamplers
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxSamplers); }
		}

		public int MaxWorkGroupSize
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxWorkGroupSize); }
		}

		public int MaxWorkItemDimensions
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxWorkItemDimensions); }
		}

		public int MaxWorkItemSizes
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxWorkItemSizes); }
		}

		public int MaxWriteImageArgs
		{
			get { return this.GetInformationInt32(DeviceInfo.MaxWriteImageArgs); }
		}

		public Platform Platform
		{
			get
			{
				return new Platform(this.GetInformationInt32(DeviceInfo.Platform));
			}
		}

		public static bool operator ==(Device a, Device b)
		{
			return a.id == b.id;
		}

		public static bool operator !=(Device a, Device b)
		{
			return a.id != b.id;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (obj is Device)
				return this.id == ((Device)obj).id;
			else
				return false;
		}

		public override int GetHashCode()
		{
			return this.id.GetHashCode();
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public override string ToString()
		{
			return "[" + this.Type + "] " + this.Name;
		}
	}
}
