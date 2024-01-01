namespace LibCamera.Settings.Records
{
    public record Resolution(uint Width, uint Height, double Fps, Crop Crop): Size(Width, Height);
}