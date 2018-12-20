using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter run.
	/// Run your Flutter app on an attached device..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterRunSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                            Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --debug                           Build a debug version of your app (default mode).
		/// </summary>
		public bool? Debug { get; set; }
		/// <summary>
		/// --profile                         Build a version of your app specialized for performance profiling.
		/// </summary>
		public bool? Profile { get; set; }
		/// <summary>
		/// --release                         Build a release version of your app.
		/// </summary>
		public bool? Release { get; set; }
		/// <summary>
		/// --flavor                          Build a custom app flavor as defined by platform-specific build setup. Supports the use of product flavors in Android Gradle scripts. Supports the use of custom Xcode schemes.
		/// </summary>
		public bool? Flavor { get; set; }
		/// <summary>
		/// --trace-startup                   Start tracing during startup.
		/// </summary>
		public bool? TraceStartup { get; set; }
		/// <summary>
		/// --route                           Which route to load when running the app.
		/// </summary>
		public string Route { get; set; }
		/// <summary>
		/// --target-platform                 Specify the target platform when building the app for an Android device. Ignored on iOS. [default (default), android-arm, android-arm64]
		/// </summary>
		public TargetPlatform? TargetPlatform { get; set; }
		/// <summary>
		/// -t, --target=&lt;path&gt;                   The main entry-point file of the application, as run on the device. If the --target option is omitted, but a file name is provided on the command line, then that is used instead. (defaults to &quot;lib/main.dart&quot;)
		/// </summary>
		public FilePath Target { get; set; }
		/// <summary>
		/// --observatory-port                Listen to the given port for an observatory debugger connection. Specifying port 0 (the default) will find a random free port.
		/// </summary>
		public int? ObservatoryPort { get; set; }
		/// <summary>
		/// --[no-]pub                        Whether to run &quot;flutter packages get&quot; before executing this command. (defaults to on)
		/// </summary>
		public bool? Pub { get; set; }
		/// <summary>
		/// --start-paused                    Start in a paused mode and wait for a debugger to connect.
		/// </summary>
		public bool? StartPaused { get; set; }
		/// <summary>
		/// --enable-software-rendering       Enable rendering using the Skia software backend. This is useful when testing Flutter on emulators. By default, Flutter will attempt to either use OpenGL or Vulkan and fall back to software when neither is available.
		/// </summary>
		public bool? EnableSoftwareRendering { get; set; }
		/// <summary>
		/// --skia-deterministic-rendering    When combined with --enable-software-rendering, provides 100% deterministic Skia rendering.
		/// </summary>
		public bool? SkiaDeterministicRendering { get; set; }
		/// <summary>
		/// --trace-skia                      Enable tracing of Skia code. This is useful when debugging the GPU thread. By default, Flutter will not log skia code.
		/// </summary>
		public bool? TraceSkia { get; set; }
		/// <summary>
		/// --[no-]use-test-fonts             Enable (and default to) the &quot;Ahem&quot; font. This is a special font used in tests to remove any dependencies on the font metrics. It is enabled when you use &quot;flutter test&quot;. Set this flag when running a test using &quot;flutter run&quot; for debugging purposes. This flag is only available when running in debug mode.
		/// </summary>
		public bool? UseTestFonts { get; set; }
		/// <summary>
		/// --[no-]build                      If necessary, build the app before running. (defaults to on)
		/// </summary>
		public bool? Build { get; set; }
		/// <summary>
		/// --[no-]hot                        Run with support for hot reloading. (defaults to on)
		/// </summary>
		public bool? Hot { get; set; }
		/// <summary>
		/// --pid-file                        Specify a file to write the process id to. You can send SIGUSR1 to trigger a hot reload and SIGUSR2 to trigger a hot restart.
		/// </summary>
		public string PidFile { get; set; }
	}
}