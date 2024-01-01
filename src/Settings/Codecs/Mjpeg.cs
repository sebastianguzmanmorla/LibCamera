using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Codecs
{
    public class Mjpeg : VideoSettings, ICodec
    {
        public Codec Codec => Codec.Mjpeg;

        /// <summary>
        /// Set the MJPEG quality parameter (mjpeg only)
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