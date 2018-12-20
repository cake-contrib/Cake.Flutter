using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.Flutter
{
	partial class FlutterAliases
	{
         /// <summary>
	    /// Start and stop tracing for a running Flutter app.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void FlutterTrace(this ICakeContext context, FlutterTraceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterTraceSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("trace", settings ?? new FlutterTraceSettings());
		}


         /// <summary>
	    /// Start and stop tracing for a running Flutter app.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> FlutterTraceWithResult(this ICakeContext context, FlutterTraceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            var runner = new GenericRunner<FlutterTraceSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("trace", settings ?? new FlutterTraceSettings());
		}

	}
}
