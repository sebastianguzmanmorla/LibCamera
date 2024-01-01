using LibCamera.Settings.Enumerations;

namespace LibCamera.Settings.Codecs
{
    public class Yuv420 : VideoSettings, ICodec
    {
        public Codec Codec => Codec.Yuv420;
    }
}