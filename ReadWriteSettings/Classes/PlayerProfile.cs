using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteSettings
{
    internal class PlayerProfile
    {
        #region Properties

        public string saveName { get; set; }
        public GameSettings Settings { get; set; }


        #endregion

        #region Constructors

        public PlayerProfile(string playerName)
        {
            saveName = playerName;
            Settings = new GameSettings();
        }

        #endregion

        #region Custom Methods

        /// <summary>
        /// Builds a string representation of the player's profile and settings.
        /// </summary>
        /// <returns>A formatted string ready for writing to a file.</returns>
        public string BuildProfileOutput()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Input Device: {Settings.InputDevice}");
            sb.AppendLine($"Auto Jump: {Settings.AutoJump}");
            sb.AppendLine($"Mouse Sensitivity: {Settings.MouseSensitivity}");
            sb.AppendLine($"Controller Sensitivity: {Settings.ConstollerSensitivity}");
            sb.AppendLine($"Invert Y-Axis: {Settings.InvertYAxis}");
            sb.AppendLine($"Brightness: {Settings.Brightness}");
            sb.AppendLine($"Fancy Graphics: {Settings.FancyGraphics}");
            sb.AppendLine($"VSync: {Settings.VSync}");
            sb.AppendLine($"Full Screen: {Settings.FullScreen}");
            sb.AppendLine($"Render Distance: {Settings.RenderDistance}");
            sb.AppendLine($"Field of View: {Settings.FieldOfView}");
            sb.AppendLine($"Ray Tracing: {Settings.RayTracing}");
            sb.AppendLine($"Upscaling: {Settings.Upscaling}");
            sb.AppendLine($"Music Volume: {Settings.Music}");
            sb.AppendLine($"Sound Volume: {Settings.Sound}");
            sb.AppendLine($"HUD Transparency: {Settings.HUDDTransparency}");
            sb.AppendLine($"Show Coordinates: {Settings.ShowCoordinates}");
            sb.AppendLine($"Camera Perspective: {Settings.CameraPerspective}");

            return sb.ToString();
        }


        #endregion
    }
}

