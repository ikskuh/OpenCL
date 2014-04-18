using System;
using System.Collections.Generic;
using System.Text;
using OpenCL;
using System.IO;
using System.Text.RegularExpressions;

namespace OpenCL.Build
{
	public class Program
	{
		public static int Main(string[] args)
		{
			string sourceFile = null;
			int platformID = 0;
			int deviceID = 0;
			string commandLine = "";

			if(args.Length == 0)
			{
				PrintHelp();
				return 0;
			}

			int i;
			int last = args.Length - 1;
			for (i = 0; i < args.Length; i++)
			{
				if(args[i].StartsWith("--"))
				{
					if (args[i].StartsWith("--device=") || args[i].StartsWith("--platform="))
					{
						string idText = args[i].Substring(args[i].IndexOf("=") + 1);
						int id;
						if (!int.TryParse(idText, out id))
						{
							Console.WriteLine("{0} is not a number.", idText);
							return 1;
						}
						if (args[i] == "--device")
							deviceID = id;
						else
							platformID = id;
					}
					else
					{
						switch (args[i])
						{
							case "--help":
								PrintHelp();
								return 0;
							case "--list":
								var listPlatforms = Platform.GetPlatforms();
								for (int j = 0; j < listPlatforms.Length; j++)
								{
									var listPlatform = listPlatforms[j];
									Console.WriteLine("Platform {0}", j);
									Console.WriteLine(" Name:     {0}", listPlatform.Name);
									Console.WriteLine(" Vendor:   {0}", listPlatform.Vendor);
									Console.WriteLine(" Version:  {0}", listPlatform.Version);
									var listDevices = listPlatform.GetDevices(DeviceType.All);
									for (int k = 0; k < listDevices.Length; k++)
									{
										var listDevice = listDevices[k];
										Console.WriteLine(" Device {0}", k);
										Console.WriteLine("  Name:            {0}", listDevice.Name);
										Console.WriteLine("  Profile:         {0}", listDevice.Profile);
										Console.WriteLine("  Type:            {0}", listDevice.Type);
										Console.WriteLine("  Version:         {0}", listDevice.Version);
										Console.WriteLine("  Compute Units:   {0}", listDevice.MaxComputeUnits);
										Console.WriteLine("  Clock Frequency: {0}", listDevice.MaxClockFrequency);
									}
								}
								return 0;
							default:
								Console.WriteLine("Unknown option: {0}", args[i]);
								break;
						}
					}
				}
				else
				{
					sourceFile = args[i];
					break;
				}
			}
			for (++i; i < args.Length; i++)
			{
				if (Regex.IsMatch(args[i], @"\s+"))
					commandLine += "\"" + args[i] + "\"";
				else
					commandLine += args[i];
				commandLine += " ";
			}

			var platforms = Platform.GetPlatforms();
			if (platformID < 0 || platformID >= platforms.Length)
			{
				Console.WriteLine("Platform {0} not found.", platformID);
				return 1;
			}
			var platform = platforms[platformID];
			var devices = platform.GetDevices(DeviceType.All);
			if (deviceID < 0 || deviceID >= devices.Length)
			{
				Console.WriteLine("Device {0} not found.", deviceID);
				return 1;
			}
			var device = devices[deviceID];

			Console.WriteLine("Selected {0} for compilation.", device.Name);

			Context context = Context.Create(device);

			var program = context.CreateProgram(File.ReadAllText(sourceFile));

			try
			{
				if(!string.IsNullOrWhiteSpace(commandLine))
					Console.WriteLine("Build Options: {0}", commandLine);
				program.Build(commandLine, device);
				Console.WriteLine("Compilation successful!");

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

		private static void PrintHelp()
		{
			string exe = Path.GetFileName(Environment.GetCommandLineArgs()[0]);
			Console.WriteLine("{0} Kernel Compiler", exe);
			Console.WriteLine("Usage:");
			Console.WriteLine(" {0} --help", exe);
			Console.WriteLine("  Show this help text.");
			Console.WriteLine();
			Console.WriteLine(" {0} --list", exe);
			Console.WriteLine("  List all platforms and devices.");
			Console.WriteLine();
			Console.WriteLine(" {0} --platform=id --device=id sourcefile CompilerOptions", exe);
			Console.WriteLine("  Compiles an OpenCL program.");
			Console.WriteLine("  --platform=id is optional and selects the platform with the id.");
			Console.WriteLine("  --device=id is optional and selects the device with the id.");
			Console.WriteLine("  CompilerOptions are passed straight to the OpenCL compiler.");
		}
	}
}
