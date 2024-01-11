using LibCamera.Settings;
using LibCamera.Settings.Types;
using System.Diagnostics;

namespace LibCamera
{
    public class Still : ListCameras
    {
        public override string Executable => "libcamera-still";

        private ProcessStartInfo ProcessStartInfo(StillSettings settings) => new()
        {
            FileName = Executable,
            Arguments = settings.ToString(),
            RedirectStandardInput = true,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            UseShellExecute = false
        };

        private static Still Instance { get; } = new Still();

        public static ProcessStartInfo CaptureStartInfo(StillSettings settings) => Instance.ProcessStartInfo(settings);

        public static async Task<List<Camera>?> ListCameras() => await Instance.List();
    }
}
