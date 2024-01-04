using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Types
{
    public class Mode
    (
        string Value,
        uint Width,
        uint Height,
        double Fps,
        Crop Crop,
        BitDepth? BitDepth = null,
        Packing? Packed = null
    ) : Stringable
    {
        public string Value { get; set; } = Value;
        public uint Width { get; set; } = Width;
        public uint Height { get; set; } = Height;
        public double Fps { get; set; } = Fps;
        public Crop Crop { get; set; } = Crop;
        public BitDepth? BitDepth { get; set; } = BitDepth;
        public Packing? Packed { get; set; } = Packed;

        public override string ToString()
        {
            return $"{Width}:{Height}" + (BitDepth != null ? ($":{BitDepth.Value}") : "") + (Packed != null ? $":{Packed.Value}" : "");
        }
    }
}