using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteSettings
{
    internal class GameSettings
    {
        #region Global Variables
        #endregion

        #region Properties

        public Defaults.InputDeviceOptions InputDevice { get; set; } = Defaults.DefaultInputDevice;
        public bool AutoJump { get; set; } = Defaults.DefaultAutoJump;
        public int MouseSensitivity { get; set; } = Defaults.DefaultMouseSenitivity;
        public int ConstollerSensitivity { get; set; } = Defaults.DefaultControllerSensitivity;
        public bool InvertYAxis { get; set; } = Defaults.DefaultInvertYAxis;

        public int Brightness { get; set; } = Defaults.DefaultBrightness;
        public bool FancyGraphics { get; set; } = Defaults.DefaultFancyGraphics;
        public bool VSync { get; set; } = Defaults.DefaultVSync;
        public bool FullScreen { get; set; } = Defaults.DefaultFullScreen;
        public int RenderDistance { get; set; } = Defaults.DefaultRenderDistance;
        public int FieldOfView { get; set; } = Defaults.DefaultFieldOfView;
        public bool RayTracing { get; set; } = Defaults.DefaultRayTracing;
        public bool Upscaling { get; set; } = Defaults.DefaultUpscaling;

        #endregion

        #region Constructors
        #endregion

        #region Custom Methods
        #endregion

        #region Static Methods
        #endregion
    }
}