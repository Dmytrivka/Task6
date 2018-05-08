using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enumerations;

namespace Task2
{
    public class Car : Auto
    {
        private Motor_brand motor_brand;

        public Car(
            string _brand,
            string _model,
            Colors _color,
            FuelTypes _fuel,
            uint _max_speed,
            double _horsepowers,
            double _motor_capacity,
            Motor_brand _motor_brand)
            : base(_brand, _model, _color, _fuel, _max_speed, _horsepowers, _motor_capacity)
        {
            this.motor_brand = _motor_brand;
        }

        public override double FindBreakdownFuel(double averageSpeed)
        {
            return base.FindBreakdownFuel(averageSpeed) * Motor_system.GetCoefficiente(motor_brand);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"motor : {Enum.GetName(typeof(Motor_brand), this.motor_brand)}\n");
        }
    }
}
