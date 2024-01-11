using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class RegionOfInterest
    (
        decimal? X = null,
        decimal? Y = null,
        decimal? Width = null,
        decimal? Height = null
    ) : Stringable
    {
        public RegionOfInterest() : this(null, null, null, null)
        {
        }

        public decimal? X { get; set; } = X;
        public decimal? Y { get; set; } = Y;
        public decimal? Width { get; set; } = Width;
        public decimal? Height { get; set; } = Height;

        public override string ToString() => $"{X},{Y},{Width},{Height}";
    }
}