using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class Profile(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static Profile Baseline => new("baseline");
        public static Profile Main => new("main");
        public static Profile High => new("high");
    }
}