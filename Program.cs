using Mission3;

Console.WriteLine("Welcome to the Food Bank Inventory System! Select the number of the action you want");

int number;
bool exitVal = false;

while (!exitVal)
{
    // Provide options to user and parse the input they provide
    Console.WriteLine("1) Add Food Item\n2) Delete Food Item\n3) Print List of Current Food Items\n4) Exit Program.");
    Console.Write("Select the number of the option you want: ");
    try
    {
        number = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        number = 0;
    }

    // Call the Add Food Item method
    if (number == 1)
    {
        Console.Write("\nName of Food Item: ");
        string name = Console.ReadLine();
        Console.Write("Category of Food Item: ");
        string category = Console.ReadLine();
        int quantity;
        DateTime myDate;

        // The program requires the user to input an appropriate value
        do
        {
            Console.Write("Quantity of Food Item: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out quantity) && quantity > 0)
            {
                break;  // Exit the loop if the input is a valid positive integer
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a positive integer.\n");
            }

        } while (true);

        // The program requires the user to input an appropriate value
        do
        {
            Console.Write("Expiration Date (format YYYY-MM-DD): ");
            string input = Console.ReadLine();
            int year, month, day;
            DateTime parsedDate;


            if (DateTime.TryParseExact(input, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                year = parsedDate.Year;
                month = parsedDate.Month;
                day = parsedDate.Day;
                myDate = new DateTime(year, month, day);
                break;  // Exit the loop if the input is a valid date format
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter using YYYY-MM-DD format.\n");
            }

        } while (true);

        FoodItem.AddFoodItem(name, category, quantity, myDate);
    }

    // Call the Delete Food Item method
    else if (number == 2)
    {
        Console.Write("You selected 'Delete Food Item'\nName of the item to delete: ");
        string name = Console.ReadLine();
        FoodItem.DeleteFoodItem(name);
    }

    // Call the Print Food Item method
    else if (number == 3)
    {
        Console.WriteLine("You selected 'Print Food Items'");
        FoodItem.PrintAllFoodItems();
    }

    // Exit the program
    else if (number == 4)
    {
        Console.WriteLine("Exiting Program");
        exitVal = true;
    }

    else 
    {
        Console.WriteLine("\nIncorrect input provided\n");
    }

}