using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class Thumb
    (
        uint? Width = null,
        uint? Height = null,
        uint? Quality = null
    ) : Stringable
    {
        public Thumb() : this(null, null, null)
        {
        }
        public uint? Width { get; set; } = Width;
        public uint? Height { get; set; } = Height;

        public uint? Quality
        {
            get => _quality;
            set => _quality = value is null ? null : uint.Clamp(value.Value, 0, 100);
        }
        private uint? _quality = Quality is null ? null : uint.Clamp(Quality.Value, 0, 100);

        public override string ToString() => $"{Width}:{Height}:{Quality}";
    }
}