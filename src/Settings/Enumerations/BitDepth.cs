using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class BitDepth(uint Value, string? Description = null) : Enumeration<uint>(Value, Description)
    {
        public static BitDepth Bit10 => new(10);
        public static BitDepth Bit12 => new(12);
    }
}