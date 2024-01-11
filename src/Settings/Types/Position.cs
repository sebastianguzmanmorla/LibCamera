namespace LibCamera.Settings.Types
{
    public class Position
    {
        public Position()
        {
        }

        public Position
        (
            uint? X = null,
            uint? Y = null
        )
        {
            this.X = X;
            this.Y = Y;
        }

        public uint? X { get; set; }
        public uint? Y { get; set; }
    }
}