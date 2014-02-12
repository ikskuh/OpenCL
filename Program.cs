using System;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using System.Text;

namespace OpenCL
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Program : IDisposable
	{
		[FieldOffset(0)]
		private int id;

		public void Build(string options, params Device[] devices)
		{
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clBuildProgram(this, (uint)devices.Length, devices, options, IntPtr.Zero, IntPtr.Zero));
		}

		public string GetBuildLog(Device device)
		{
			uint size;
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clGetProgramBuildInfo(this, device, ProgramBuildInfo.Log, 0, null, out size));
			StringBuilder sb = new StringBuilder((int)size + 1);
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clGetProgramBuildInfo(this, device, ProgramBuildInfo.Log, (uint)sb.Capacity, sb, out size));
			return sb.ToString();
		}

		public string GetBuildOptions(Device device)
		{
			uint size;
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clGetProgramBuildInfo(this, device, ProgramBuildInfo.Options, 0, null, out size));
			StringBuilder sb = new StringBuilder((int)size + 1);
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clGetProgramBuildInfo(this, device, ProgramBuildInfo.Options, (uint)sb.Capacity, sb, out size));
			return sb.ToString();
		}

		public BuildStatus GetBuildStatus(Device device)
		{
			uint size;
			BuildStatus status;
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clGetProgramBuildInfo(this, device, ProgramBuildInfo.Status, 4, out status, out size));
			return status;
		}

		public Kernel CreateKernel(string name)
		{
			int error;
			Kernel kernel = OpenCLNative.NativeMethods.clCreateKernel(this, name, out error);
			OpenCLNative.ThrowError(error);
			return kernel;
		}

		public Kernel[] CreateAllKernels()
		{
			uint num;
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clCreateKernelsInProgram(this, 0, null, out num));
			Kernel[] kernels = new Kernel[num];
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clCreateKernelsInProgram(this, num, kernels, out num));
			return kernels;
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public void Dispose()
		{
			OpenCLNative.ThrowError(OpenCLNative.NativeMethods.clReleaseProgram(this));
		}
	}
}
