using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Upgrade your copy of Flutter.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterUpgrade(this ICakeContext context, FlutterUpgradeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterUpgradeSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("upgrade", settings ?? new FlutterUpgradeSettings());
		}


         /// <summary>
	    /// Upgrade your copy of Flutter.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterUpgradeWithResult(this ICakeContext context, FlutterUpgradeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterUpgradeSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("upgrade", settings ?? new FlutterUpgradeSettings());
		}

	}
}
