using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter analyze.
	/// Analyze the project&#39;s Dart code..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterAnalyzeSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                    Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --[no-]current-package    Analyze the current project, if applicable. (defaults to on)
		/// </summary>
		public bool? CurrentPackage { get; set; }
		/// <summary>
		/// --watch                   Run analysis continuously, watching the filesystem for changes.
		/// </summary>
		public bool? Watch { get; set; }
		/// <summary>
		/// --write=&lt;file&gt;            Also output the results to a file. This is useful with --watch if you want a file to always contain the latest results.
		/// </summary>
		public FilePath Write { get; set; }
		/// <summary>
		/// --[no-]pub                Whether to run &quot;flutter packages get&quot; before executing this command. (defaults to on)
		/// </summary>
		public bool? Pub { get; set; }
		/// <summary>
		/// --[no-]congratulate       Show output even when there are no errors, warnings, hints, or lints. Ignored if --watch is specified. (defaults to on)
		/// </summary>
		public bool? Congratulate { get; set; }
		/// <summary>
		/// --[no-]preamble           When analyzing the flutter repository, display the number of files that will be analyzed. Ignored if --watch is specified. (defaults to on)
		/// </summary>
		public bool? Preamble { get; set; }
	}
}