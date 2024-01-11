using LibCamera.Settings;
using LibCamera.Settings.Types;
using System.Diagnostics;

namespace LibCamera
{
    public class Video : Hello
    {
        protected override string Executable => "libcamera-vid";

        private static Video Instance { get; } = new Video();

        public static ProcessStartInfo CaptureStartInfo(VideoSettings settings) => Instance.StartInfo(settings);

        public static new async Task<List<Camera>?> ListCameras() => await Instance.List();
    }
}
