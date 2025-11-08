using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Transportation_System
{
    internal class Vehicle
    {
        public decimal MaxSpeed { get; set; }

        public Vehicle(decimal maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        public virtual string ShowDetails()
        {
            return $"Vehicle Max Speed: {MaxSpeed} km/h";
        }
    }
}
