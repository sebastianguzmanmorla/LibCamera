namespace LibCamera.Helpers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ArgumentAttribute(string Argument) : Attribute
    {
        public string Argument { get; private set; } = Argument;
    }
}