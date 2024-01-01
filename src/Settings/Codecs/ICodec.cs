using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Codecs
{
    public interface ICodec
    {
        /// <summary>
        /// Set the codec to use
        /// </summary>
        [Argument("--codec")]
        public Codec Codec { get; }
    }
}