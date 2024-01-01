using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class Exposure(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static Exposure Normal => new("normal");
	    public static Exposure Sport => new("sport");
    }
}