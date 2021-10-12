using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter drive.
	/// Runs Flutter Driver tests for the current project..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterDriveSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                      Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --debug                     Build a debug version of your app (default mode).
		/// </summary>
		public bool? Debug { get; set; }
		/// <summary>
		/// --profile                   Build a version of your app specialized for performance profiling.
		/// </summary>
		public bool? Profile { get; set; }
		/// <summary>
		/// --release                   Build a release version of your app.
		/// </summary>
		public bool? Release { get; set; }
		/// <summary>
		/// --flavor                    Build a custom app flavor as defined by platform-specific build setup. Supports the use of product flavors in Android Gradle scripts. Supports the use of custom Xcode schemes.
		/// </summary>
		public string Flavor { get; set; }
		/// <summary>
		/// --trace-startup             Start tracing during startup.
		/// </summary>
		public bool? TraceStartup { get; set; }
		/// <summary>
		/// --route                     Which route to load when running the app.
		/// </summary>
		public string Route { get; set; }
		/// <summary>
		/// --target-platform           Specify the target platform when building the app for an Android device. Ignored on iOS. [default (default), android-arm, android-arm64]
		/// </summary>
		public TargetPlatform? TargetPlatform { get; set; }
		/// <summary>
		/// -t, --target=&lt;path&gt;             The main entry-point file of the application, as run on the device. If the --target option is omitted, but a file name is provided on the command line, then that is used instead. (defaults to &quot;lib/main.dart&quot;)
		/// </summary>
		public FilePath Target { get; set; }
		/// <summary>
		/// --observatory-port          Listen to the given port for an observatory debugger connection. Specifying port 0 (the default) will find a random free port.
		/// </summary>
		public int? ObservatoryPort { get; set; }
		/// <summary>
		/// --[no-]pub                  Whether to run &quot;flutter packages get&quot; before executing this command. (defaults to on)
		/// </summary>
		public bool? Pub { get; set; }
		/// <summary>
		/// --[no-]keep-app-running     Will keep the Flutter application running when done testing. By default, &quot;flutter drive&quot; stops the application after tests are finished, and --keep-app-running overrides this. On the other hand, if --use-existing-app is specified, then &quot;flutter drive&quot; instead defaults to leaving the application running, and --no-keep-app-running overrides it.
		/// </summary>
		public bool? KeepAppRunning { get; set; }
		/// <summary>
		/// --use-existing-app=&lt;url&gt;    Connect to an already running instance via the given observatory URL. If this option is given, the application will not be automatically started, and it will only be stopped if --no-keep-app-running is explicitly set.
		/// </summary>
		public string UseExistingApp { get; set; }
		/// <summary>
		/// --driver=&lt;path&gt;             The test file to run on the host (as opposed to the target file to run on the device). By default, this file has the same base name as the target file, but in the &quot;test_driver/&quot; directory instead, and with &quot;_test&quot; inserted just before the extension, so e.g. if the target is &quot;lib/main.dart&quot;, the driver will be &quot;test_driver/main_test.dart&quot;.
		/// </summary>
		public FilePath Driver { get; set; }
	}
}