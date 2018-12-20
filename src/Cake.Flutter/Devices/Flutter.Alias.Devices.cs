using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// List all connected devices.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterDevices(this ICakeContext context, FlutterDevicesSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterDevicesSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("devices", settings ?? new FlutterDevicesSettings());
		}


         /// <summary>
	    /// List all connected devices.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterDevicesWithResult(this ICakeContext context, FlutterDevicesSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterDevicesSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("devices", settings ?? new FlutterDevicesSettings());
		}

	}
}
