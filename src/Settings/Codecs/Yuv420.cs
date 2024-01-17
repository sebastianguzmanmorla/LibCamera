using LibCamera.Helpers;
using LibCamera.Settings.Enumerations;
using System.Text.Json.Serialization;

namespace LibCamera.Settings.Codecs;

/// <summary>
/// Yuv420 Video Settings.
/// </summary>
[JsonConverter(typeof(VideoSettingsConverter<Yuv420>))]
public class Yuv420 : VideoSettings
{
    /// <summary>
    /// Will use the YUV420 codec.
    /// </summary>
    public override Codec Codec => Codec.Yuv420;
}