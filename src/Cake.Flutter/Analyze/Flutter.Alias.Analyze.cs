using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Analyze the project's Dart code.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterAnalyze(this ICakeContext context, FlutterAnalyzeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterAnalyzeSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("analyze", settings ?? new FlutterAnalyzeSettings());
		}


         /// <summary>
	    /// Analyze the project's Dart code.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterAnalyzeWithResult(this ICakeContext context, FlutterAnalyzeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterAnalyzeSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("analyze", settings ?? new FlutterAnalyzeSettings());
		}

	}
}
