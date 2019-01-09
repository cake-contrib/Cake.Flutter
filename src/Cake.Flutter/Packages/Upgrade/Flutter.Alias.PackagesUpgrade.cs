using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Upgrade packages in a Flutter project.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterPackagesUpgrade(this ICakeContext context, FlutterPackagesUpgradeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPackagesUpgradeSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("packages upgrade", settings ?? new FlutterPackagesUpgradeSettings());
		}


         /// <summary>
	    /// Upgrade packages in a Flutter project.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterPackagesUpgradeWithResult(this ICakeContext context, FlutterPackagesUpgradeSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterPackagesUpgradeSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("packages upgrade", settings ?? new FlutterPackagesUpgradeSettings());
		}

	}
}
