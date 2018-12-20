using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter screenshot.
	/// Take a screenshot from a connected device..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterScreenshotSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                       Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// -o, --out=&lt;path/to/file&gt;         Location to write the screenshot.
		/// </summary>
		public DirectoryPath Out { get; set; }
		/// <summary>
		/// --observatory-port=&lt;port&gt;    The observatory port to connect to. This is required when --type is &quot;skia&quot; or &quot;rasterizer&quot;. To find the observatory port number, use &quot;flutter run --verbose&quot; and look for &quot;Forwarded host port ... for Observatory&quot; in the output.
		/// </summary>
		public int? ObservatoryPort { get; set; }
		/// <summary>
		/// --type=&lt;type&gt;                The type of screenshot to retrieve.
		/// </summary>
		public bool? Type { get; set; }
	}
}