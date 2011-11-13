using System;
using System.IO;

namespace Hoppity_Hop
{
    class Program
    {

        /// <summary>
        /// Define the numbers that we care about, by which an integer can be evenly divisible.
        /// </summary>
        private enum DivisibleBy
        {
            None,
            Three,
            Five,
            ThreeAndFive
        }


        /// <summary>
        /// Main entry point of application
        /// </summary>
        /// <param name="args">input file</param>
        static void Main(string[] args)
        {
            string filePath = args[0];

            // Check if we were passed a valid input file
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Input file not found.  Please check path.");
                Environment.Exit(0);
            }

            string fileContents;
            int fileValue;

            // Read our file
            fileContents = File.ReadAllText(filePath);
            fileValue = Convert.ToInt32(fileContents.Trim());

            for (int i = 1; i <= fileValue; i++)
            {
                DivisibleBy divisibleBy = DivisibleBy.None;

                // Evenly divisible by three:
                if (i % 3 == 0)
                {
                    divisibleBy = DivisibleBy.Three;
                }
                // Evenly divisible by five:
                if (i % 5 == 0)
                {
                    divisibleBy = DivisibleBy.Five;
                }
                // Evenly divislbe by three and five:
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    divisibleBy = DivisibleBy.ThreeAndFive;
                }

                // Display output
                switch (divisibleBy)
                {
                    case DivisibleBy.Three:
                        Console.WriteLine("Hoppity");
                        break;
                    case DivisibleBy.Five:
                        Console.WriteLine("Hophop");
                        break;
                    case DivisibleBy.ThreeAndFive:
                        Console.WriteLine("Hop");
                        break;
                }

            }

        }

    }
}
