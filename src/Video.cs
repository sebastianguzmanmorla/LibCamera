using LibCamera.Settings;
using LibCamera.Settings.Types;
using System.Diagnostics;

namespace LibCamera
{
    public class Video : ListCameras
    {
        public override string Executable => "libcamera-vid";

        private ProcessStartInfo ProcessStartInfo(VideoSettings settings) => new()
        {
            FileName = Executable,
            Arguments = settings.ToString(),
            RedirectStandardInput = true,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            UseShellExecute = false
        };

        private static Video Instance { get; } = new Video();

        public static ProcessStartInfo CaptureStartInfo(VideoSettings settings) => Instance.ProcessStartInfo(settings);

        public static async Task<List<Camera>?> ListCameras() => await Instance.List();
    }
}
