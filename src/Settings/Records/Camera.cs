namespace LibCamera.Settings.Records
{
    public record Camera(uint Id, string Name, uint Width, uint Height, string Path) : Size(Width, Height)
    {
        public List<Mode> Modes {get; init;} = [];
    }
}