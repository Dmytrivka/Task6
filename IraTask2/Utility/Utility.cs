﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Enumerations;

namespace Task2.Utility
{
    public static class Utils
    {
        public static double wattToHp = 745.699872;
        public static double benzinHeatOfCombustion = 45000000;
        public static double eceForPetrol = 0.3;
        public static double eceForDiesel = 0.4;
        public static int metersInKilometer = 1000;
        public static int secondsInHour = 3600;

        public static double GetEceByFuelType(FuelTypes fuelType)
        {
            switch (fuelType)
            {
                case FuelTypes.Diesel:
                    {
                        return eceForDiesel;
                    }
                case FuelTypes.petrol:
                    {
                        return eceForPetrol;
                    }
            }

            return 0;
        }

        public static double KilometersPerHourToMetersPerSecond(double kilometersPerHour)
        {
            return (kilometersPerHour * metersInKilometer) / secondsInHour;
        }

        public static double KilometersToMeters(double kilometers)
        {
            return kilometers * metersInKilometer;
        }

        public static double HpsToWatt(double hps)
        {
            return hps * wattToHp;
        }
    }
}
