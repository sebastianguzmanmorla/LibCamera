using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class WhiteBalanceGains
    (
        uint? Red = null,
        uint? Blue = null
    ) : Stringable
    {
        public uint? Red { get; set; } = Red;
        public uint? Blue { get; set; } = Blue;
        public override string ToString() => $"{Red},{Blue}";
    }
}