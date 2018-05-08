using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Enumerations
{
    public enum Colors { red = 1, blue, yellow, green, white, black, brown, pink };
    public enum FuelTypes { petrol = 1, Diesel }
    public enum Motor_brand { ABB = 1, AMETEK, ARK, Asmo, Danaher, Emerson, Nidec }
    public enum Transmission_brand { TCI = 1, Hughes, Getrag, Ford, AFE, ATP }



    public static class Motor_system
    {

        public static double GetCoefficiente(Motor_brand brand)
        {
            double result = 1;
            switch (brand)
            {
                case Motor_brand.ABB:
                    {
                        result = 1.11;
                        break;
                    }
                case Motor_brand.ARK:
                    {
                        result = 1.21;
                        break;
                    }
                case Motor_brand.AMETEK:
                    {
                        result = 1.33;
                        break;
                    }
                case Motor_brand.Asmo:
                    {
                        result = 1.48;
                        break;
                    }
                case Motor_brand.Danaher:
                    {
                        result = 1.53;
                        break;
                    }
                case Motor_brand.Emerson:
                    {
                        result = 1.612;
                        break;
                    }
                case Motor_brand.Nidec:
                    {
                        result = 1.82;
                        break;
                    }
            }
            return result;
        }
    }


    public static class TransmissionSystem
    {

        public static double GetCoefficient(Transmission_brand brand)
        {
            double result = 1;
            switch (brand)
            {
                case Transmission_brand.AFE:
                    {
                        result = 1.1234;
                        break;
                    }
                case Transmission_brand.ATP:
                    {
                        result = 1.23131;
                        break;
                    }
                case Transmission_brand.Ford:
                    {
                        result = 1.3457;
                        break;
                    }
                case Transmission_brand.Getrag:
                    {
                        result = 1.5588;
                        break;
                    }
                case Transmission_brand.Hughes:
                    {
                        result = 1.6193;
                        break;
                    }
                case Transmission_brand.TCI:
                    {
                        result = 1.6891;
                        break;
                    }
            }
            return result;
        }
    }
}