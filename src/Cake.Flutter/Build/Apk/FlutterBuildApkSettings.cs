using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter build apk.
	/// Build an Android APK file from your app..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterBuildApkSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                    Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// -t, --target=&lt;path&gt;           The main entry-point file of the application, as run on the device. If the --target option is omitted, but a file name is provided on the command line, then that is used instead. (defaults to &quot;lib/main.dart&quot;)
		/// </summary>
		public FilePath Target { get; set; }
		/// <summary>
		/// --debug                   Build a debug version of your app.
		/// </summary>
		public bool? Debug { get; set; }
		/// <summary>
		/// --profile                 Build a version of your app specialized for performance profiling.
		/// </summary>
		public bool? Profile { get; set; }
		/// <summary>
		/// --release                 Build a release version of your app (default mode).
		/// </summary>
		public bool? Release { get; set; }
		/// <summary>
		/// --flavor                  Build a custom app flavor as defined by platform-specific build setup. Supports the use of product flavors in Android Gradle scripts. Supports the use of custom Xcode schemes.
		/// </summary>
		public string Flavor { get; set; }
		/// <summary>
		/// --[no-]pub                Whether to run &quot;flutter packages get&quot; before executing this command. (defaults to on)
		/// </summary>
		public bool? Pub { get; set; }
		/// <summary>
		/// --build-number=&lt;int&gt;      An integer used as an internal version number. Each build must have a unique number to differentiate it from previous builds. It is used to determine whether one build is more recent than another, with higher numbers indicating more recent build. On Android it is used as &#39;versionCode&#39;. On Xcode builds it is used as &#39;CFBundleVersion&#39;
		/// </summary>
		public int? BuildNumber { get; set; }
		/// <summary>
		/// --build-name=&lt;x.y.z&gt;      A &quot;x.y.z&quot; string used as the version number shown to users. For each new version of your app, you will provide a version number to differentiate it from previous versions. On Android it is used as &#39;versionName&#39;. On Xcode builds it is used as &#39;CFBundleShortVersionString&#39;
		/// </summary>
		public string BuildName { get; set; }
		/// <summary>
		/// --build-shared-library    Whether to prefer compiling to a *.so file (android only).
		/// </summary>
		public bool? BuildSharedLibrary { get; set; }
		/// <summary>
		/// --target-platform         [android-arm (default), android-arm64]
		/// </summary>
		public TargetPlatform? TargetPlatform { get; set; }
	}
}