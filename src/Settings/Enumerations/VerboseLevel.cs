using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class VerboseLevel(uint Value, string? Description = null) : Enumeration<uint>(Value, Description)
    {
        /// <summary>
        /// No output
        /// </summary>
        public static VerboseLevel None => new(0);

        /// <summary>
        /// Normal output
        /// </summary>
	    public static VerboseLevel Normal => new(1);

        /// <summary>
        /// Verbose output
        /// </summary>
	    public static VerboseLevel Verbose => new(2);
    }
}