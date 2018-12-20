using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Attach to a running application.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterAttach(this ICakeContext context, FlutterAttachSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterAttachSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("attach", settings ?? new FlutterAttachSettings());
		}


         /// <summary>
	    /// Attach to a running application.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterAttachWithResult(this ICakeContext context, FlutterAttachSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterAttachSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("attach", settings ?? new FlutterAttachSettings());
		}

	}
}
