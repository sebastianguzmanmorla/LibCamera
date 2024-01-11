using LibCamera.Settings;
using LibCamera.Settings.Types;
using System.Diagnostics;

namespace LibCamera
{
    public class Still : Hello
    {
        protected override string Executable => "libcamera-still";

        private static Still Instance { get; } = new Still();

        public static ProcessStartInfo CaptureStartInfo(StillSettings settings) => Instance.StartInfo(settings);

        public static new async Task<List<Camera>?> ListCameras() => await Instance.List();
    }
}
