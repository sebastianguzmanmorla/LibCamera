namespace LibCamera.Settings.Records
{
    public record Mode(string Name)
    {
        public List<Resolution> Resolutions {get; init;} = [];
    }
}