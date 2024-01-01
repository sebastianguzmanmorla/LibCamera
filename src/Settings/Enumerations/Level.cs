using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class Level(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        // List of h264 levels from https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC
        public static Level Level1 => new("1");
        public static Level Level1b => new("1b");
        public static Level Level11 => new("1.1");
        public static Level Level12 => new("1.2");
        public static Level Level13 => new("1.3");
        public static Level Level2 => new("2");
        public static Level Level21 => new("2.1");
        public static Level Level22 => new("2.2");
        public static Level Level3 => new("3");
        public static Level Level31 => new("3.1");
        public static Level Level32 => new("3.2");
        public static Level Level4 => new("4");
        public static Level Level41 => new("4.1");
        public static Level Level42 => new("4.2");
        public static Level Level5 => new("5");
        public static Level Level51 => new("5.1");
        public static Level Level52 => new("5.2");
    }
}