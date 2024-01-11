using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class RegionOfInterest : Stringable
    {
        public RegionOfInterest()
        {
        }

        public RegionOfInterest
        (
            decimal? X = null,
            decimal? Y = null,
            decimal? Width = null,
            decimal? Height = null
        )
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }

        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }

        public override string ToString() => $"{X},{Y},{Width},{Height}";
    }
}