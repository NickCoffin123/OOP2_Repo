using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteSettings
{
    internal class PlayerProfile
    {
        // Unique identifier for the profile
        public string ProfileName { get; set; }

        // Game settings for the profile
        public GameSettings Settings { get; set; }

        // Constructor
        public PlayerProfile(string profileName, GameSettings settings)
        {
            ProfileName = profileName;
            Settings = settings;
        }

        // Method to build a string output for the profile
        public string BuildProfileString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Profile Name: {ProfileName}");
            output.AppendLine(Settings.BuildSettingsString()); // Delegate to GameSettings
            return output.ToString();
        }
    }
}
