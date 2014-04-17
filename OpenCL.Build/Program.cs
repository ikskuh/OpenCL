using System;
using System.Collections.Generic;
using System.Text;
using OpenCL;
using System.IO;

namespace OpenCL.Build
{
	public class Program
	{
		public static int Main()
		{
			var cmd = Environment.CommandLine;
			var args = Environment.GetCommandLineArgs();

			if (args.Length < 2)
			{
				Console.WriteLine("Missing input file!");
				return 1;
			}
			if (args.Length > 2)
			{
				cmd = cmd.Substring(args[0].Length + args[1].Length + 6);
			}
			else
			{
				cmd = "";
			}

			if(!File.Exists(args[1]))
			{
				Console.WriteLine("Could not find {0}.", args[1]);
			}

			var platforms = Platform.GetPlatforms();
			if(platforms.Length == 0)
			{
				Console.WriteLine("Could not find any OpenCL platform.");
				return 1;
			}
			Device device = default(Device);
			foreach (var platform in platforms)
			{
				foreach(var dev in platform.GetDevices(DeviceType.All))
				{
					device = dev;
					break;
				}
				if (device != default(Device))
					break;
			}
			if(device == default(Device))
			{
				Console.WriteLine("Could not find any OpenCL device for {0}", platforms[0].Name);
				return 1;
			}

			Console.WriteLine("Selected {0} for compilation.", device.Name);

			Context context = Context.Create(device);

			var program = context.CreateProgram(File.ReadAllText(args[1]));

			try
			{
				if(!string.IsNullOrWhiteSpace(cmd))
					Console.WriteLine("Build Options: {0}", cmd);
				program.Build(cmd, device);
				Console.WriteLine("Compilation successfull!");

				return 0;
			}
			catch(OpenCLException ex)
			{
				switch(ex.ErrorCode)
				{
					case CLError.BuildProgramFailure:
						Console.WriteLine(program.GetBuildLog(device));
						break;
					default:
						Console.WriteLine("Failed to compile: {0}", ex.ErrorCode);
						break;
				}
				

				return 2;
			}
			finally
			{
				program.Dispose();
				context.Dispose();
			}

		}
	}
}
