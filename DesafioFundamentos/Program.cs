using System;
using foundationsChallenge.Models;
// Set output encoding to UTF8 to display special characters
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Welcome to the parking system!\n" +
                  "Enter the initial price:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now enter the price per hour:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

// Instantiate the Parking class with the values obtained above
Parking parking = new Parking(initialPrice, pricePerHour);

string option = string.Empty;
bool showMenu = true;

// Run the menu loop
while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Enter your option:");
    Console.WriteLine("1 - Register a vehicle");
    Console.WriteLine("2 - Remove a vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Exit");

    string input = Console.ReadLine();

    switch (input)
    {   
        case "1":
            parking.AddVehicle();
            break;

        case "2":
            parking.RemoveVehicle();
            break;

        case "3":
            parking.ListVehicles();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    if (input != "4")
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
    }
}

Console.WriteLine("The program has ended");
