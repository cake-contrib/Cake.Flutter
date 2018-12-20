using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Build an ahead-of-time compiled snapshot of your app's Dart code.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterBuildAot(this ICakeContext context, FlutterBuildAotSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterBuildAotSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("build aot", settings ?? new FlutterBuildAotSettings());
		}


         /// <summary>
	    /// Build an ahead-of-time compiled snapshot of your app's Dart code.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterBuildAotWithResult(this ICakeContext context, FlutterBuildAotSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterBuildAotSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("build aot", settings ?? new FlutterBuildAotSettings());
		}

	}
}
