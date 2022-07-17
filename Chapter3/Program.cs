using System;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 3");

            /*1. Write an expression that checks whether an integer is odd or even.

            2. Write a Boolean expression that checks whether a given integer is 
            divisible by both 5 and 7, without a remainder.

            3. Write an expression that looks for a given integer if its third digit (right 
            to left) is 7.

            4. Write an expression that checks whether the third bit in a given integer 
            is 1 or 0.

            5. Write an expression that calculates the area of a trapezoid by given 
            sides a, b and height h.

            6. Write a program that prints on the console the perimeter and the area 
            of a rectangle by given side and height entered by the user.

            7. The gravitational field of the Moon is approximately 17% of that on the 
            Earth. Write a program that calculates the weight of a man on the 
            moon by a given weight on the Earth.

            8. Write an expression that checks for a given point {x, y} if it is within 
            the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
            the circle and 5 is the radius.

            9. Write an expression that checks for given point {x, y} if it is within the 
            circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
            Clarification: for the rectangle the lower left and the upper right corners 
            are given.

            10. Write a program that takes as input a four-digit number in format abcd
            (e.g. 2011) and performs the following actions:
            - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            - Prints on the console the number in reversed order: dcba (in our 
            example 1102).
            - Puts the last digit in the first position: dabc (in our example 1201).
            - Exchanges the second and the third digits: acbd (in our example 
            2101).
            
            11. We are given a number n and a position p. Write a sequence of 
            operations that prints the value of the bit on the position p in the 
            number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
            p=6 -> 0.

            12. Write a Boolean expression that checks if the bit on position p in the 
            integer v has the value 1. Example v=5, p=1 -> false.

            13. We are given the number n, the value v (v = 0 or 1) and the position p. 
            write a sequence of operations that changes the value of n, so the bit on 
            the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
            Another example: n=35, p=2, v=1 -> n=39.

            14. Write a program that checks if a given number n (1 < n < 100) is a 
            prime number (i.e. it is divisible without remainder only to itself and 1).

            15. * Write a program that exchanges the values of the bits on positions 
            3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned 
            integer.

            16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, 
            q+1, …, q+k-1} of a given 32-bit unsigned integer.*/


          Console.WriteLine("--------Question1-------");
          Console.WriteLine("Enter number to display if it is odd or even:");
          int number = int.Parse(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{number} is odd: {number % 2 != 0}");
          Console.WriteLine($"{number} is even: {number % 2 == 0}");
          Console.WriteLine();

          Console.WriteLine("--------Question2-------");
          Console.WriteLine("Enter number :");
          int num1 = int.Parse(Console.ReadLine());
          Console.Clear();
          bool isdivisible = (num1 % 5*7 == 0) ? true : false;
          Console.WriteLine($"{num1} is divisible by 5 and 7 : {isdivisible}");
          Console.WriteLine();

          Console.WriteLine("--------Question3-------");
          int  number1  = 13754;
          bool isSeven = true;

          if(isSeven)
          {
            Console.WriteLine("The third digit is seven");
          }
          else
          {
            
            Console.WriteLine("The third digit is not seven");
          }
          Console.WriteLine();

          
          Console.WriteLine("--------Question4-------");










          
          Console.WriteLine("--------Question5-------");
          Console.WriteLine("Enter a:");
          double a = double.Parse(Console.ReadLine());
          Console.Clear();
          Console.WriteLine("Enter b:");
          double b = double.Parse(Console.ReadLine());
          Console.Clear();
          Console.WriteLine("Enter h:");
          double h = double.Parse(Console.ReadLine());
          Console.Clear();
          double S =((a + b) * (h / 2));
          Console.WriteLine($"The area of the trapezoid a={a} and b={b} and h={h} is:{S}cm^2.");
          Console.WriteLine();

         Console.WriteLine("--------Question6-------");
         Console.WriteLine("Enter length:");
         int c = int.Parse(Console.ReadLine());
         Console.Clear();
         Console.WriteLine("Enter width:");
         int d = int.Parse(Console.ReadLine());
         Console.Clear();
         int A = c * d;
         int P = (c + d) * 2;
         Console.WriteLine($"The perimeter and area of the rectangle lenght={c} and width={d} is: {P}m and {A}m^2 respectively.");
         Console.WriteLine();

         
         Console.WriteLine("--------Question7-------");
         Console.WriteLine("Enter the weight of man on earth:");
         double weightOfManOnEarth = double.Parse(Console.ReadLine());
         Console.Clear();
         double percentGiven = 17d / 100;
         Console.WriteLine($"The weight of the man on the moon is: {weightOfManOnEarth * percentGiven}kg");
         Console.WriteLine();

         Console.WriteLine("--------Question8-------");
         Console.WriteLine("Enter x:");
         int x = int.Parse(Console.ReadLine());
         Console.Clear();
         Console.WriteLine("Enter y:");
         int y = int.Parse(Console.ReadLine());
         Console.Clear();
         bool isInside = (x * x) + (y * y) <= 25 ? true : false;
         Console.WriteLine($"The point ({x},{y}) is inside K((0, 0), R=5):{isInside}");
         Console.WriteLine();

         Console.WriteLine("--------Question9-------");
         Console.WriteLine("Enter x1:");
         int x1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter y1:");
         int y1 = int.Parse(Console.ReadLine());
         bool isInsideTheCircle = (x1 * x1) + (y1 * y1) <= 25;
         bool outOfRectangle = (x1 < -1 && x1 > 5) && (y1 < 1 && y1 > 5);
         bool isInsideAndOutOfRectangle = isInsideTheCircle && outOfRectangle ? true : false;
         Console.WriteLine($"The point ({x},{y}) is inside the cirle and out of the rectangle:{isInsideAndOutOfRectangle}");





         Console.WriteLine("--------Question10-------");
         Console.WriteLine("Enter four digits number :");
         string num = Console.ReadLine();
         Console.Clear();
         int first = int.Parse(num[0].ToString());
         int second = int.Parse(num[1].ToString());
         int third = int.Parse(num[2].ToString());
         int fourth = int.Parse(num[3].ToString());
         Console.WriteLine($"Calculates the sum of the four digits:{first + second + third + fourth}");
         Console.WriteLine($"Prints on the console the number in reversed order :{fourth}{third}{second}{first}");
         Console.WriteLine($"Puts the last digit in the first position :{fourth}{first}{second}{third}");
         Console.WriteLine($"Exchanges the second and third digits :{first}{third}{second}{fourth}");
         Console.WriteLine();
         










          




         



        









        }   
    }
}
