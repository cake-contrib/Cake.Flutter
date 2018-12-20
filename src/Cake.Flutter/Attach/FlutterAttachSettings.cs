using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter attach.
	/// Attach to a running application..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterAttachSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help             Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --debug            Build a debug version of your app (default mode).
		/// </summary>
		public bool? Debug { get; set; }
		/// <summary>
		/// --profile          Build a version of your app specialized for performance profiling.
		/// </summary>
		public bool? Profile { get; set; }
		/// <summary>
		/// --release          Build a release version of your app.
		/// </summary>
		public bool? Release { get; set; }
		/// <summary>
		/// -t, --target=&lt;path&gt;    The main entry-point file of the application, as run on the device. If the --target option is omitted, but a file name is provided on the command line, then that is used instead. (defaults to &quot;lib/main.dart&quot;)
		/// </summary>
		public FilePath Target { get; set; }
		/// <summary>
		/// --debug-port       Local port where the observatory is listening.
		/// </summary>
		public int? DebugPort { get; set; }
		/// <summary>
		/// --pid-file         Specify a file to write the process id to. You can send SIGUSR1 to trigger a hot reload and SIGUSR2 to trigger a hot restart.
		/// </summary>
		public string PidFile { get; set; }
	}
}