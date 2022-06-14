using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Write("\n" + "\n" + "How many people are we making PB and J sandwiches for?: ");
                int number = int.Parse(Console.ReadLine());
                int slices = 2;
                int slicesPerLoaf = 28;
                int PBtablespoons = 2;
                int PBJar = 32;
                int jellyteaspoons = 4;
                int jellyJar = 48;
                int totalSlicesNeeded = number * slices;
                int totalPBNeeded = number * PBtablespoons;
                int totaljellyNeeded = number * jellyteaspoons;
                int totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf;
                if (totalSlicesNeeded % slicesPerLoaf != 0) totalLoavesNeeded++;
                int totalPBJarsNeeded = totalPBNeeded / PBJar;
                if (totalPBNeeded % PBJar != 0) totalPBJarsNeeded++;
                int totaljellyJarsNeeded = totaljellyNeeded / jellyJar;
                if (totaljellyNeeded % jellyJar != 0) totaljellyJarsNeeded++;
                Console.WriteLine("\n" + "You need: " + "\n" + "\n" +
                    "  1. " + totalSlicesNeeded + " slices of bread " + "\n" + "  2. " + totalPBNeeded + " tablespoonsfull of peanut butter " + "\n" + "  3. " + totaljellyNeeded + " teaspoonsfull of jelly " + "\n" + "\n" + "which is..." + "\n" + "\n" + "  1. " + totalLoavesNeeded + " loaf/loaves of bread " + "\n" + "  2. " + totalPBJarsNeeded + " jar(s) of peanut butter" + "\n" + "  3. " + totaljellyJarsNeeded + " jar(s) of jelly " + "\n" + "\n");
                Console.Write("Enter yes or y to start over, or any other key to exit: ");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "yes": continue; //restart the loop
                    case "y": continue; //restart the loop
                    default:
                        Console.WriteLine(" Goodbye!");
                        keepLooping = false; //stop the loop from running 
                        break;
                }
            }
        }
    }
}
    


