using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task2;
using Task2.Enumerations;
using Task2.Utility;

class Program
{
    static void Main(string[] args)
    {

        List<Auto> automobiles = new List<Auto>
                {
                    {new Sportcar("Lamborghini","Aventador",(Colors)3,(FuelTypes)1,530,200,5.0,false)},
                    {new Truck("Zaz", "Kamaz", (Colors)2, (FuelTypes)2, 200, 300, 3.5, (Transmission_brand)2)},
                    {new Sportcar("Bugatti","Veyron",(Colors)1,(FuelTypes)1,290,310,2.0,true)},
                    {new Truck("volvo","fx23",(Colors)2,(FuelTypes)1,800,430,2,(Transmission_brand)2)},
                    {new Sportcar("nissan","gtr",(Colors)4,(FuelTypes)0,200,480,2,true)},
                    {new Sportcar("ford","mustang",(Colors)3,(FuelTypes)1,230,380,2.4,true)}
                };

        Console.WriteLine("\t\t\t The most economical \n");
        Console.WriteLine(Task.FindEconominal(automobiles, 80));

        Console.WriteLine("\t\t\t The fastest \n");
        Console.WriteLine(Task.FindFastestAuto(automobiles));

        List<Auto> sorted = Task.SortByHorsepower(automobiles);
        Console.WriteLine("\t\t\t Automobiles sorted by hourspowers \n");
        Task.Print(sorted);

        Console.ReadKey();


    }
}
