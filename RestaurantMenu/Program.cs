using System;
using System.Collections.Generic;
using System.Globalization;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public List<string> Category { get; set; }
        public DateTime DateAdded { get; set; }

        public MenuItem(string name,
            string description,
            double price,
            List<string> category,
            DateTime dateAdded)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Category = category;
            this.DateAdded = dateAdded;
        }
    }

    public class Menu
    {
        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(string name, List<MenuItem> items,
            DateTime lastUpdated)
        {
            this.Name = name;
            this.Items = items;
            this.LastUpdated = lastUpdated;
            
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

            MenuItem pasta = new MenuItem(
                "Pasta Carbonara",
                "The one with the peas",
                10.99,
                new List<string>() { "entree", "lunch", "dinner", "Monday Special"},
                new DateTime()
                );
         
            MenuItem bananasfoster = new MenuItem(
                "Bananas Foster",
                "Better than a split",
                8.99,
                new List<string>() { "dessert", "lunch", "dinner"},
                DateTime.Today);


            Menu pastaHouse = new Menu(
                "Pasta House",
                new List<MenuItem>() { pasta, bananasfoster },
                DateTime.Today);

            Console.WriteLine($"Restaurant name: {pastaHouse.Name}");

            Console.WriteLine($"{bananasfoster.Name} is {bananasfoster.Price}");

            pastaHouse.Items[1].Price = 11.99;

            Console.WriteLine($"{bananasfoster.Name} is {bananasfoster.Price}");

            Console.WriteLine("Hello World!");
        }
    }
}
