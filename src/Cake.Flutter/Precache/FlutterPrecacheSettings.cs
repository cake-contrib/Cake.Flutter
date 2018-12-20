using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter precache.
	/// Populates the Flutter tool&#39;s cache of binary artifacts..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterPrecacheSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help             Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// -a, --all-platforms    Precache artifacts for all platforms.
		/// </summary>
		public bool? AllPlatforms { get; set; }
	}
}