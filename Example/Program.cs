using System.Diagnostics;
using LibCamera.Settings;
using LibCamera.Settings.Enumerations;
using LibCamera.Settings.Codecs;
using LibCamera.Settings.Types;
using Newtonsoft.Json;
using LibCamera.Settings.Encodings;

List<Camera>? Cameras = await LibCamera.Video.ListCameras();

if (Cameras is null)
{
    Console.Error.WriteLine("Failed to list cameras");

    return 1;
}

Console.WriteLine("Found {0} camera(s)", Cameras.Count);

if (Cameras.Count == 0)
{
    return 1;
}

Console.WriteLine(JsonConvert.SerializeObject(Cameras, Formatting.Indented));

Console.WriteLine("Select camera:");

Camera? Camera = null;

while (true)
{
    string? Input = Console.ReadLine();

    if (Input != null && int.TryParse(Input, out int Id) && Id >= 0 && Cameras.FirstOrDefault(c => c.Id == Id) is Camera SelectedCamera)
    {
        Camera = SelectedCamera;

        break;
    }

    Console.WriteLine("Please enter a valid camera ID");
}

if (Camera is null)
{
    Console.Error.WriteLine("Failed to select camera");

    return 1;
}

StillSettings stillSettings = new Jpg()
{
    Camera = Camera.Id,
    Width = 1280,
    Height = 720,
    Timeout = 0,
    HFlip = true,
    VFlip = true,
    WhiteBalance = WhiteBalance.Incandescent,
    Mode = Camera.Modes.FirstOrDefault(), // Obtained first mode but you can select any mode
    Output = "test.jpg"
};

ProcessStartInfo StillStartInfo = LibCamera.Still.CaptureStartInfo(stillSettings);

Process? StillProcess = null;

try
{
    StillProcess = Process.Start(StillStartInfo);
}
catch (Exception ex)
{
    Console.Error.WriteLine("Failed to start process: {0}", ex.Message);
}

if (StillProcess is null)
{
    return 1;
}

Console.WriteLine("Started process with ID {0}", StillProcess.Id);

if (StillProcess.HasExited && StillProcess.ExitCode != 0)
{
    Console.Error.WriteLine("Process exited with code {0}", StillProcess.ExitCode);

    return 1;
}

VideoSettings videoSettings = new H264()
{
    Camera = Camera.Id,
    Width = 1280,
    Height = 720,
    Timeout = 0,
    HFlip = true,
    VFlip = true,
    WhiteBalance = WhiteBalance.Incandescent,
    Mode = Camera.Modes.FirstOrDefault(), // Obtained first mode but you can select any mode
    Output = "test.h264"
};

ProcessStartInfo CaptureStartInfo = LibCamera.Video.CaptureStartInfo(videoSettings);

Process? CaptureProcess = null;

try
{
    CaptureProcess = Process.Start(CaptureStartInfo);
}
catch (Exception ex)
{
    Console.Error.WriteLine("Failed to start process: {0}", ex.Message);
}

if (CaptureProcess is null)
{
    return 1;
}

Console.WriteLine("Started process with ID {0}", CaptureProcess.Id);

Console.WriteLine("Press any key to stop recording");

Console.ReadKey();

if (CaptureProcess.HasExited)
{
    Console.Error.WriteLine("Process has already exited");

    return 1;
}

try
{
    CaptureProcess.Kill();
}
catch (Exception ex)
{
    Console.Error.WriteLine("Failed to kill process: {0}", ex.Message);

    return 1;
}

Console.WriteLine("Stopped process with ID {0}", CaptureProcess.Id);

return 0;