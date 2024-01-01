using LibCamera.Helpers;

namespace LibCamera.Settings.Enumerations
{
    public class Codec(string Value, string? Description = null) : Enumeration<string>(Value, Description)
    {
        public static Codec H264 => new("h264");
        public static Codec Mjpeg => new("mjpeg");
        public static Codec Yuv420 => new("yuv420");
    }
}