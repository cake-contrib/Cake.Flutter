using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Build an Android app bundle file from your app.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterBuildAppBundle(this ICakeContext context, FlutterBuildAppBundleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterBuildAppBundleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("build appbundle", settings ?? new FlutterBuildAppBundleSettings());
		}


        /// <summary>
        /// Build an Android app bundle file from your app.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
        [CakeMethodAlias]
		public static IEnumerable<string> FlutterBuildAppBundleWithResult(this ICakeContext context, FlutterBuildAppBundleSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterBuildAppBundleSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("build appbundle", settings ?? new FlutterBuildAppBundleSettings());
		}

	}
}
