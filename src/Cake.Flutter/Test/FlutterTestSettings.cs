using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter test.
	/// Run Flutter unit tests for the current project..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterTestSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help                      Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --[no-]pub                  Whether to run &quot;flutter packages get&quot; before executing this command. (defaults to on)
		/// </summary>
		public bool? Pub { get; set; }
		/// <summary>
		/// --name=&lt;regexp&gt;             A regular expression matching substrings of the names of tests to run.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// --plain-name=&lt;substring&gt;    A plain-text substring of the names of tests to run.
		/// </summary>
		public string PlainName { get; set; }
		/// <summary>
		/// --start-paused              Start in a paused mode and wait for a debugger to connect. You must specify a single test file to run, explicitly. Instructions for connecting with a debugger and printed to the console once the test has started.
		/// </summary>
		public bool? StartPaused { get; set; }
		/// <summary>
		/// --coverage                  Whether to collect coverage information.
		/// </summary>
		public bool? Coverage { get; set; }
		/// <summary>
		/// --merge-coverage            Whether to merge coverage data with &quot;coverage/lcov.base.info&quot;. Implies collecting coverage data. (Requires lcov)
		/// </summary>
		public bool? MergeCoverage { get; set; }
		/// <summary>
		/// --coverage-path             Where to store coverage information (if coverage is enabled). (defaults to &quot;coverage/lcov.info&quot;)
		/// </summary>
		public DirectoryPath CoveragePath { get; set; }
		/// <summary>
		/// --update-goldens            Whether matchesGoldenFile() calls within your test methods should update the golden files rather than test for an existing match.
		/// </summary>
		public bool? UpdateGoldens { get; set; }
		/// <summary>
		/// -j, --concurrency=&lt;jobs&gt;        The number of concurrent test processes to run. (defaults to &quot;6&quot;)
		/// </summary>
		public int? Concurrency { get; set; }
	}
}