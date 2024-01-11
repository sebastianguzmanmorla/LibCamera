using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    public class Bmp : StillSettings, IEncoding
    {
        public Encoding Encoding => Encoding.Bmp;
    }
}