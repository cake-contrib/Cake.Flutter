using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter doctor.
	/// Show information about the installed tooling..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterDoctorSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --android-licenses    Run the Android SDK manager tool to accept the SDK&#39;s licenses.
		/// </summary>
		public bool? AndroidLicenses { get; set; }
	}
}