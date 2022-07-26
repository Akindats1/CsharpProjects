using System;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 7!");

            // Write a program, which creates an array of 20 elements of type 
            // integer and initializes each of the elements with a value equals to the 
            // index of the element multiplied by 5. Print the elements to the console.

            Console.WriteLine("-----Question 1-----");
            int[] array = new int[20];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
            
            // Write a program, which reads two arrays from the console and checks 
            // whether they are equal (two arrays are equal when they are of equal 
            // length and all of their elements, which have the same index, are equal).

            Console.WriteLine("-----Question 2-----");
            Console.WriteLine("Enter length of first array:");
            int length = int.Parse(Console.ReadLine());

            int[] firstArray = new int [length];

            for(int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine($"Enter element [{i}]:");
                firstArray[i] = int.Parse(Console.ReadLine());
            }



            Console.WriteLine("Enter length of second array:");

            if( length != int.Parse(Console.ReadLine()))
            {
                Console.WriteLine("The arrays are of different length,therefore the arrays are not equal.");
            
            }
            else
            {
                
                int[] secondArray = new int [length];
                
                for(int i = 0; i < secondArray.Length; i++)
                {
                    Console.WriteLine($"Enter element [{i}]:");
                    secondArray[i] = int.Parse(Console.ReadLine());
                    
                }

                for(int i = 0; i < firstArray.Length; i++)
                {
                    if(firstArray[i] == secondArray[i])
                    {
                        Console.WriteLine("Arrays are equal.");
                    }
                   break;
                }
                
                for(int i = 0; i < secondArray.Length; i++)
                if(firstArray[i] != secondArray[i])
                {
                    Console.WriteLine("Arrays are not of the same elements.");
                    break;
                }

            }
            

            









           


        }
    }
}
