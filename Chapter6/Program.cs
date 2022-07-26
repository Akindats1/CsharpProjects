using System;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Chapter 6!");

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
        //   Number the cards from 2 to 14 (these numbers will match the cards 2, 
        //     3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A). Number the suits from 1 to 4 (1 –
        //     club, 2 – diamond, 3 – heart and 4 – spades). Now you can use the two
        //     nested loops and print each of the cards with two switch statements.

         Console.WriteLine("----Question 4-----");

         for(int i = 1; i <= 4; i++)
         {
            for(int j = 2; j <= 14; j++)
            {
                switch(i)
                {
                    case 1:
                        Console.WriteLine("Club");
                        break;
                    case 2:
                        Console.WriteLine("Diamond");
                        break;
                    case 3:
                        Console.WriteLine("Heart");
                        break;
                    case 4:
                        Console.WriteLine("Spades");
                        break;
                }


                switch(j)
                {
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                    case 4:
                        Console.WriteLine("4");
                        break;
                    case 5:
                        Console.WriteLine("5");
                        break;
                    case 6:
                        Console.WriteLine("6");
                        break;
                    case 7:
                        Console.WriteLine("7");
                        break;
                    case 8:
                        Console.WriteLine("8");
                        break;
                    case 9:
                        Console.WriteLine("9");
                        break;
                    case 10:
                        Console.WriteLine("10");
                        break;
                    case 11:
                        Console.WriteLine("J");
                        break;
                    case 12:
                        Console.WriteLine("Q");
                        break;
                    case 13:
                        Console.WriteLine("K");
                        break;
                    case 14:
                        Console.WriteLine("A");
                        break;
                    
                    
                }
            }
         }

        //  5. Write a program that reads from the console number N and print the sum 
        //     of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
        //     13, 21, 34, 55, 89, 144, 233, 377, …

         Console.WriteLine("-----Question 5------");
          uint firstNumber = 0, secondNumber = 1, nextNumber;
          Console.WriteLine("Enter number:");
          uint number = uint.Parse(Console.ReadLine());
            

         Console.Write($"{firstNumber + " " + secondNumber},");
         for(uint i = 0; i <= number; i++)
         {
               
             nextNumber = firstNumber + secondNumber;
             Console.Write($" {nextNumber}," );
             firstNumber = secondNumber;
             secondNumber = nextNumber;
                
         }
        Console.WriteLine();
        
         Console.WriteLine("-----Question 6-----");
         Console.Write("Enter N: (1<K<N)");
         int n = int.Parse(Console.ReadLine());
         Console.Write("Enter K: (1<K<N)");
         int k = int.Parse(Console.ReadLine());

         for(int i = n - 1; i > 0; i--);
         {
            int i = n - 1;
            n *= i;
         }

         for(int i = k - 1; i > 0; i--)
         {
            k *= i;
         }
           
         n /= k;

         Console.WriteLine($"Result is {n}");

        //  Console.WriteLine("-----Question 7-----");
        //  Console.Write("Enter N: (1<K<N)");
        //  int n = int.Parse(Console.ReadLine());
        //  Console.Write("Enter K: (1<K<N)");
        //  int k = int.Parse(Console.ReadLine());
        //  int nMinusK = n - k;

        //  for(int i = n - 1; i > 0; i--)
        //  {
        //     n *= i;
        //  }

        //   for(int i = k - 1; i > 0; i--)
        //  {
        //     k *= i;
        //  }
        //   for(int i = nMinusK - 1; i > 0; i--)
        //  {
        //     n *= i;
        //  }

         
        //  Console.WriteLine($"The result is {n * k / nMinusK}");

        //  8. In combinatorics, the Catalan numbers are calculated by the following 
        //         formula:
        //        , for n ≥ 0. Write a program that 
        //         calculates the nth Catalan number by given 

        Console.WriteLine("------Question 8-----");
        Console.WriteLine("Enter N: (N >= 0) ");
        int num = int.Parse(Console.ReadLine());

        int factorial2N = 2 * num , factorialNplus1 = num + 1;

        for(int i = factorial2N - 1; i > 0; i--)
        factorial2N *= i;
        for(int i = factorialNplus1 - 1; i > 0; i--)
        factorialNplus1 *= i;
        for(int i = n - 1; i > 0; i--)
        n *= i;

        Console.WriteLine($"The result is {factorial2N / (factorialNplus1 * n)}");
        Console.WriteLine();

        // 9. Write a program that for a given integers n and x, calculates the sum: 

        Console.WriteLine("------Question 9-----");
        int sum = 1, temp = 1;
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= n; i++)
        {
            temp *= i / x;
            sum += temp;
        }

        Console.WriteLine($"The result is {sum}");

         Console.WriteLine("------Question 10-----");
         Console.WriteLine("Enter N: (N < 20) ");
         int n = int.Parse(Console.ReadLine());

         for( int i = 1; i <= n; i++)
         {
            for(int j = i; j <= i + n - 1; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
         }

        //  11. Write a program that calculates with how many zeroes the factorial of 
        //      a given number ends. Examples:
        //      N = 10 -> N! = 3628800 -> 2
        //      N = 20 -> N! = 2432902008176640000 -> 4
         
         Console.WriteLine("------Question 11-----");
         Console.Write("Enter N: ");
         decimal n = int.Parse(Console.ReadLine());
         int zeroes = 0;
         decimal factorial = 1;

         for (int i = (int)(n - 1); i > 0; i--)
             n *= i;
             factorial = n;
         Console.Write($"N! is {factorial} and it ends ");

         do
         {
            factorial /= 10;
            zeroes++;
         } while (factorial % 10 == 0);

         Console.WriteLine($"with {zeroes} zero(es).");

         //  12. Write a program that converts a given number from decimal to binary notation (numeral system).
         
         Console.WriteLine("------Question 12-----");
         Console.Write("Enter number: ");
         int n = int.Parse(Console.ReadLine());    
         string binary = Convert.ToString(n, 2);
         Console.WriteLine($"Result in binary is {binary}");

         // 13. Write a program that converts a given number from binary to decimal notation.

        Console.WriteLine("------Question 13-----");
         Console.Write("Enter binary number: ");
         int binaryValue = int.Parse(Console.ReadLine());
         int decimalValue = Convert.ToInt32(binaryValue.ToString(), 2);           
         Console.WriteLine($"Decimal Value : {decimalValue} ");
         Console.WriteLine();
         
         // 14. Write a program that converts a given number from decimal to hexadecimal notation.
         Console.WriteLine("------Question 14-----");
         Console.Write("Enter decimal number: ");
         int decimalNum = int.Parse(Console.ReadLine());
         string hexaDecimalValue = (decimalNum.ToString("x"));           
         Console.WriteLine($"Hexadecimal Value : {hexaDecimalValue} ");
         Console.WriteLine();

         // 15. Write a program that converts a given number from hexadecimal to decimal notation.
         Console.WriteLine("------Question 15-----");
         Console.WriteLine("Enter hexadecimal number: ");
         string hexaDecimalNum = Console.ReadLine();
         Console.WriteLine($"Decimal Value : {Convert.ToInt32(hexaDecimalNum , 16)} ");
         Console.WriteLine();

         // 16. Write a program that by a given integer N prints the numbers from 1 to N in random order.
          Console.WriteLine("------Question 16-----");
          Random rnd = new Random();
          int temp, randomNumber;
          Console.Write("Enter number: ");
          int n = Int32.Parse(Console.ReadLine());
          int[] arr = new int[n];            

          for (int i = 0; i < arr.Length; i++)
          {
            arr[i] = i;
          }

          foreach (int i in arr)
          {                
            randomNumber = rnd.Next(0, n);
            temp = arr[i];
            arr[i] = arr[randomNumber];
            arr[randomNumber] = temp;                
          }

          foreach (int i in arr) 
            Console.WriteLine(arr[i]);
            Console.WriteLine();

            // 17. Write a program that given two numbers finds their greatest common 
            //     divisor (GCD) and their least common multiple (LCM). You may use 
            //     the formula LCM(a, b) = |a*b| / GCD(a, b).

         Console.WriteLine("------Question 17----");
         Console.Write("Enter first number: ");
         int a = int.Parse(Console.ReadLine());
         Console.Write("Enter second number: ");
         int b = int.Parse(Console.ReadLine());

         while (a != 0 && b != 0)
         {
            if (a > b) a %= b;
            else b %= a;
         }

         if (a == 0) Console.WriteLine(b);
         else Console.WriteLine(a);
         Console.WriteLine();*/

         Console.WriteLine("-----Question 18------");
         int[,] matrix =
        {
            {1, 2, 3, 4},
            {12, 13, 14, 5},
            {11, 16, 15, 6},
            {10, 9, 8, 7},
          };
         // Print the matrix on the console
         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row   ,  col]  + "\t");
            }
            Console.WriteLine();
         }





        





        






         



         
         
         



           













        }
    }
}
