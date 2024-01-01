using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class AutofocusMode(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static AutofocusMode Manual => new("manual");
        public static AutofocusMode Auto => new("auto");
        public static AutofocusMode Continuous => new("continuous");
    }
}