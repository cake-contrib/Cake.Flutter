using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter create.
	/// Create a new Flutter project..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterCreateSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                                                                                                        Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --[no-]pub                                                                                                    Whether to run &quot;flutter packages get&quot; after the project has been created. (defaults to on)
		/// </summary>
		public bool? Pub { get; set; }
		/// <summary>
		/// --[no-]offline                                                                                                When &quot;flutter packages get&quot; is run by the create command, this indicates whether to run it in offline mode or not. In offline mode, it will need to have all dependencies already available in the pub cache to succeed.
		/// </summary>
		public bool? Offline { get; set; }
		/// <summary>
		/// --[no-]with-driver-test                                                                                       Also add a flutter_driver dependency and generate a sample &#39;flutter drive&#39; test.
		/// </summary>
		public bool? WithDriverTest { get; set; }
		/// <summary>
		/// -t, --template=&lt;type&gt;                                                                                             Specify the type of project to create.
		/// </summary>
		public Template? Template { get; set; }
		/// <summary>
		/// -s, --sample=&lt;the sample ID of the desired sample from the API documentation website (http://docs.flutter.io)&gt;    Specifies the Flutter code sample to use as the main.dart for an application. Implies --template=app.
		/// </summary>
		public string Sample { get; set; }
		/// <summary>
		/// --[no-]overwrite                                                                                              When performing operations, overwrite existing files.
		/// </summary>
		public bool? Overwrite { get; set; }
		/// <summary>
		/// --description                                                                                                 The description to use for your new Flutter project. This string ends up in the pubspec.yaml file. (defaults to &quot;A new Flutter project.&quot;)
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// --org                                                                                                         The organization responsible for your new Flutter project, in reverse domain name notation. This string is used in Java package names and as prefix in the iOS bundle identifier. (defaults to &quot;com.example&quot;)
		/// </summary>
		public string Org { get; set; }
		/// <summary>
		/// --project-name                                                                                                The project name for this new Flutter project. This must be a valid dart package name.
		/// </summary>
		public string ProjectName { get; set; }
		/// <summary>
		/// -i, --ios-language                                                                                                [objc (default), swift]
		/// </summary>
		public IOSLanguage? IosLanguage { get; set; }
		/// <summary>
		/// -a, --android-language                                                                                            [java (default), kotlin]
		/// </summary>
		public AndroidLanguage? AndroidLanguage { get; set; }
	}
}