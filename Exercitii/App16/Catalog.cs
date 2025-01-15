using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16
{
    public class Catalog
    {
        public List<Vehicle> Vehicles;
        public Catalog()
        {
            Vehicles = new List<Vehicle>();
        }


        public List<Vehicle> SortBy(string sorterString = "", int sorterInt = 0)
        {
            List<Vehicle> SortedBySomething = new List<Vehicle>();
            return SortedBySomething;
        }
        public void SortByPrice(bool orderByDescending )
        {
            if (orderByDescending == false) 
            {
                Vehicles = Vehicles.OrderBy(x => x.Price).ToList();
            }
            else 
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Price).ToList();
            }
        }
        public void SortByYear(bool orderByDescending) 
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Year).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Year).ToList();
            }
        }
        public void SortByKm(bool orderByDescending) 
        {
            if (orderByDescending == false)
            {
                Vehicles = Vehicles.OrderBy(x => x.Km).ToList();
            }
            else
            {
                Vehicles = Vehicles.OrderByDescending(x => x.Km).ToList();
            }
        }
        public List<Vehicle> FilterByBrand(string brand)
        {
            List<Vehicle> SortedArray = new List<Vehicle>();
            SortedArray = Vehicles.FindAll(item => item.Brand.ToLower() == brand.ToLower());
            return SortedArray;
        }
        public void ShowAllCars() 
        {
            Console.WriteLine("In catalog avem urmatoarele:"); 
            for (int i = 0; i < Vehicles.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Vehicles[i].GetData()}.");
            }
        }

        public static void ShowAllCarsFromCollection(List<Vehicle> collection)
        {
            Console.WriteLine("In catalog avem urmatoarele:");
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {collection[i].GetData()}.");
            }
        }
    }
}
