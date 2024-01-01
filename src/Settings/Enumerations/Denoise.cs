using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class Denoise(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static Denoise Auto => new("auto");
        public static Denoise Off => new("off");
        public static Denoise CdnOff => new("cdn_off");
        public static Denoise CdnFast => new("cdn_fast");
        public static Denoise CdnHq => new("cdn_hq");
    }
}