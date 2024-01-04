using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class RegionOfInterest
    (
        decimal X,
        decimal Y,
        decimal Width,
        decimal Height
    ) : Stringable
    {
        public decimal X { get; set; } = X;
        public decimal Y { get; set; } = Y;
        public decimal Width { get; set; } = Width;
        public decimal Height { get; set; } = Height;

        public override string ToString() => $"{X},{Y},{Width},{Height}";
    }
}