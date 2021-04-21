using System;
using System.Collections.Generic;
using System.Linq;

namespace JurasicPark
{
    class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
        public int DateAcquired()
        {
            return Date.now;
        }
    }

    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("       Welcome to Jurassic Park! ");
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------");
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);
            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }

        //   static void Description()
        // {
        //  var Dinosaur = new List<Dinosaur>();

        //  var Dinosaur = new Dinosaur();

        //  var Velociraptor = new Dinosaur();
        // }

        static void Main(string[] args)
        {
            DisplayGreeting();

            var Name = new List<Dinosaur>() { "Raptor", "T-Rex", "Spiny", "Suncoast" };








        }
    }
}
