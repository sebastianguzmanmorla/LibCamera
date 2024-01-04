using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class Crop
    (
        uint X,
        uint Y,
        uint Width,
        uint Height
    ) : Stringable
    {
        public uint X { get; set; } = X;
        public uint Y { get; set; } = Y;
        public uint Width { get; set; } = Width;
        public uint Height { get; set; } = Height;

        public override string ToString() => $"{X},{Y},{Width},{Height}";
    }
}