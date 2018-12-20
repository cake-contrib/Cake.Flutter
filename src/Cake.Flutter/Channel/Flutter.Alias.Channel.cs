using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// List or switch flutter channels.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterChannel(this ICakeContext context, FlutterChannelSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterChannelSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("channel", settings ?? new FlutterChannelSettings());
		}


         /// <summary>
	    /// List or switch flutter channels.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterChannelWithResult(this ICakeContext context, FlutterChannelSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterChannelSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("channel", settings ?? new FlutterChannelSettings());
		}

	}
}
