namespace LibCamera.Settings.Types
{
    public class Camera
    (
        uint? Id = null,
        string? Name = null,
        uint? Width = null,
        uint? Height = null,
        string? Path = null
    )
    {
        public uint? Id { get; set; } = Id;
        public string? Name { get; set; } = Name;
        public uint? Width { get; set; } = Width;
        public uint? Height { get; set; } = Height;
        public string? Path { get; set; } = Path;
        public List<Mode> Modes { get; set; } = [];
    }
}