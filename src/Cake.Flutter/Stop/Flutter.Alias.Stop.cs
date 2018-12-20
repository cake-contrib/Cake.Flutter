using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Stop your Flutter app on an attached device.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterStop(this ICakeContext context, FlutterStopSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterStopSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("stop", settings ?? new FlutterStopSettings());
		}


         /// <summary>
	    /// Stop your Flutter app on an attached device.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterStopWithResult(this ICakeContext context, FlutterStopSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterStopSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("stop", settings ?? new FlutterStopSettings());
		}

	}
}
