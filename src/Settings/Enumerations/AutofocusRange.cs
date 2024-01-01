using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class AutofocusRange(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static AutofocusRange Normal => new("normal");
        public static AutofocusRange Macro => new("macro");
        public static AutofocusRange Full => new("full");
    }
}