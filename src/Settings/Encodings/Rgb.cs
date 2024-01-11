using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    public class Rgb : StillSettings, IEncoding
    {
        public Encoding Encoding => Encoding.Rgb;
    }
}