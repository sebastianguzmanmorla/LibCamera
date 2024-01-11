using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class Thumb : Stringable
    {
        public Thumb()
        {
        }

        public Thumb
        (
            uint? Width = null,
            uint? Height = null,
            uint? Quality = null
        )
        {
            this.Width = Width;
            this.Height = Height;
            this.Quality = Quality;
        }

        public uint? Width { get; set; }
        public uint? Height { get; set; }

        public uint? Quality
        {
            get => _quality;
            set => _quality = value is null ? null : uint.Clamp(value.Value, 0, 100);
        }
        private uint? _quality;

        public override string ToString() => $"{Width}:{Height}:{Quality}";
    }
}