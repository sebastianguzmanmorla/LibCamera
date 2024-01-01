using LibCamera.Helpers;
using LibCamera.Settings.Codecs;
using LibCamera.Settings.Enumerations;
using LibCamera.Settings.Records;

namespace LibCamera.Settings
{
    public class VideoSettings : Arguments
    {
        public static VideoSettings Default(
            uint Camera = 0,
            uint Width = 1280,
            uint Height = 720,
            uint Timeout = 0,
            bool HFlip = true,
            bool VFlip = true,
            string? Output = null
        ) => new()
        {
            Camera = Camera,
            Width = Width,
            Height = Height,
            Timeout = Timeout,
            HFlip = HFlip,
            VFlip = VFlip,
            Output = Output
        };

        public static VideoSettings H264(
            uint Camera = 0,
            uint Width = 1280,
            uint Height = 720,
            uint Timeout = 0,
            bool HFlip = true,
            bool VFlip = true,
            string? Output = null
        ) => new H264()
        {
            Camera = Camera,
            Width = Width,
            Height = Height,
            Timeout = Timeout,
            HFlip = HFlip,
            VFlip = VFlip,
            Output = Output
        };

        public static VideoSettings Mjpeg(
            uint Camera = 0,
            uint Width = 1280,
            uint Height = 720,
            uint Timeout = 0,
            bool HFlip = true,
            bool VFlip = true,
            string? Output = null
        ) => new Mjpeg()
        {
           Camera = Camera,
            Width = Width,
            Height = Height,
            Timeout = Timeout,
            HFlip = HFlip,
            VFlip = VFlip,
            Output = Output
        };

        public static VideoSettings Yuv420(
            uint Camera = 0,
            uint Width = 1280,
            uint Height = 720,
            uint Timeout = 0,
            bool HFlip = true,
            bool VFlip = true,
            string? Output = null
        ) => new Yuv420()
        {
            Camera = Camera,
            Width = Width,
            Height = Height,
            Timeout = Timeout,
            HFlip = HFlip,
            VFlip = VFlip,
            Output = Output
        };

        /// <summary>
        /// Chooses the camera to use. To list the available indexes
        /// </summary>
        [Argument("--camera")]
        public uint? Camera { get; set; } = null;

        /// <summary>
        /// Set verbosity level
        /// </summary>
        [Argument("--verbose")]
        public VerboseLevel? Verbose { get; set; } = null;

        /// <summary>
        /// Set the width of the image
        /// </summary>
        [Argument("--width")]
        public uint? Width { get; set; } = null;

        /// <summary>
        /// Set the height of the image
        /// </summary>
        [Argument("--height")]
        public uint? Height { get; set; } = null;

        /// <summary>
        /// Time (in ms) for which program runs
        /// </summary>
        [Argument("--timeout")]
        public uint? Timeout { get; set; } = null;

        /// <summary>
        /// Force use of full resolution raw frames
        /// </summary>
        [Argument("--rawfull")]
        public bool? Rawfull { get; set; } = null;

        /// <summary>
        /// Request a horizontal flip transform
        /// </summary>
        [Argument("--hflip")]
        public bool? HFlip { get; set; } = null;

        /// <summary>
        /// Request a vertical flip transform
        /// </summary>
        [Argument("--vflip")]
        public bool? VFlip { get; set; } = null;

        /// <summary>
        /// Set a fixed shutter speed in microseconds
        /// </summary>
        [Argument("--shutter")]
        public uint? Shutter { get; set; } = null;

        /// <summary>
        /// Set a fixed gain value
        /// </summary>
        [Argument("--gain")]
        public uint? Gain { get; set; } = null;

        /// <summary>
        /// Set the metering mode
        /// </summary>
        [Argument("--metering")]
        public Metering? Metering { get; set; } = null;

        /// <summary>
        /// Set the exposure mode
        /// </summary>
        [Argument("--exposure")]
        public Exposure? Exposure { get; set; } = null;

        /// <summary>
        /// Set the EV exposure compensation, where 0 = no change
        /// </summary>
        [Argument("--ev")]
        public uint? ExposureCompensation { get; set; } = null;

        /// <summary>
        /// Set the AWB mode
        /// </summary>
        [Argument("--awb")]
        public WhiteBalance? WhiteBalance { get; set; } = null;

        /// <summary>
        /// Set explict red and blue gains
        /// </summary>
        [Argument("--awbgains")]
        public WhiteBalanceGains? WhiteBalanceGains { get; set; } = null;

        /// <summary>
        /// Adjust the brightness of the output images, in the range -1.0 to 1.0
        /// </summary>
        [Argument("--brightness")]
        public decimal? Brightness
        {
            get => _brightness;
            set => _brightness = value is null ? null : decimal.Clamp(value.Value, -1, 1);
        }
        private decimal? _brightness = null;

        /// <summary>
        /// Adjust the contrast of the output image, where 1.0 = normal contrast
        /// </summary>
        [Argument("--contrast")]
        public decimal? Contrast
        {
            get => _contrast;
            set => _contrast = value is null ? null : decimal.Clamp(value.Value, 0, 1);
        }
        private decimal? _contrast = null;

        /// <summary>
        /// Adjust the saturation of the output image, where 1.0 = normal saturation
        /// </summary>
        [Argument("--saturation")]
        public decimal? Saturation
        {
            get => _saturation;
            set => _saturation = value is null ? null : decimal.Clamp(value.Value, 0, 1);
        }
        private decimal? _saturation = null;

        /// <summary>
        /// Adjust the sharpness of the output image, where 1.0 = normal sharpness
        /// </summary>
        [Argument("--sharpness")]
        public decimal? Sharpness
        {
            get => _sharpness;
            set => _sharpness = value is null ? null : decimal.Clamp(value.Value, 0, 1);
        }
        private decimal? _sharpness = null;

        /// <summary>
        /// Set the fixed framerate for preview and video modes
        /// </summary>
        [Argument("--framerate")]
        public uint? Framerate { get; set; } = null;

        /// <summary>
        /// Sets the Denoise operating mode
        /// </summary>
        [Argument("--denoise")]
        public Denoise? Denoise { get; set; } = null;

        /// <summary>
        /// Control to set the mode of the AF (autofocus) algorithm
        /// </summary>
        [Argument("--autofocus-mode")]
        public AutofocusMode? AutofocusMode { get; set; } = null;

        /// <summary>
        /// Set the range of focus distances that is scanned
        /// </summary>
        [Argument("--autofocus-range")]
        public AutofocusRange? AutofocusRange { get; set; } = null;

        /// <summary>
        /// Control that determines whether the AF algorithm is to move the lens as quickly as possible or more steadily
        /// </summary>
        [Argument("--autofocus-speed")]
        public AutofocusSpeed? AutofocusSpeed { get; set; } = null;

        /// <summary>
        /// Sets AfMetering to  AfMeteringWindows an set region used
        /// </summary>
        [Argument("--autofocus-window")]
        public Crop? AutofocusWindow { get; set; } = null;

        /// <summary>
        /// Set the lens to a particular focus position, expressed as a reciprocal distance (0 moves the lens to infinity)
        /// </summary>
        [Argument("--lens-position")]
        public decimal? LensPosition { get; set; } = null;

        /// <summary>
        /// High Dynamic Range, where supported
        /// </summary>
        [Argument("--hdr")]
        public bool? Hdr { get; set; } = null;

        /// <summary>
        /// Output filename or '-' for stdout
        /// </summary>
        [Argument("--output")]
        public string? Output { get; set; } = null;
    }
}