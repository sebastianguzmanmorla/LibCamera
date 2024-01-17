using System.Text.Json.Serialization;
using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    /// <summary>
    /// Bmp Still Settings.
    /// </summary>
    [JsonConverter(typeof(StillSettingsConverter<Bmp>))]
    public class Bmp : StillSettings
    {
        /// <summary>
        /// Will use the BMP encoding.
        /// </summary>
        public override Encoding Encoding => Encoding.Bmp;
    }
}