using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enumerations;
using Task2.Utility;

namespace Task2
{
    public class Truck : Auto
    {
        private Transmission_brand transmission_brand;

        public Truck(
            string _brand,
            string _model,
            Colors _color,
            FuelTypes _fuel,
            uint _max_speed,
            double _horsepowers,
            double _motor_capacity,
            Transmission_brand transmission_brand)
            : base(_brand, _model, _color, _fuel, _max_speed, _horsepowers, _motor_capacity)
        {
            this.transmission_brand = transmission_brand;
        }

        public override double FindBreakdownFuel(double averageSpeed)
        {
            return base.FindBreakdownFuel(averageSpeed) * TransmissionSystem.GetCoefficient(transmission_brand);
        }
    }
}
