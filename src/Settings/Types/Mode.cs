using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Types
{
    public class Mode
    (
        string? Name = null,
        uint? Width = null,
        uint? Height = null,
        double? Fps = null,
        Crop? Crop = null,
        BitDepth? BitDepth = null,
        Packing? Packed = null
    ) : Stringable
    {
        public Mode() : this(null, null, null, null, null, null, null)
        {
        }

        public string? Name { get; set; } = Name;
        public uint? Width { get; set; } = Width;
        public uint? Height { get; set; } = Height;
        public double? Fps { get; set; } = Fps;
        public Crop? Crop { get; set; } = Crop;
        public BitDepth? BitDepth { get; set; } = BitDepth;
        public Packing? Packed { get; set; } = Packed;

        public override string ToString()
        {
            return $"{Width}:{Height}" + (BitDepth != null ? ($":{BitDepth.Value}") : "") + (Packed != null ? $":{Packed.Value}" : "");
        }
    }
}