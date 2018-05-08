using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;
using Task2.Enumerations;
using Task2.Utility;
using System.Collections.Generic;

namespace UnitTestTask2
{
    namespace UnitTestTask2
    {
        [TestClass]
        public class UnitTest1
        {
            List<Auto> autos = new List<Auto>
        {
            {new Sportcar("Lamborghini", "Aventador", (Colors) 3, (FuelTypes) 1, 530, 200, 5.0, false)},
            {new Truck("Zaz", "Kamaz", (Colors) 2, (FuelTypes) 2, 200, 300, 3.5, (Transmission_brand) 2)},
            {new Sportcar("Bugatti", "Veyron", (Colors) 1, (FuelTypes) 1, 290, 310, 2.0, true)},
            {new Car("Opel", "C", (Colors) 2, (FuelTypes) 2, 100, 370, 2.2, (Motor_brand) 2)}
        };

            [TestMethod]
            public void AreEqual1()
            {
                bool expected = false;

                bool actual = autos[0].Equals(autos[1]);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void AreEqual2()
            {
                Car equal = new Car("Mazda", "C", (Colors)2, (FuelTypes)2, 100, 370, 2.2, (Motor_brand)2);
                bool expected = false;

                bool actual = autos[3].Equals(equal);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestFindBreakdownFuel()
            {
                double expected = 0.97158;
                double avSpeed = 120;

                double actual = autos[1].FindBreakdownFuel(avSpeed);

                Assert.AreNotEqual(expected, actual);
            }

            [TestMethod]
            public void FindMostEconomical()
            {
                Auto expected = autos[0];
                double avSpeed = 120;

                Auto actual = Task.FindEconominal(autos, avSpeed);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void FindFastest()
            {
                Auto expected = autos[0];

                Auto actual = Task.FindFastestAuto(autos);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestConvertKmInHourToMetrPerSec()
            {
                double kmInHour = 36;
                double expected = 10;

                double actual = Utils.KilometersPerHourToMetersPerSecond(kmInHour);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestConvertKilometresToMeters()
            {
                double meters = 10;
                double expected = 10;

                double actual = Utils.KilometersToMeters(meters);

                Assert.AreNotSame(expected, actual);
            }
        }
    }
}
