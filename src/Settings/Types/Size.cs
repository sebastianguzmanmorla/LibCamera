using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class Size
    (
        uint? Width,
        uint? Height
    ) : Stringable
    {
        public uint? Width { get; set; } = Width;
        public uint? Height { get; set; } = Height;

        public override string ToString() => $"{Width}x{Height}";
    }
}