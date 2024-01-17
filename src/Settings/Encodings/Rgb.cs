using System.Text.Json.Serialization;
using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    /// <summary>
    /// Rgb Still Settings.
    /// </summary>
    [JsonConverter(typeof(StillSettingsConverter<Rgb>))]
    public class Rgb : StillSettings
    {
        /// <summary>
        /// Will use the RGB encoding.
        /// </summary>
        public override Encoding Encoding => Encoding.Rgb;
    }
}