using System;
using System.Collections.Generic;

namespace JSAssignmentConsoleApp
{
    class Program
    {
        static void Main()
        {
            List<string> items = new List<string>
            {
                "Item1",
                "Item2",
                "Item3"
            };

            bool showMenu = true;
            while (showMenu){
                showMenu = MainMenu(items);
            }
        }

        private static bool MainMenu(List<string> items)
        {
            Console.WriteLine("Current items are : ");
            foreach (var i in items)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("1) Add an item");
            Console.WriteLine("2) Edit item");
            Console.WriteLine("3) Delete item");
            Console.WriteLine("4) Sort items by ascending ");
            Console.WriteLine("5) Sort items by descending ");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    checkDuplicate(items);
                    return true;
                case "2":
                    editItem(items);
                    return true;
                case "3":
                    deleteItem(items);
                    return true;
                case "4":
                    sortItems(items, choise);
                    return true;
                case "5":
                    sortItems(items, choise);
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }

            void sortItems(List<string> items, string choice)
            {
                items.Sort();
                if (choice == "4")
                {
                    Console.WriteLine("Items are being sorted by Ascending order :");
                    foreach (var i in items)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
                else if (choice == "5")
                {
                    items.Reverse();
                    Console.WriteLine("Items are sorted by Descending order :");
                    foreach (var i in items)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
                MainMenu(items);
            }

            void deleteItem(List<string> items)
            {
                List<string> lista = new List<string>();
                lista = items;
                foreach (var i in items)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine("Enter what item you'd like to delete:");

                string input = Console.ReadLine();
                int index = lista.FindIndex(a => a == input);
                lista.RemoveAt(index);
                items = lista;

                Console.WriteLine("Item is deleted.");
                foreach (var i in items)
                {
                    Console.WriteLine(i + " ");
                }
                MainMenu(items);

            }

            void editItem(List<string> items)
            {
                List<string> lista = new List<string>();

                lista = items;
                foreach (var i in items)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine("Enter what item you want to edit:");
                string input = Console.ReadLine();
                Console.WriteLine("Enter the new item name:");
                string name = Console.ReadLine();
                var index = lista.IndexOf(input);
                lista[index] = name;
                items = lista;
                foreach (var i in items)
                {
                    Console.WriteLine(i + " ");
                }
                MainMenu(items);
            }

            void checkDuplicate(List<string> items)
            {
                Console.WriteLine("Enter new item:");
                string input = Console.ReadLine();
                if (items.Equals(input))
                {
                    Console.WriteLine("Item already exsists, enter a new one");
                    MainMenu(items);
                }
                else
                {
                    items.Add(input);
                    Console.WriteLine("Item is added to the following items");
                    MainMenu(items);
                }
                foreach (var i in items)
                {
                    Console.WriteLine(i + " ");
                }

            }
        }
    }
}