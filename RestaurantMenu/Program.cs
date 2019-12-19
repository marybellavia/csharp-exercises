using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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

        public bool IsNew(DateTime fromWhen)
        {
            if (DateTime.Compare(fromWhen, DateAdded) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string turd = $"*****\n{Name} - {Description} \nPrice: ${Price} \nCategories: {String.Join(", ", Category)} \n****";

            return turd;
        }

        public override bool Equals(object obj) 
        {
            MenuItem itemObj;

            if (obj == null
                || (obj.GetType() != this.GetType()))
            {
                return false;
            }

            itemObj = obj as MenuItem;

            return (this.Name == itemObj.Name
                && this.Description == itemObj.Description);
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

        public MenuItem GetNewestItem()
        {
            MenuItem first = Items.OrderByDescending(x => x.DateAdded).FirstOrDefault();
            return first;
        }

        public override string ToString()
        { 
            string menuList = "";

            foreach (MenuItem item in Items)
            {
                if (Items[Items.Count - 1] == item)
                {
                    menuList += $"{item.Name}.";
                }
                else
                {
                    menuList += $"{item.Name}, ";
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
                new DateTime(2019, 12,16, 0, 0, 0));

            DateTime timeTime = DateTime.Now;

            pastaHouse.AddMenuItem(pasta);
            pastaHouse.AddMenuItem(bananasfoster);

            Console.WriteLine(bananasfoster.IsNew(timeTime));
            Console.WriteLine(pasta.IsNew(timeTime));

            Console.WriteLine(bananasfoster.ToString()); 

            Console.WriteLine(pastaHouse.ToString());

            Console.WriteLine(pastaHouse.GetNewestItem());

            //Console.WriteLine($"Restaurant name: {pastaHouse.Name}");

            //Console.WriteLine($"{bananasfoster.Name} is {bananasfoster.Price}");

            ////pastaHouse.Items[1].Price = 11.99;

            //Console.WriteLine($"{bananasfoster.Name} is {bananasfoster.Price}");

            //Console.WriteLine("Hello World!");

            //Console.WriteLine(bananasfoster.DateAdded);


        }
    }
}
