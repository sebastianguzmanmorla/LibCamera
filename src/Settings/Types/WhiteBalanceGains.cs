using LibCamera.Helpers;

namespace LibCamera.Settings.Types
{
    public class WhiteBalanceGains : Stringable
    {
        public WhiteBalanceGains()
        {
        }

        public WhiteBalanceGains
        (
            uint? Red = null,
            uint? Blue = null
        )
        {
            this.Red = Red;
            this.Blue = Blue;
        }

        public uint? Red { get; set; }
        public uint? Blue { get; set; }
        public override string ToString() => $"{Red},{Blue}";
    }
}