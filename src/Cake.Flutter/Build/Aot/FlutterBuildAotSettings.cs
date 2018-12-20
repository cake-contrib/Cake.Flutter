using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter build aot.
	/// Build an ahead-of-time compiled snapshot of your app&#39;s Dart code..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterBuildAotSettings : AutoToolSettings
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
		/// --[no-]pub                Whether to run &quot;flutter packages get&quot; before executing this command. (defaults to on)
		/// </summary>
		public bool? Pub { get; set; }
		/// <summary>
		/// --output-dir              (defaults to &quot;build\aot&quot;)
		/// </summary>
		public DirectoryPath OutputDir { get; set; }
		/// <summary>
		/// --target-platform         [android-arm (default), android-arm64, ios]
		/// </summary>
		public TargetPlatform? TargetPlatform { get; set; }
		/// <summary>
		/// --[no-]quiet
		/// </summary>
		public bool? Quiet { get; set; }
		/// <summary>
		/// --build-shared-library    Compile to a *.so file (requires NDK when building for Android).
		/// </summary>
		public bool? BuildSharedLibrary { get; set; }
		/// <summary>
		/// --ios-arch                iOS architectures to build. [armv7, arm64 (default)]
		/// </summary>
		public IOSArch? IosArch { get; set; }
	}
}