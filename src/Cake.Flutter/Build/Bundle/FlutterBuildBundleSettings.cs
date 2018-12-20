using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter build bundle.
	/// Build the Flutter assets directory from your app..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterBuildBundleSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                             Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// -t, --target=&lt;path&gt;                    The main entry-point file of the application, as run on the device. If the --target option is omitted, but a file name is provided on the command line, then that is used instead. (defaults to &quot;lib/main.dart&quot;)
		/// </summary>
		public FilePath Target { get; set; }
		/// <summary>
		/// --debug                            Build a debug version of your app.
		/// </summary>
		public bool? Debug { get; set; }
		/// <summary>
		/// --profile                          Build a version of your app specialized for performance profiling.
		/// </summary>
		public bool? Profile { get; set; }
		/// <summary>
		/// --release                          Build a release version of your app (default mode).
		/// </summary>
		public bool? Release { get; set; }
		/// <summary>
		/// --precompiled
		/// </summary>
		public bool? Precompiled { get; set; }
		/// <summary>
		/// --manifest                         (defaults to &quot;pubspec.yaml&quot;)
		/// </summary>
		public string Manifest { get; set; }
		/// <summary>
		/// --private-key                      (defaults to &quot;privatekey.der&quot;)
		/// </summary>
		public string PrivateKey { get; set; }
		/// <summary>
		/// --depfile                          (defaults to &quot;build\snapshot_blob.bin.d&quot;)
		/// </summary>
		public bool? Depfile { get; set; }
		/// <summary>
		/// --target-platform                  [android-arm (default), android-arm64, ios]
		/// </summary>
		public TargetPlatform? TargetPlatform { get; set; }
		/// <summary>
		/// --asset-dir                        (defaults to &quot;build\flutter_assets&quot;)
		/// </summary>
		public DirectoryPath AssetDir { get; set; }
		/// <summary>
		/// --[no-]report-licensed-packages    Whether to report the names of all the packages that are included in the application&#39;s LICENSE file.
		/// </summary>
		public bool? ReportLicensedPackages { get; set; }
		/// <summary>
		/// --[no-]pub                         Whether to run &quot;flutter packages get&quot; before executing this command. (defaults to on)
		/// </summary>
		public bool? Pub { get; set; }
	}
}