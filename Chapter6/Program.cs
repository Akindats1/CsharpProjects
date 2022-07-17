using System;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 6!");

          //  1. Write a program that prints on the console the numbers from 1 to N. 
          //  The number N should be read from the standard input.

          Console.WriteLine("-----Question 1-----");
          Console.Write("Enter length:");
          int length = int.Parse(Console.ReadLine());

          for (int i = 1; i <= length; i++)
          {
            Console.WriteLine(i);
          }

         // 2. Write a program that prints on the console the numbers from 1 to N, 
         // which are not divisible by 3 and 7 simultaneously. The number N 
         // should be read from the standard input.

         Console.WriteLine("-----Question 2-----");
         Console.Write("Enter length:");
         int lengthOfInput = int.Parse(Console.ReadLine());

         for (int i = 1; i <= lengthOfInput; i++)
         {
            if(i % 3 * 7 != 0)
            {
                Console.WriteLine(i);
            }
         }

         // Write a program that reads from the console a series of integers and 
         // prints the smallest and largest of them.

         Console.WriteLine("-----Question 3-----");
         int smallest = 0;
         int largest = 0;
         int input;
         Console.WriteLine("Enter a length:");
         int lengthOfNumber = int.Parse(Console.ReadLine());

         for (int i = 0; i < length; i++)
         {
            Console.WriteLine("Enter element:");
            input = int.Parse(Console.ReadLine());

            if(i == 0)
            {
                smallest = largest = input;
            }
            else
            {
                if (smallest > input)
                {
                    smallest = input;
                }
                if (largest < input)
                {
                    largest = input;
                }
            }
            Console.WriteLine($"The largest is {largest} and the smallest is {smallest}");
        

         }

         // 4. Write a program that prints all possible cards from a standard deck
         // of cards, without jokers (there are 52 cards: 4 suits of 13 cards)
         
         
         



           













        }
    }
}
