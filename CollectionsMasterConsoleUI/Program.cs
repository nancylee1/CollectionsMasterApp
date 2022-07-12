using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);
            NumberPrinter(numbers);

            //TODO: Print the first number of the array
            Console.WriteLine();
            Console.Write("Print the first number of the array: ");
            Console.WriteLine(numbers[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine();
            Console.Write("Print the last number of the array: ");
            Console.WriteLine(numbers[numbers.Length -1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Console.WriteLine("Using first way which is easier");
            Array.Reverse(numbers);
            NumberPrinter(numbers);

            Console.WriteLine(); // Adding a space to separate 1) & 2)
            Console.WriteLine("---------REVERSE CUSTOM------------");            
            ReverseArray(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

           

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numbersList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("Print the capacity of the list: ");
            Console.WriteLine(numbersList.Capacity);
            Console.WriteLine(); // Adding space

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Console.WriteLine("Populate the List with 50 random numbers bwtn 0 and 50: ");
            Populater(numbersList); 
            NumberPrinter(numbersList);

            //TODO: Print the new capacity
            Console.WriteLine(); // Adding space
            Console.WriteLine(numbersList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            //Console.WriteLine("What number will you search for in the number list?");
            bool x;
            int y;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                x = int.TryParse(Console.ReadLine(), out y);
               
            } while (x == false);

            NumberChecker(numbersList, y);
            Console.WriteLine();

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbersList);
            NumberPrinter(numbersList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numbersList.Sort(); 
            NumberPrinter(numbersList); 
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            var newArray = numbersList.ToArray();   

            //TODO: Clear the list

            numbersList.Clear();    
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 3 == 0)
                    {
                        numbers[i] = 0; 
                    }
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                    i--;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool isMatchNum = false;

            foreach (var item in numberList)
            {
                if (item == searchNumber)
                {
                    isMatchNum = true;
                    break;  
                }
                else
                {
                    isMatchNum = false; 
                }
            }
            if (isMatchNum == true)
            {
                Console.WriteLine("This number is on the list");
            }
            else
            {
                Console.WriteLine("This number cannot be found on the list");
            }
        }

        private static void Populater(List<int> numbers)
        {
            Random rng = new Random();
            for (int i = 0; i <= 50; i++)
            {
                numbers.Add(rng.Next(1, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 51);
            }

        }

        private static void ReverseArray(int[] array)
        {
            int temp = 0;
            int lastIndex = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[lastIndex - i];
                array[lastIndex - 1] = temp;
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
