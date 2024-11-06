using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week09DemoB
{
    public static class MyFiles
    {
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
