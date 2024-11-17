/* Nick Coffin - 100555045.
 * OOP - Assignment 4 Read Write Settings.
 * November 12, 2024.
 * Game Settings form for project.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteSettings
{
    /// <summary>
    /// Main method for class
    /// </summary>
    [Serializable]
    public class GameSettings
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

        public int Music { get; set; } = Defaults.DefaultMusic;
        public int Sound { get; set; } = Defaults.DefaultSound;

        public int HUDDTransparency { get; set; } = Defaults.DefaultHUDDTransparency;
        public bool ShowCoordinates { get; set; } = Defaults.DefaultShowCoordinates;
        public Defaults.CameraPerspective CameraPerspective { get; set; } = Defaults.DefaultCameraPerspective;


        #endregion

        #region Constructors
        #endregion

        #region Custom Methods
        #endregion

        #region Static Methods
        #endregion
    }
}