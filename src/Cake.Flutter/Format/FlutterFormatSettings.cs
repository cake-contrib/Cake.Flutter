using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter format.
	/// Format one or more dart files..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterFormatSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                   Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// -n, --dry-run                Show which files would be modified but make no changes.
		/// </summary>
		public bool? DryRun { get; set; }
		/// <summary>
		/// --set-exit-if-changed    Return exit code 1 if there are any formatting changes.
		/// </summary>
		public bool? SetExitIfChanged { get; set; }
		/// <summary>
		/// -m, --machine                Produce machine-readable JSON output.
		/// </summary>
		public bool? Machine { get; set; }
	}
}