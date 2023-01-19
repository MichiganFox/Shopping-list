// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

//SHOPPING LIST
//Objectives: Generic Collections, Data Processing

//Task: Make a shopping list application which uses collections to store your items. (You will be using two collections, one for the menu and one for the shopping list.)








//Build Specifications/Grading Points
//Application uses a Dictionary<string, decimal> to keep track of the menu of items.  You can code it with literals. (2 points for instantiation & initialization)
//Use a List<string> for the shopping list and store the name of the items the customer ordered.
//Application takes item name input and:
//Responds if that item doesn’t exist(1 point)
//Adds its name to the relevant List if it does (1 point)
//Application asks user if they want to quit or continue, and loops appropriately (1 point)
//Application displays list of items with their prices (2 points)
//Application displays the correct total predict for the list (1 point)
//To determine the sum: Loop through the shopping list’s List collection, obtain the name, and look up the name’s price in the Menu Dictionary.

//Extended Challenges:
//Implement a menu system so the user can enter just a letter or number for the item.
//Display the most and least expensive item ordered.
//Display the items ordered in order of price.



//Display at least 8 item names and prices.
//List<string> items = new List<string>()
//{
//    "milk", "eggs", "juice", "butter", "cereal", "ice cream", "chips", "pizza"
//};
//List<double> cost = new List<double>()
//{
//    4.50, 3, 3.95, 3.25, 5.50, 4.19, 2.99, 8.95
//};

//Console.WriteLine($"Here are the items and their prices: {items}, {cost}");



internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Here are the items for sale and their cost: ");
        Dictionary<string, double> grocerycost = new Dictionary<string, double>();
        List<string> cart = new List<string>();
        List<double> total = new List<double>();
        grocerycost.Add("milk", 4.50);
        grocerycost.Add("eggs", 3);
        grocerycost.Add("juice", 3.95);
        grocerycost.Add("butter", 3.25);
        grocerycost.Add("cereal", 5.5);
        grocerycost.Add("ice cream", 4.19);
        grocerycost.Add("chips", 2.99);
        grocerycost.Add("Pizza", 8.95);

        foreach (KeyValuePair<string, double> kvp in grocerycost)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        bool runprogram = true;
       do
        { 
            //Ask the user to enter an item name
            Console.WriteLine("Enter an item name:  ");
            var item = Console.ReadLine().ToLower().Trim();

            //If that item exists, display that item and price and add that item to the user’s order.
            //Console.WriteLine(grocerycost + (item));
        
        
            if (grocerycost.ContainsKey(item))
            {
                Console.WriteLine($"Your {item} has been added.");
                cart.Add(item);
            }
            //If that item doesn’t exist, display an error and re-prompt the user.  (Display the menu again if you’d like.)
            else
            {
                Console.WriteLine("Please pick an item in the list");
            }
            //After adding one to their order, ask if they want to add another. If so, repeat.  (User can enter an item more than once; we’re not keeping track of quantity at this point.)
            Console.WriteLine("Do you want to order again? y/n");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                runprogram = true;

            }
            else if (choice == "n")
            {
                runprogram = false;
                break;
            }
            else
            {
                Console.WriteLine("That was not valid. Try again.");
            }
                                  
       }
        while (runprogram);


    }
}



