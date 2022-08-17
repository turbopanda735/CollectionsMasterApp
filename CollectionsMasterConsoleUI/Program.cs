using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main()
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var fiftyArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(fiftyArray);

            //TODO: Print the first number of the array
            Console.WriteLine(fiftyArray[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine(fiftyArray[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(fiftyArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Reverse(fiftyArray);
            foreach (var number in fiftyArray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-------------------");
            ReverseArray(fiftyArray);

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(fiftyArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(fiftyArray);
            foreach (var number in fiftyArray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var wholeNumbers = new List<int>(new int[50]);

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(wholeNumbers.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(wholeNumbers);

            //TODO: Print the new capacity
            Console.WriteLine(wholeNumbers.Capacity);
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int userNumber;
            bool validInput;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                var userInput = Console.ReadLine();
                validInput = int.TryParse(userInput, out userNumber);
                if (!validInput)
                    Console.WriteLine("enter a valid int");
            } while (validInput == false);
            NumberChecker(wholeNumbers, userNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(wholeNumbers);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(wholeNumbers);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            wholeNumbers.Sort();
            foreach (var number in wholeNumbers)
                Console.WriteLine(number);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var wholeNumberArray = wholeNumbers.ToArray();
            foreach (var wholeNumber in wholeNumberArray)
                Console.WriteLine(wholeNumber);

            //TODO: Clear the list
            wholeNumbers.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            foreach (var number in numbers)
            {
                if (number % 3 == 0)
                {
                    numbers[number] = 0;
                }
                Console.WriteLine(number);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach (var number in numberList.ToList())
            {
                if (number % 2 != 0)
                { 
                    numberList.Remove(number);
                }
                else Console.WriteLine(number);
            }
        }
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            //TODO: Create a method that prints if a user number is present in the list
            bool numberPresent;
            numberPresent = numberList.Contains(searchNumber);
            if (numberPresent == true)
                Console.WriteLine($"yes, {searchNumber} appears in this list");
            else Console.WriteLine($"no, {searchNumber} does not appear in this list");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
                numberList[i] = rng.Next(0, 51);
        }

        private static void Populater(int[] numbers)
        {
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rng.Next(0, 51);
        }

        private static void ReverseArray(int[] array)
        {
            // 2) Second way, Create a custom method(scroll to bottom of page to find ⬇⬇⬇)
            Array.Reverse(array);
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
