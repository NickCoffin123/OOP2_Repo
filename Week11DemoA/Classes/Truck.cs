using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11DemoA.Classes
{
    public class Truck : Vehicle
    {
        public int GVW { get; set; }
        public int NumAxels { get; set; }
        public int TowingCapacity { get; set; }

        public Truck() : base() { }

        public Truck(int vin, string make, string model, int yearManufature,
            Color colour, int gVW, int numAxels, int towingCapacity) : base(vin, make, model, yearManufature, colour)
        {
            GVW = gVW;
            NumAxels = numAxels;
            TowingCapacity = towingCapacity;
        }
    }
}
