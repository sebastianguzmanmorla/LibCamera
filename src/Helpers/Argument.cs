namespace LibCamera.Helpers;

/// <summary>
/// An attribute to mark a property as an argument to add in start info.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ArgumentAttribute(string Argument) : Attribute
{
    /// <summary>
    /// The argument.
    /// </summary>
    public string Argument { get; private set; } = Argument;
}