/*
 * Author: Lucas Werneck
 * Date: 02/09/2023
 * Description: Deliverable 5. C# Console Application to randomly populate an array with integers
 *              between 10 and 50 using Methods.
*/

using System;

namespace Deliverable_5_Methods
{
    class Program
    {
        static int[] random_array(int array_length)
        {
            Random random = new Random();
            int[] MyArray = new int[array_length];
            for (int i = 0; i < array_length; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Boolean done = false;
            while (!done)
            {
                try
                {
                    // Limits user to input integers between 5 and 15
                    
                    Console.WriteLine("Enter an integer between 5 and 15");
                    int input = int.Parse(Console.ReadLine());

                    int[] myArray = random_array(input); // Refers to randomArray method

                    if (input >= 5 && input <= 15)
                    {

                        Console.WriteLine("The elements in the random array are: ");

                        foreach (int element in myArray)
                        {
                            Console.Write(element + " ");
                        }

                        Console.WriteLine(" ");
                        Console.WriteLine("The sum is: " + sum(random_array(input)));
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Enter an integer within the range stated above");
                    }
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Please enter an integer");
                }
            }
        }
    }
}