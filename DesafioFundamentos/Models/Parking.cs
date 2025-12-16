using System;
using System.Collections.Generic;
using System.Linq;

namespace foundationsChallenge.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Enter the license plate of the vehicle to park:");
            string plate = Console.ReadLine();
            vehicles.Add(plate);
            Console.WriteLine($"Vehicle {plate} parked successfully!");
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter the license plate of the vehicle to remove:");

            string plate = Console.ReadLine();

            // Check if the vehicle exists
            if (vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                Console.WriteLine("Enter the number of hours the vehicle was parked:");
                int hours = int.Parse(Console.ReadLine());
                decimal totalPrice = initialPrice + pricePerHour * hours;
                vehicles.Remove(vehicles.First(x => x.ToUpper() == plate.ToUpper()));
                Console.WriteLine($"The vehicle {plate} was removed. Total price: ${totalPrice}");
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle is not parked here. Check if you entered the plate correctly.");
            }
        }

        public void ListVehicles()
        {
            // Check if there are vehicles parked
            if (vehicles.Any())
            {
                Console.WriteLine("The parked vehicles are:");
                foreach (string v in vehicles)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("There are no vehicles parked.");
            }
        }
    }
}
