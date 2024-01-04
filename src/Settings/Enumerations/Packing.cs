using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class Packing(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static Packing Packed => new("P");
        public static Packing Unpacked => new("U");
    }
}