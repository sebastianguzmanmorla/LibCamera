namespace LibCamera.Settings.Types
{
    public class Position
    (
        uint? X = null,
        uint? Y = null
    )
    {
        public Position() : this(null, null)
        {
        }

        public uint? X { get; set; } = X;
        public uint? Y { get; set; } = Y;
    }
}