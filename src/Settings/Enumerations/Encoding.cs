using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class Encoding(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static Encoding Jpg => new("jpg");
        public static Encoding Png => new("png");
        public static Encoding Rgb => new("rgb");
        public static Encoding Bmp => new("bmp");
        public static Encoding Yuv420 => new("yuv420");
    }
}