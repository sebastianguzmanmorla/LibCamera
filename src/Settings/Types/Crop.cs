using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class Crop : Stringable
    {
        public Crop()
        {
        }

        public Crop
        (
            uint? X = null,
            uint? Y = null,
            uint? Width = null,
            uint? Height = null)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }

        public uint? X { get; set; }
        public uint? Y { get; set; }
        public uint? Width { get; set; }
        public uint? Height { get; set; }

        public override string ToString() => $"{X},{Y},{Width},{Height}";
    }
}