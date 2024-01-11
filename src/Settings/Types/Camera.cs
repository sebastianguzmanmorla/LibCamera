namespace LibCamera.Settings.Types
{
    public class Camera
    {
        public Camera()
        {
        }

        public Camera
        (
            uint? Id = null,
            string? Name = null,
            uint? Width = null,
            uint? Height = null,
            string? Path = null
        )
        {
            this.Id = Id;
            this.Name = Name;
            this.Width = Width;
            this.Height = Height;
            this.Path = Path;
        }

        public uint? Id { get; set; }
        public string? Name { get; set; }
        public uint? Width { get; set; }
        public uint? Height { get; set; }
        public string? Path { get; set; }
        public List<Mode> Modes { get; set; } = [];
    }
}