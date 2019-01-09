using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Get packages in a Flutter project.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterPackagesGet(this ICakeContext context, FlutterPackagesGetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPackagesGetSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("packages get", settings ?? new FlutterPackagesGetSettings());
		}


         /// <summary>
	    /// Get packages in a Flutter project.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterPackagesGetWithResult(this ICakeContext context, FlutterPackagesGetSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPackagesGetSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("packages get", settings ?? new FlutterPackagesGetSettings());
		}

	}
}
