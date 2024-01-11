using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    public class Jpg : StillSettings, IEncoding
    {
        public Encoding Encoding => Encoding.Jpg;

        /// <summary>
        /// Set the JPEG quality parameter
        /// </summary>
        [Argument("--quality")]
        public uint? Quality
        {
            get => _quality;
            set => _quality = value is null ? null : uint.Clamp(value.Value, 0, 100);
        }
        private uint? _quality = null;
    }
}