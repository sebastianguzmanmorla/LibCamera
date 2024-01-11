using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class Crop
    (
        uint? X = null,
        uint? Y = null,
        uint? Width = null,
        uint? Height = null
    ) : Stringable
    {
        public uint? X { get; set; } = X;
        public uint? Y { get; set; } = Y;
        public uint? Width { get; set; } = Width;
        public uint? Height { get; set; } = Height;

        public override string ToString() => $"{X},{Y},{Width},{Height}";
    }
}