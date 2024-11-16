/* Nick Coffin - 100555045.
 * OOP - Assignment 4 Read Write Settings.
 * November 12, 2024.
 * Tools file for project.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteSettings
{
    internal class Tools
    {
        // Method to save profile to file
        public static void SaveProfileToFile(string filePath, PlayerProfile profile)
        {
            try
            {
                string content = profile.BuildProfileString();
                File.WriteAllText(filePath, content);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied. Unable to write to the file.");
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O error occurred while saving the file.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to load profile from file
        public static string ReadFromFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found.");
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied. Unable to read the file.");
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O error occurred while reading the file.");
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
        }
    }
}
}
