using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    public interface IEncoding
    {
        /// <summary>
        /// Set the desired output encoding
        /// </summary>
        [Argument("--encoding")]
        public Encoding Encoding { get; }
    }
}