﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace JurasicPark
{

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

        static void Main(string[] args)
        {
            var dinosaur = new Dinosaur();

            DisplayGreeting();

            var keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine();
                Console.Write("Do you want to (A)dd a Dinosaur or (R)emove a Dinosaur or (T)ransfer a dinosaur or (V)iew all the dinosaurs or (Q)uit: ");
                var choice = Console.ReadLine().ToUpper();

                if (choice == "Q")
                {
                    keepGoing = false;
                }
                else if (choice == "V")
                {
                    foreach (var dinosaur in dinosaurs)
                    {
                        // Console.WriteLine($"The {dinosaur.Name} is a {dinosaur.DietType}, while weighing {dinosaur.Weight} lbs, in enclosure number {dinosaur.EnclosureNumber}, and was acquired on {dinosaur.DateAcquired}");
                        Console.WriteLine(dinosaur.Description());
                    }
                    var WhenAcquired = dinosaurs.OrderBy(dinosaur => dinosaur.DateAcquired);
                }
                else if (choice == "A")
                {
                    var dinosaur = new Dinosaur();

                    dinosaur.Name = PromptForString("What dinosaur are you looking for? ");
                    dinosaur.DietType = PromptForString("Is it a herbivore or carnivore? ");
                    dinosaur.Weight = PromptForInteger("How much does the dinosaur weigh in pounds? ");
                    dinosaur.EnclosureNumber = PromptForInteger("What is its enclosure number? ");

                    dinosaurs.Add(dinosaur);
                }
                else if (choice == "R")
                {
                    var toRemove = PromptForString("What dinosaur would you like to remove? ");
                    Dinosaur removedDinosaur = dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == toRemove);

                    if (removedDinosaur == null)
                    {
                        Console.WriteLine("No dinosaurs by that name to delete! ");
                    }
                    else
                    {
                        dinosaurs.Remove(removedDinosaur);
                        Console.WriteLine($"The {toRemove} went extinct");
                    }

                }
                else if (choice == "T")
                {
                    var toTransfer = PromptForString("What are you wanting to transfer? ");
                    Dinosaur transferDinosaur = dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == toTransfer);

                    if (transferDinosaur == null)
                    {
                        Console.WriteLine("Can not transfer that dinosaur! ");
                    }
                    else
                    {
                        var newDinosaur = PromptForInteger($"What is {transferDinosaur}'s new enclosure number? ");
                        transferDinosaur.EnclosureNumber = newDinosaur;

                    }
                }
                else if (choice == "S")
                {
                    var toSummary = PromptForString("What are you wanting to summarize? ");
                    Dinosaur summaryDinosaur =
                }

            }
        }
    }
}
