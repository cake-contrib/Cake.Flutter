using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter logs.
	/// Show log output for running Flutter apps..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterLogsSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help     Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// -c, --clear    Clear log history before reading from logs.
		/// </summary>
		public bool? Clear { get; set; }
	}
}