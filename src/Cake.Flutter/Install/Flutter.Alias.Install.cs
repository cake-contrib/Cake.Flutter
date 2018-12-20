using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Install a Flutter app on an attached device.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterInstall(this ICakeContext context, FlutterInstallSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterInstallSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("install", settings ?? new FlutterInstallSettings());
		}


         /// <summary>
	    /// Install a Flutter app on an attached device.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterInstallWithResult(this ICakeContext context, FlutterInstallSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterInstallSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("install", settings ?? new FlutterInstallSettings());
		}

	}
}
