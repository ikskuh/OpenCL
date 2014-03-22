using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	internal static class Helpers
	{
		public static T First<T>(T[] array)
			where T : struct
		{
			return array[0];
		}

		public static T First<T>(T[,] array)
			where T : struct
		{
			return array[0, 0];
		}

		public static T First<T>(T[, ,] array)
			where T : struct
		{
			return array[0, 0, 0];
		}

		public static uint SizeOf<T>(T[] array)
			where T : struct
		{
			return (uint)(Marshal.SizeOf(array[0]) * array.Length);
		}

		public static uint SizeOf<T>(T[,] array)
			where T : struct
		{
			return (uint)(Marshal.SizeOf(array[0, 0]) * array.GetLength(0) * array.GetLength(1));
		}

		public static uint SizeOf<T>(T[, ,] array)
			where T : struct
		{
			return (uint)(Marshal.SizeOf(array[0, 0, 0]) * array.GetLength(0) * array.GetLength(1) * array.GetLength(2));
		}
	}
}
