using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nChoose a number to perform the required function\n1.Check if a number is prime or not\n2.To find the sum of numbers\n3.To reverse a string.\n4.Display sum of first 500 Prime numbers.\n5.Reverse a sentence.\n6.Element wise Matrix Multiplication.\n");
                Console.ResetColor();
                var input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.Write("Enter the number to check if it is prime or not: ");
                    var num = Convert.ToInt32(Console.ReadLine());
                    PrimeCheck(num);
                }
                else if (input == 2)
                {
                    Console.Write("Enter the digit to find the sum: ");
                    var digit = int.Parse(Console.ReadLine());
                    SumOfNumber(digit);
                }
                else if (input == 3)
                {
                    Console.Write("Enter the word you wish to reverse: ");
                    var word = Console.ReadLine();
                    ReverseWord(word);
                    Console.WriteLine("\n");
                }
                else if (input == 4)
                {
                    double sum = 0;
                    int counter = 0;
                    int n = 2;
                    while (counter < 500)
                    {
                        if (isPrime(n))
                        {
                            sum += n;
                            counter++;
                        }
                        n++;
                    }
                    Console.WriteLine("Sum of the first 500 prime numbers: " + sum);
                    Console.WriteLine("\n");
                }
                else if (input == 5)
                {
                    Console.Write("Enter the sentence you wish to reverse: ");
                    var sentence = Console.ReadLine();
                    ReversedSentence(sentence);
                }
                else if (input == 6)
                {
                    Console.Write("Enter the number of elements for the matrices: ");
                    int size1 = int.Parse(Console.ReadLine());                   
                    int[] matrix1 = new int[size1];
                    int[] matrix2 = new int[size1];
                    
                    Console.WriteLine("Enter the elements for the first matrix: ");
                    for (int i = 0; i < size1; i++)
                    {
                        Console.Write($"Element at position-{i+1}: ");
                        matrix1[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Enter the elements for Matrix 2: ");
                    for (int j = 0; j < size1; j++)
                    {
                        Console.Write($"Element at position-{j+1}: ");
                        matrix2[j] = int.Parse(Console.ReadLine());
                    }
                    Console.Write("The result is: ");
                    for (int i = 0; i < matrix1.Length; i++)
                    {
                        Console.Write( matrix1[i] * matrix2[i] + " ");
                    }
                    Console.WriteLine("\n");
                 }

                else
                {
                    Console.WriteLine("Please enter a valid input...");
                }

                Console.WriteLine("Do you wish to check some other Operations[Y/N]?: ");
                var wish = Console.ReadLine().ToUpper();
                if (wish == "Y")
                {
                    continue;
                }
                else if (wish == "N")
                {
                    return;
                }
                else { return; }
            }
            }

        public static void PrimeCheck(int num)
        {
            int flag=0;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.Write( num + " is not a Prime Number.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.Write(num + " is a Prime Number.");
            }
            Console.ReadLine();
        }
        
        public static void SumOfNumber(int digit)
        {
            int sum = 0, reminder;
            while (digit != 0)
            {
                reminder = digit % 10;
                digit = digit / 10;
                sum += reminder;
            }
            Console.WriteLine("Sum of Digits of the input Number : " + sum);
            Console.ReadLine();
        }

        public static void ReverseWord(string word)
        {
            string reversedword = " ";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedword += word[i];
            }
            Console.Write($"Reversed Word is : {reversedword} ");
            Console.ReadLine();
        }
        public static bool isPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= n/2; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void ReversedSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            int length = words.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
            Console.ReadLine();
        }        
    }
}
