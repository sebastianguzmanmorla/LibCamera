using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class Size : Stringable
    {
        public Size()
        {
        }

        public Size
        (
            uint? Width = null,
            uint? Height = null
        )
        {
            this.Width = Width;
            this.Height = Height;
        }

        public uint? Width { get; set; }
        public uint? Height { get; set; }

        public override string ToString() => $"{Width}x{Height}";
    }
}