using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11DemoA.Classes
{
    public class Car : Vehicle
    {

        public string BodyType {  get; set; }
        public int NumDoors {  get; set; }

        public Car() : base() { }

        public Car(int vin, string make, string model, int yearManufature, 
            Color colour, string bodyType, int numDoors) : base(vin, make, model, yearManufature, colour)
        {
            BodyType = bodyType;
            NumDoors = numDoors;
        }

        public override string ToString()
        {
            return base.ToString() + $" {BodyType}";
        }
    }
}
