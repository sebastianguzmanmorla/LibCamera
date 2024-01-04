using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class MetadataFormat(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static MetadataFormat Txt => new("txt");
        public static MetadataFormat Json => new("json");
    }
}