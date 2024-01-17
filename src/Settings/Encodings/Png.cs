using System.Text.Json.Serialization;
using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    /// <summary>
    /// Png Still Settings.
    /// </summary>
    [JsonConverter(typeof(StillSettingsConverter<Png>))]
    public class Png : StillSettings
    {
        /// <summary>
        /// Will use the PNG encoding.
        /// </summary>
        public override Encoding Encoding => Encoding.Png;
    }
}