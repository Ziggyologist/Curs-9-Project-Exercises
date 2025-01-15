using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16
{
    public class Vehicle
    {
        public string Brand;
        public string Model;
        public int Year;
        public int Km;
        public float Price;

        public Vehicle(string brand, string model, int year, int km, float price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Km = km; 
            Price = price;
        }
        public string GetData()
        {
            return $"Brand: {Brand}; Model: {Model}; An: {Year}; Numar km: {Km}; Pret: {Price}$.";
        }
    }
}
