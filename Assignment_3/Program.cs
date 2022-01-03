using System;
using System.Collections.Generic;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Choose a value to peform any of the following operations-\n1.To Add an element.\n2.To insert an element at a particular index.\n3.To count the number of elements.\n4.To remove an element.\n5.To check if any element is present or not");
                Console.ResetColor();
                int input = int.Parse(Console.ReadLine());
                var numlist = new List<int>() { 1, 2, 3, 4, 5 };
                if (input == 1)
                {
                    Console.Write("Enter the element you wish to add: ");
                    int nums = int.Parse(Console.ReadLine());
                    numlist.Add(nums);
                    Console.WriteLine("The new list becomes: ");
                    foreach (var num in numlist)
                    {
                        Console.WriteLine(num);
                    }
                }
                else if (input == 2)
                {
                    Console.Write("Enter the index at which the element is to be inserted: ");
                    var index = int.Parse(Console.ReadLine());
                    Console.Write("Enter the value: ");
                    var value = int.Parse(Console.ReadLine());
                    numlist.Insert(index-1, value);
                    Console.WriteLine("The new list becomes: ");
                    foreach (var inum in numlist)
                    {
                        Console.WriteLine(inum);
                    }
                }
                else if (input == 3)
                {
                    var counter = numlist.Count;
                    Console.WriteLine("The number of elements in the array: " + counter);
                }
                else if (input == 4)
                {
                    Console.WriteLine("The elements in the list are: ");
                    foreach (var item in numlist)
                    {
                        Console.WriteLine(item);
                    }
                    Console.Write("Choose the element you wish to remove: ");
                    var remove = int.Parse(Console.ReadLine());
                    numlist.Remove(remove);
                    Console.WriteLine("The new list becomes: ");
                    foreach (var item in numlist)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (input == 5)
                {
                    Console.Write(("Enter the number to check if it is present or not: "));
                    var present = int.Parse(Console.ReadLine());
                    Console.WriteLine(numlist.Contains(present));
                }
                else
                {
                    Console.WriteLine("Invalid Input,Try again...");
                }
                Console.Write("Do you wish to check any other operations[Y/N]: ");
                var choice = Console.ReadLine().ToUpper();
                if (choice == "Y")
                {
                    continue;
                }
                else if (choice == "N")
                {
                    return;
                }
                else { return; }
            }

            }
       
    }
}
