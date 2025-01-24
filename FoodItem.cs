using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    internal class FoodItem
    {
        // Attributes
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }

        // Static list to store all FoodItem instances
        private static List<FoodItem> FoodItemList = new List<FoodItem>();

        // Constructor to initialize attributes
        public FoodItem(string name, string category, int quantity, DateTime expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }

        // Method to create and add a new FoodItem to the list
        public static void AddFoodItem(string name, string category, int quantity, DateTime expirationDate)
        {
            FoodItem newFoodItem = new FoodItem(name, category, quantity, expirationDate);
            FoodItemList.Add(newFoodItem);
            Console.WriteLine("\nFoodItem added successfully.\n");
        }

        // Method to delete a FoodItem from the list by name
        public static void DeleteFoodItem(string name)
        {
            FoodItem foodItemToRemove = FoodItemList.Find(p => p.Name == name);
            if (foodItemToRemove != null)
            {
                FoodItemList.Remove(foodItemToRemove);
                Console.WriteLine($"\nFoodItem '{name}' removed successfully.\n");
            }
            else
            {
                Console.WriteLine($"\nFoodItem '{name}' not found.\n");
            }
        }

        // Method to print all FoodItem details
        public static void PrintAllFoodItems()
        {
            if (FoodItemList.Count == 0)
            {
                Console.WriteLine("\nNo products available.\n");
                return;
            }

            foreach (var foodItem in FoodItemList)
            {
                Console.WriteLine($"\nName: {foodItem.Name}, Category: {foodItem.Category}, Quantity: {foodItem.Quantity}, Expiration Date: {foodItem.ExpirationDate.ToShortDateString()}");
            }
            Console.WriteLine();
        }
    }
}
