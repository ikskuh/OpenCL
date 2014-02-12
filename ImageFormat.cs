using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ImageFormat
	{
		[FieldOffset(0)]
		public ChannelOrder ChannelOrder;

		[FieldOffset(4)]
		public ChannelType ChannelType;
	}

	public enum ChannelOrder : uint
	{
		/* channel_order */
		R = 0x10B0,
		A = 0x10B1,
		RG = 0x10B2,
		RA = 0x10B3,
		/// <summary>
		/// This format can only be used if channel data type = UNormShort565, UNormShort555, or UNormInt101010.
		/// </summary>
		RGB = 0x10B4,
		RGBA = 0x10B5,
		/// <summary>
		/// This format can only be used if channel data type = UNormInt8, SNormInt8, SignedInt8 or UnsignedInt8.
		/// </summary>
		BGRA = 0x10B6,
		/// <summary>
		/// This format can only be used if channel data type = UNormInt8, SNormInt8, SignedInt8 or UnsignedInt8.
		/// </summary>
		ARGB = 0x10B7,
		/// <summary>
		/// This format can only be used if channel data type = UNormInt8, UNormInt16, SNormInt8, SNormInt16, HalfFloat or Float.
		/// </summary>
		Intensity = 0x10B8,
		/// <summary>
		/// This format can only be used if channel data type = UNormInt8, UNormInt16, SNormInt8, SNormInt16, HalfFloat or Float.
		/// </summary>
		Luminance = 0x10B9,
		Rx = 0x10BA,
		RGx = 0x10BB,
		/// <summary>
		/// This format can only be used if channel data type = UNormShort565, UNormShort555, or UNormInt101010.
		/// </summary>
		RGBx = 0x10BC,

	}

	public enum ChannelType : uint
	{
		/// <summary>
		/// Each channel component is a normalized signed 8-bit integer value
		/// </summary>
		SNormInt8 = 0x10D0,
		/// <summary>
		/// Each channel component is a normalized signed 16-bit integer value
		/// </summary>
		SNormInt16 = 0x10D1,
		/// <summary>
		/// Each channel component is a normalized unsigned 8-bit integer value
		/// </summary>
		UNormInt8 = 0x10D2,
		/// <summary>
		/// Each channel component is a normalized unsigned 16-bit integer value 
		/// </summary>
		UNormInt16 = 0x10D3,
		/// <summary>
		/// Represents a normalized 5-6-5 3-channel RGB image. The channel order must be CL_RGB or CL_RGBx.
		/// </summary>
		UNormShort565 = 0x10D4,
		/// <summary>
		/// Represents a normalized x-5-5-5 4-channel xRGB image. The channel order must be CL_RGB or CL_RGBx.
		/// </summary>
		UNormShort555 = 0x10D5,
		/// <summary>
		/// Represents a normalized x-10-10-10 4-channel xRGB image. The channel order must be CL_RGB or CL_RGBx.
		/// </summary>
		UNormInt101010 = 0x10D6,
		/// <summary>
		/// Each channel component is an unnormalized signed 8-bit integer value
		/// </summary>
		SignedInt8 = 0x10D7,
		/// <summary>
		/// Each channel component is an unnormalized signed 16-bit integer value
		/// </summary>
		SignedInt16 = 0x10D8,
		/// <summary>
		/// Each channel component is an unnormalized signed 32-bit integer value
		/// </summary>
		SignedInt32 = 0x10D9,
		/// <summary>
		/// Each channel component is an unnormalized unsigned 8-bit integer value
		/// </summary>
		UnsignedInt8 = 0x10DA,
		/// <summary>
		/// Each channel component is an unnormalized unsigned 16-bit integer value
		/// </summary>
		UnsignedInt16 = 0x10DB,
		/// <summary>
		/// Each channel component is an unnormalized unsigned 32-bit integer value
		/// </summary>
		UnsignedInt32 = 0x10DC,
		/// <summary>
		/// Each channel component is a 16-bit half-float value
		/// </summary>
		HalfFloat = 0x10DD,
		/// <summary>
		/// Each channel component is a single precision floating-point value
		/// </summary>
		Float = 0x10DE
	}
}
