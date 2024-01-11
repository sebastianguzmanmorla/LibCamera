using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Encodings
{
    public class Png : StillSettings, IEncoding
    {
        public Encoding Encoding => Encoding.Png;
    }
}