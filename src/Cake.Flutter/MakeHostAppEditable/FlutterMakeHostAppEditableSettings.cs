using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter make-host-app-editable.
	/// Moves host apps from generated directories to non-generated directories so that they can be edited by developers..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterMakeHostAppEditableSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help       Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --ios        Whether to make this project&#39;s iOS app editable.
		/// </summary>
		public bool? Ios { get; set; }
		/// <summary>
		/// --android    Whether ot make this project&#39;s Android app editable.
		/// </summary>
		public bool? Android { get; set; }
	}
}