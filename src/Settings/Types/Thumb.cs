using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class Thumb
    (
        uint Width,
        uint Height,
        uint Quality
    ) : Stringable
    {
        public uint Width { get; set; } = Width;
        public uint Height { get; set; } = Height;

        public uint? Quality
        {
            get => _quality;
            set => _quality = value is null ? null : uint.Clamp(value.Value, 0, 100);
        }
        private uint? _quality = uint.Clamp(Quality, 0, 100);

        public override string ToString() => $"{Width}:{Height}:{Quality}";
    }
}