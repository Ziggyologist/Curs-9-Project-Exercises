// Sa se sorteze un catalog pentru vehicule. Obiectele trebuie sa continua cel putin informatii despre marca,model, an fabricatie, numar de kilometri si pret de vanzare. Elementele trebuie sa poata fi sortate si afisate dupa pret, an sau numarul de kilometri.
// numarul 8
using ITSchool.AppUtilities;
namespace App16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Application16 app = new Application16();
            app.Launch();
        }
    }

    public class Application16 : ApplicationBase
    {
        public Application16()
        {
            Cerinta = "Sa se sorteze un catalog pentru vehicule. Obiectele trebuie sa continua cel putin informatii despre marca,model, an fabricatie, numar de kilometri si pret de vanzare. Elementele trebuie sa poata fi sortate si afisate dupa pret, an sau numarul de kilometri.";
        }
        public override void Launch()
        {
            Catalog CatalogDecember = new Catalog();
            CatalogDecember.Vehicles.Add(new Vehicle("Chevrolet", "Aveo", 2010, 153000, 1700));
            CatalogDecember.Vehicles.Add(new Vehicle("Renault", "Megane", 2012, 175000, 4800));
            CatalogDecember.Vehicles.Add(new Vehicle("Volkswagen", "Polo", 2011, 120000, 3000));
            CatalogDecember.Vehicles.Add(new Vehicle("Opel", "Corsa", 2004, 180000, 3200));
            CatalogDecember.Vehicles.Add(new Vehicle("Opel", "Zafira", 1999, 2450000, 500));
            CatalogDecember.Vehicles.Add(new Vehicle("Mercedes", "GLA", 2020, 20000, 38280));
            CatalogDecember.Vehicles.Add(new Vehicle("Seat", "Leon", 2024, 100, 27000));
            CatalogDecember.Vehicles.Add(new Vehicle("Chevrolet", "Amaro", 2020, 60000, 35000));

            Console.WriteLine("--------- DEFAULT");
            CatalogDecember.ShowAllCars();
            CatalogDecember.SortByPrice(true);
            Console.WriteLine("--------- PRICE");
            CatalogDecember.ShowAllCars();
            Console.WriteLine("--------- YEAR");
            CatalogDecember.SortByYear(false);
            CatalogDecember.ShowAllCars();
            Console.WriteLine("--------- KM");
            CatalogDecember.SortByKm(false);
            CatalogDecember.ShowAllCars();
            Console.WriteLine("--------- KM");
            CatalogDecember.SortByKm(false);
            CatalogDecember.ShowAllCars();
            Console.WriteLine("--------- BRAND");
            List<Vehicle> filteredList = CatalogDecember.FilterByBrand("opel");
            Catalog.ShowAllCarsFromCollection(filteredList);
        }
    }
}