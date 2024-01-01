using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class AutofocusSpeed(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static AutofocusSpeed Normal => new("normal");
        public static AutofocusSpeed Fast => new("fast");
    }
}