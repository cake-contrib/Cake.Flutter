using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Run the "test" package.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterPackagesTest(this ICakeContext context, FlutterPackagesTestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPackagesTestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("packages test", settings ?? new FlutterPackagesTestSettings());
		}


         /// <summary>
	    /// Run the "test" package.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterPackagesTestWithResult(this ICakeContext context, FlutterPackagesTestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPackagesTestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("packages test", settings ?? new FlutterPackagesTestSettings());
		}

	}
}
