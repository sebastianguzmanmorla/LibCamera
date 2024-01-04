using LibCamera.Settings;
using LibCamera.Settings.Types;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace LibCamera
{
    public partial class Video
    {
        public const string Executable = "libcamera-vid";

        public const string ListCamerasCommand = "--list-cameras";

        [GeneratedRegex(@"(.+) : (.+) \[(.+)x(.+)\] \((.+)\)", RegexOptions.IgnoreCase)]
        private static partial Regex CameraRegex();

        [GeneratedRegex(@"(.*)Modes: '(.+)' : (.+)", RegexOptions.IgnoreCase)]
        private static partial Regex ModeRegex();

        [GeneratedRegex(@"(.*) (.+)x(.+) \[(.+) fps - \((.+), (.+)\)\/(.+)x(.+) crop\]", RegexOptions.IgnoreCase)]
        private static partial Regex ResolutionRegex();

        public static ProcessStartInfo ListCamerasStartInfo() => new()
        {
            FileName = Executable,
            Arguments = ListCamerasCommand,
            RedirectStandardInput = true,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            UseShellExecute = false
        };

        public async static Task<List<Camera>?> ListCameras()
        {
            List<Camera> Cameras = [];

            Process? ListCamerasProcess = null;

            try
            {
                ListCamerasProcess = Process.Start(ListCamerasStartInfo());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Failed to start process: {0}", ex.Message);
            }

            if (ListCamerasProcess is null)
            {
                return null;
            }

            Camera? camera = null;
            string? modeValue = null;

            while (true)
            {
                string? Line = await ListCamerasProcess.StandardOutput.ReadLineAsync();

                if (Line is null)
                {
                    break;
                }

                bool CamaraDefinition = CameraRegex().IsMatch(Line);

                if (CamaraDefinition && camera is not null)
                {
                    Cameras.Add(camera);

                    camera = null;
                }

                if (CamaraDefinition && camera is null)
                {
                    Match cameraMatch = CameraRegex().Match(Line);

                    camera = new(
                        Id: uint.Parse(cameraMatch.Groups[1].Value),
                        Name: cameraMatch.Groups[2].Value,
                        Width: uint.Parse(cameraMatch.Groups[3].Value),
                        Height: uint.Parse(cameraMatch.Groups[4].Value),
                        Path: cameraMatch.Groups[5].Value
                    );

                    continue;
                }

                bool ModeDefinition = ModeRegex().IsMatch(Line);

                if (ModeDefinition && camera is not null && modeValue is not null)
                {
                    modeValue = null;
                }

                if (ModeDefinition && camera is not null && modeValue is null)
                {
                    Match modeMatch = ModeRegex().Match(Line);

                    modeValue = modeMatch.Groups[2].Value;
                }

                bool ResolutionDefinition = ResolutionRegex().IsMatch(Line);

                if (ResolutionDefinition && camera is not null && modeValue is not null)
                {
                    Match resolutionMatch = ResolutionRegex().Match(Line);

                    camera.Modes.Add(
                        new Mode(
                            Value: modeValue,
                            Width: uint.Parse(resolutionMatch.Groups[2].Value),
                            Height: uint.Parse(resolutionMatch.Groups[3].Value),
                            Fps: double.Parse(resolutionMatch.Groups[4].Value),
                            Crop: new(
                                X: uint.Parse(resolutionMatch.Groups[5].Value),
                                Y: uint.Parse(resolutionMatch.Groups[6].Value),
                                Width: uint.Parse(resolutionMatch.Groups[7].Value),
                                Height: uint.Parse(resolutionMatch.Groups[8].Value)
                            )
                        )
                    );
                }
            }

            if (camera is not null)
            {
                Cameras.Add(camera);
            }

            return Cameras;
        }

        public static ProcessStartInfo CaptureStartInfo(VideoSettings settings) => new()
        {
            FileName = Executable,
            Arguments = settings.ToString(),
            RedirectStandardInput = true,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            UseShellExecute = false
        };
    }
}