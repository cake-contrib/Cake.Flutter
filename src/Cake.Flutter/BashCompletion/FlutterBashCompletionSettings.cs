using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter bash-completion.
	/// Output command line shell completion setup scripts..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterBashCompletionSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help              Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --[no-]overwrite    Causes the given shell completion setup script to be overwritten if it already exists.
		/// </summary>
		public bool? Overwrite { get; set; }
	}
}