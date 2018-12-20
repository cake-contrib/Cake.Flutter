using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Flutter
{
    /// <summary>
    /// Base class for tooling that is used for autogeneration of command line arguments.
    /// </summary>
    public abstract class AutoToolSettings: ToolSettings
    {
        /// <summary>
        ///  Target device id or name (prefixes allowed).
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// Suppress analytics reporting when this command runs.
        /// </summary>
        public bool? SuppressAnalytics { get; set; }
        /// <summary>
        /// Path to your ".packages" file.
        /// (required, since the current directory does not contain a ".packages" file)
        /// </summary>
        public FilePath Packages { get; set; }
    }
}
