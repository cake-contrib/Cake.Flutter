using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter trace.
	/// Start and stop tracing for a running Flutter app..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterTraceSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help          Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --debug-port    Local port where the observatory is listening. Required.
		/// </summary>
		public int? DebugPort { get; set; }
		/// <summary>
		/// --start         Start tracing. Implied if --stop is also omitted.
		/// </summary>
		public bool? Start { get; set; }
		/// <summary>
		/// --stop          Stop tracing. Implied if --start is also omitted.
		/// </summary>
		public bool? Stop { get; set; }
		/// <summary>
		/// -d, --duration      Time to wait after starting (if --start is specified or implied) and before stopping (if --stop is specified or implied). Defaults to ten seconds if --stop is specified or implied, zero otherwise.
		/// </summary>
		public string Duration { get; set; }
		/// <summary>
		/// --out           Specify the path of the saved trace file.
		/// </summary>
		public DirectoryPath Out { get; set; }
	}
}