using LibCamera.Helpers;
using System.Diagnostics;

namespace LibCamera
{
    public abstract class LibCamera
    {
        protected abstract string Executable { get; }

        protected ProcessStartInfo StartInfo(string arguments) => new()
        {
            FileName = Executable,
            Arguments = arguments,
            RedirectStandardInput = true,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            UseShellExecute = false
        };

        protected ProcessStartInfo StartInfo(Arguments arguments) => new()
        {
            FileName = Executable,
            Arguments = arguments.ToString(),
            RedirectStandardInput = true,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            UseShellExecute = false
        };
    }
}
