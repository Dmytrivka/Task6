using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enumerations;
using Task2.Utility;

namespace Task2
{
    public abstract class Auto
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public Colors Color { get; private set; }
        public Guid Vin { get; private set; }
        public FuelTypes Fuel { get; private set; }
        public uint MaxSpeed { get; private set; }
        public double Horsepowers { get; private set; }
        public double EngineCapacity { get; private set; }

        public Auto(string _brand, string _model, Colors _color, FuelTypes _fuel, uint _max_speed, double _horsepowers, double _engineCapacity)
        {
            this.Brand = _brand;
            this.Model = _model;
            this.Color = _color;
            this.Vin = Guid.NewGuid();
            this.Fuel = _fuel;
            this.MaxSpeed = _max_speed;
            this.Horsepowers = _horsepowers;
            this.EngineCapacity = _engineCapacity;
        }

        public virtual double FindBreakdownFuel(double average_speed)
        {

            var watts = Utils.HpsToWatt(this.Horsepowers);
            var distance = Utils.KilometersToMeters(1);
            var speed = Utils.KilometersPerHourToMetersPerSecond(average_speed);
            var ece = Utils.GetEceByFuelType(this.Fuel);
            var result = watts * distance / (speed * ece * Utils.benzinHeatOfCombustion);
            return result;
        }

        public override string ToString()
        {
            return string.Format(
                $"brand : {Brand}\n" +
                $"model : {Model}\n" +
                $"color : {Enum.GetName(typeof(Colors), Color)}\n" +
                $"fuel : {Enum.GetName(typeof(FuelTypes), Fuel)}\n" +
                $"max speed : {MaxSpeed}\n" +
                $"horse powers : {Horsepowers}\n" +
                $"motor capactiy : {EngineCapacity}\n");
        }
    }
}
