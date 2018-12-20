using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Delete the build/ directory.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterClean(this ICakeContext context, FlutterCleanSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterCleanSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("clean", settings ?? new FlutterCleanSettings());
		}


         /// <summary>
	    /// Delete the build/ directory.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterCleanWithResult(this ICakeContext context, FlutterCleanSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterCleanSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("clean", settings ?? new FlutterCleanSettings());
		}

	}
}
