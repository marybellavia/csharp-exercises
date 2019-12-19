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

        public MenuItem(string name)
            : this(name, null, 10.99, null, DateTime.Now) { }

        public string IsNew()
        {
            DateTime notNewDate = new DateTime(2019, 11, 19, 0, 0, 0);
            int result = DateTime.Compare(this.DateAdded, notNewDate);

            if (result >= 0)
            {
                return "new";
            }
            else
            {
                return "old";
            }
        }

        public override string ToString()
        {
            //string turd = $"***** \nName: {Name} \nDescription: {Description} \n" +
            //    $"Price: {Price} \n*****";
            string turd = $"{Name}";
            return turd;
        }

        public override bool Equals(object obj)
        {
            bool compare = false;
            MenuItem itemObj = obj as MenuItem;

            if (obj == null
                || (obj.GetType() != this.GetType()))
            {
                return false;
            }

            if (this.Name == itemObj.Name
                && this.Description == itemObj.Description)
            {
                compare = true;
            }

            return compare;
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
            if (items == null)
            {
                this.Items = new List<MenuItem>();
            }
            else
            {
                this.Items = items;
            }
            this.LastUpdated = lastUpdated;
        }

        public void AddMenuItem(MenuItem item)
        {
            if (item == null)
            {
                return;
            }
            Items.Add(item);
            LastUpdated = DateTime.Now;
        }

        public void RemoveMenuItems(MenuItem item)
        {
            if (item == null)
            {
                return;
            }
            Items.Remove(item);
            LastUpdated = DateTime.Now;
        }

        public override string ToString()
        { 
            string menuList = "";

            foreach (object item in Items)
            {
                if (Items[Items.Count -1] == item)
                {
                    menuList += $"{item}.";
                }
                else
                {
                    menuList += $"{item}, ";
                }
            }
            string turd = $"***** \nRestaurant Name: {Name} \nMenu Items: {menuList} \n" +
                $"Menu Last Updated: {LastUpdated} \n*****";
            return turd;
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
                DateTime.Now
                );
         
            MenuItem bananasfoster = new MenuItem(
                "Bananas Foster",
                "Better than a split",
                8.99,
                new List<string>() { "dessert", "lunch", "dinner"},
                new DateTime(2019, 4, 13, 0, 0, 0));


            Menu pastaHouse = new Menu(
                "Pasta House",
                null,
                DateTime.Now);

            pastaHouse.AddMenuItem(pasta);
            pastaHouse.AddMenuItem(bananasfoster);

            Console.WriteLine(bananasfoster.IsNew());
            Console.WriteLine(pasta.IsNew());

            Console.WriteLine(bananasfoster.ToString());

            Console.WriteLine(pastaHouse.ToString());


            //Console.WriteLine($"Restaurant name: {pastaHouse.Name}");

            //Console.WriteLine($"{bananasfoster.Name} is {bananasfoster.Price}");

            ////pastaHouse.Items[1].Price = 11.99;

            //Console.WriteLine($"{bananasfoster.Name} is {bananasfoster.Price}");

            //Console.WriteLine("Hello World!");

            //Console.WriteLine(bananasfoster.DateAdded);


        }
    }
}
