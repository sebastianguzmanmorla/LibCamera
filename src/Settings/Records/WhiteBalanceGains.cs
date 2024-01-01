namespace LibCamera.Settings.Records
{
    public record WhiteBalanceGains(uint Red, uint Blue)
    {
        public override string ToString() => $"{Red},{Blue}";
    }
}