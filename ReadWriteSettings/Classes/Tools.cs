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
    /// <summary>
    /// Main method for class
    /// </summary>
    internal class Tools
    {
        /// <summary>
        /// Method to write to a file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool WriteToFile(String fileName, string content)
        {
            try
            {
                //StreamWriter sw = new StreamWriter(fileName);
                //sw.Write(content);
                //sw.Close();

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(content);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error writing to file: " + ex.Message);
            }

        }

        /// <summary>
        /// Method to read from a file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string ReadFromFile(String fileName)
        {
            //StreamReader reader = new StreamReader(fileName);
            //string content = reader.ReadToEnd();
            //reader.Close();
            //return content;

            String content = String.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    content = sr.ReadToEnd();
                }

            }
            catch (FileNotFoundException ex)
            {
                throw new Exception("File not found: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading file: " + ex.Message);
            }
            finally
            {
                // Do stuff here that always has to happen.
            }
            return content;

        }
    }
}

