using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Types
{
    public class Mode : Stringable
    {
        public Mode()
        {
        }

        public Mode
        (
            string? Name = null,
            uint? Width = null,
            uint? Height = null,
            double? Fps = null,
            Crop? Crop = null,
            BitDepth? BitDepth = null,
            Packing? Packed = null
        )
        {
            this.Name = Name;
            this.Width = Width;
            this.Height = Height;
            this.Fps = Fps;
            this.Crop = Crop;
            this.BitDepth = BitDepth;
            this.Packed = Packed;
        }

        public string? Name { get; set; }
        public uint? Width { get; set; }
        public uint? Height { get; set; }
        public double? Fps { get; set; }
        public Crop? Crop { get; set; }
        public BitDepth? BitDepth { get; set; }
        public Packing? Packed { get; set; }

        public override string ToString()
        {
            return $"{Width}:{Height}" + (BitDepth != null ? $":{BitDepth.Value}" : "") + (Packed != null ? $":{Packed.Value}" : "");
        }
    }
}