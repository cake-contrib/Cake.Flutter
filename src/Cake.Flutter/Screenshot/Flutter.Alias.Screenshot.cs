using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Take a screenshot from a connected device.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterScreenshot(this ICakeContext context, FlutterScreenshotSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterScreenshotSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("screenshot", settings ?? new FlutterScreenshotSettings());
		}


         /// <summary>
	    /// Take a screenshot from a connected device.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterScreenshotWithResult(this ICakeContext context, FlutterScreenshotSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterScreenshotSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("screenshot", settings ?? new FlutterScreenshotSettings());
		}

	}
}
