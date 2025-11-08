using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Transportation_System
{
    internal class Bus : Vehicle
    {
        public int SeatingCapacity { get; set; }

        public Bus(decimal maxSpeed, int seatingCapacity) : base(maxSpeed)
        {
            SeatingCapacity = seatingCapacity;
        }

        public override string ShowDetails()
        {
            return $"Bus Max Speed: {MaxSpeed} km/h\nSeating Capacity: {SeatingCapacity} passengers";
        }
    }
}
