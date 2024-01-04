using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class WhiteBalance(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static WhiteBalance Auto => new("auto");
        public static WhiteBalance Incandescent => new("incandescent");
        public static WhiteBalance Tungsten => new("tungsten");
        public static WhiteBalance Fluorescent => new("fluorescent");
        public static WhiteBalance Indoor => new("indoor");
        public static WhiteBalance Daylight => new("daylight");
        public static WhiteBalance Cloudy => new("cloudy");
        public static WhiteBalance Custom => new("custom");
    }
}