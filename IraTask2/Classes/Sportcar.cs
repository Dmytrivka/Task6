using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enumerations;

namespace Task2
{
    public class Sportcar : Auto
    {
        private bool nytro;

        public Sportcar(string _brand, string _model, Colors _color, FuelTypes _fuel, uint _max_speed, double _horsepowers, double _motor_capacity, bool _nytro)
            : base(_brand, _model, _color, _fuel, _max_speed, _horsepowers, _motor_capacity)
        {
            this.nytro = _nytro;
        }

        public override double FindBreakdownFuel(double averageSpeed)
        {
            double ccd_coefficient = nytro ? 2.7312 : 1;
            return base.FindBreakdownFuel(averageSpeed) * ccd_coefficient;
        }
    }
}
