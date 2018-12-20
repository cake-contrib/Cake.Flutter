using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter emulators.
	/// List, launch and create emulators..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterEmulatorsSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help      Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --launch    The full or partial ID of the emulator to launch.
		/// </summary>
		public bool? Launch { get; set; }
		/// <summary>
		/// --create    Creates a new Android emulator based on a Pixel device.
		/// </summary>
		public bool? Create { get; set; }
		/// <summary>
		/// --name      Used with flag --create. Specifies a name for the emulator being created.
		/// </summary>
		public string Name { get; set; }
	}
}