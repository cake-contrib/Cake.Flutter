using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Run your Flutter app on an attached device.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterRun(this ICakeContext context, FlutterRunSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterRunSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("run", settings ?? new FlutterRunSettings());
		}


         /// <summary>
	    /// Run your Flutter app on an attached device.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterRunWithResult(this ICakeContext context, FlutterRunSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterRunSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("run", settings ?? new FlutterRunSettings());
		}

	}
}
