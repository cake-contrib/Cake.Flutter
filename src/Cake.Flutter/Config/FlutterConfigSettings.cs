using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter config.
	/// Configure Flutter settings..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterConfigSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                      Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --[no-]analytics            Enable or disable reporting anonymously tool usage statistics and crash reports.
		/// </summary>
		public bool? Analytics { get; set; }
		/// <summary>
		/// --clear-ios-signing-cert    Clear the saved development certificate choice used to sign apps for iOS device deployment.
		/// </summary>
		public bool? ClearIosSigningCert { get; set; }
		/// <summary>
		/// --gradle-dir                The gradle install directory.
		/// </summary>
		public DirectoryPath GradleDir { get; set; }
		/// <summary>
		/// --android-sdk               The Android SDK directory.
		/// </summary>
		public DirectoryPath AndroidSdk { get; set; }
		/// <summary>
		/// --android-studio-dir        The Android Studio install directory.
		/// </summary>
		public DirectoryPath AndroidStudioDir { get; set; }
	}
}