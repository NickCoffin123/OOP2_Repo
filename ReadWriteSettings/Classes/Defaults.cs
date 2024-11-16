/* Nick Coffin - 100555045.
* OOP - Assignment 3 Character Sheet.
* November 12, 2024.
* Defaults class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteSettings
{
    public class Defaults
    {

        #region Enums
        public enum InputDeviceOptions
        {
            Keyboard,
            Controller,
            Touch
        }

        public enum CameraPerspective
        {
            FirstPerson,
            ThirdPersonFront,
            ThirdPersonBack

        }
        #endregion

        #region Constants

        public const InputDeviceOptions DefaultInputDevice = InputDeviceOptions.Keyboard;
        public const bool DefaultAutoJump = true;
        public const int DefaultMouseSenitivity = 50;
        public const int DefaultControllerSensitivity = 50;
        public const bool DefaultInvertYAxis = false;

        public const int DefaultBrightness = 50;
        public const bool DefaultFancyGraphics = true;
        public const bool DefaultVSync = true;
        public const bool DefaultFullScreen = false;
        public const int DefaultRenderDistance = 16;
        public const int DefaultFieldOfView = 64;
        public const bool DefaultRayTracing = false;
        public const bool DefaultUpscaling = false;

        public const int DefaultMusic = 100;
        public const int DefaultSound = 100;

        public const int DefaultHUDDTransparency = 100;
        public const bool DefaultShowCoordinates = false;
        public const CameraPerspective DefaultCameraPerspective = CameraPerspective.FirstPerson;



        #endregion
    }
}
