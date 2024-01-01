using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class Metering(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static Metering Centre => new("centre");
	    public static Metering Spot => new("spot");
	    public static Metering Average => new("average");
	    public static Metering Custom => new("custom");
    }
}