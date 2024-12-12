/* 
 * Nick Coffin - 100555045
 * Final Assignment - AI in programming
 * December 2024
 * Utilities file
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Classes
{
    /// <summary>
    /// Mostly taken from Chat GPT, I changed things like float to double becuse of some issues I was having
    /// Overall it works okay but I really don't like trying to use AI this way.
    /// Usually better to have more of an idea of what I want so it doesn't have to try completely on it's own
    /// It was better here than on the workout class file or the forms.
    /// </summary>
    public static class Utilities
    {
        public static double CalculateBMI(double weight, double height)
        {
            if (height <= 0) throw new ArgumentException("Height must be greater than zero.");
            return Math.Round(weight / (height * height)); // Assuming height is in meters
        }
    }
}
