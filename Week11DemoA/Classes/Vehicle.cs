using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11DemoA.Classes


    /* 
     *          Accessibility Levels
     *          
     * Public       - Can be accessed anywhere.
     * Private      - Can be accessed from the current class.
     * Protected    - Can be accessed from current class and parent-classes.
     * Internal     - Can be accessed in the current namespace(assembly).
     */
{
    public abstract class Vehicle
    {
        public int Vin {  get; set; }
        public string Make {  get; set; }
        public string Model {  get; set; }
        public int YearManufature {  get; set; }
        public Color Colour { get; set; }

        protected Vehicle() { }

        public Vehicle(int vin, string make, string model,  int yearManufature, Color colour)
        {
            Vin = vin;
            Make = make;
            Model = model;
            YearManufature = yearManufature;
            Colour = colour;
        }

        public override string ToString()
        {
            return $"{YearManufature} {Make} {Model}";
        }




    }
}
