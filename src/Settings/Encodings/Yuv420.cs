using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    public class Yuv420 : StillSettings, IEncoding
    {
        public Encoding Encoding => Encoding.Yuv420;
    }
}