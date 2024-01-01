namespace LibCamera.Settings.Records
{
    public record Crop(uint X, uint Y, uint Width, uint Height)
    {
        public override string ToString() => $"{X},{Y},{Width},{Height}";
    }
}