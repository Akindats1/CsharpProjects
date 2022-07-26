using System;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter5!");
            //  1.  Write an if-statement that takes two integer variables and exchanges
            //    their values if the first one is greater than the second one.

            //  2. Write a program that shows the sign (+ or -) of the product of three real 
            //  numbers, without calculating it. Use a sequence of if operators.

            //  3. Write a program that finds the biggest of three integers, using nested 
            //  if statements.

            //  4. Sort 3 real numbers in descending order. Use nested if statements.

            //  5. Write a program that asks for a digit (0-9), and depending on the input, 
            //  shows the digit as a word (in English). Use a switch statement.

            //  6. Write a program that gets the coefficients a, b and c of a quadratic 
            //  equation: ax2 + bx + c, calculates and prints its real roots (if they exist). 
            //  Quadratic equations may have 0, 1 or 2 real roots.

            //  7. Write a program that finds the greatest of given 5 numbers.

            //  8. Write a program that, depending on the user’s choice, inputs int, double
            //  or string variable. If the variable is int or double, the program 
            //  increases it by 1. If the variable is a string, the program appends "*" at 
            //  the end. Print the result at the console. Use switch statement.

            //  9. We are given 5 integer numbers. Write a program that finds those 
            //  subsets whose sum is 0. Examples:
            //  - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
            //  is 0.
            //  - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
            //  with sum 0.

            //  10. Write a program that applies bonus points to given scores in the range 
            //  [1…9] by the following rules:
            //  - If the score is between 1 and 3, the program multiplies it by 10.
            //  - If the score is between 4 and 6, the program multiplies it by 100.
            //  - If the score is between 7 and 9, the program multiplies it by 1000.
            //  - If the score is 0 or more than 9, the program prints an error 
            //  message.

            //  11. * Write a program that converts a number in the range [0…999] to 
            //  words, corresponding to the English pronunciation. Examples:
            //  - 0 --> "Zero"
            //  - 12 --> "Twelve"
            //  - 98 --> "Ninety eight"
            //  - 273 --> "Two hundred seventy three"
            //  - 400 --> "Four hundred"
            //  - 501 --> "Five hundred and one"
            //  - 711 --> "Seven hundred and eleven"





         Console.WriteLine("------Question 1-----");
         Console.WriteLine("Enter first number:");
         int firstNumber = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter second number:");
         int secondNumber = int.Parse(Console.ReadLine());

         if(firstNumber > secondNumber)
         {
            firstNumber = firstNumber +  secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

         }
         Console.WriteLine($"First Number - {firstNumber}, Second Number - {secondNumber}");
         Console.WriteLine();

         Console.WriteLine("--------Question 2-----");
         Console.WriteLine("Enter first number:");
         int firstNum = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter second number:");
         int secondNum = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter third number:");
         int thirdNum = int.Parse(Console.ReadLine());

         int product = firstNum * secondNum * thirdNum;

         if (product < 0)
         {
            Console.WriteLine("-");
         }
         else if (product == 0)
         {
            Console.WriteLine("0");
         }
         else
         {
            Console.WriteLine("+");
         }
         Console.WriteLine();

         Console.WriteLine("--------Question 3-----");
         Console.WriteLine("Enter first number:");
         int num1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter second number:");
         int num2 = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter third number:");
         int num3 = int.Parse(Console.ReadLine());

         if(num1 > num2)
         {
            if(num1 > num3)
            {
                Console.WriteLine($"The biggest number is {num1}");
            }
         }

         else if(num2 > num1)
         {
            if(num2 > num3)
            {
                Console.WriteLine($"The biggest number is {num2}");
            }
         }

         else if(num3 > num1)
         {
            if (num3 > num1)
            {
                Console.WriteLine($"The biggest number is {num3}");
            }
         }
         Console.WriteLine();

         Console.WriteLine("--------Question 4-----");
         Console.WriteLine("Enter first real number:");
         int k = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter second real number:");
         int l = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter third real number:");
         int m = int.Parse(Console.ReadLine());

         if (k < l && k < m && l < m)
         {
            Console.WriteLine($"{k} {l} {m}");
         }
         else if(l < k && l < m && k < m)
         {
            Console.WriteLine($"{k} {l} {m}");
         }
         else if(m < k && m < l && l < k)
         {
            Console.WriteLine($"{k} {l} {m}");
         }
         else
         {
            Console.WriteLine("Wrong input");
         }
         Console.WriteLine();

         Console.WriteLine("--------Question 5-----");
         Console.WriteLine("Input a number [0-9]:");
         int number = int.Parse(Console.ReadLine());

         switch (number)
         {
            case 0:
            {
                Console.WriteLine("Zero");
                break;
            }
            case 1:
            {
                Console.WriteLine("One");
                break;
            }
            case 2:
            {
                Console.WriteLine("Two");
                break;
            }
            case 3:
            {
                Console.WriteLine("Three");
                break;
            }
            case 4:
            {
                Console.WriteLine("Four");
                break;
            }
            case 5:
            {
                Console.WriteLine("Five");
                break;
            }
            case 6:
            {
                Console.WriteLine("Six");
                break;
            }
            case 7:
            {
                Console.WriteLine("Seven");
                break;
            }
            case 8:
            {
                Console.WriteLine("Eight");
                break;
            }
            case 9:
            {
                Console.WriteLine("Nine");
                break;
            }
            default:
            Console.WriteLine("Invalid input!");
            break;
            
         }
            Console.WriteLine();

         Console.WriteLine("--------Question 6-----");
         Console.WriteLine("Enter the value of a:");
         double a = double.Parse(Console.ReadLine());
         Console.WriteLine("Enter the value of b:");
         double b = double.Parse(Console.ReadLine());
         Console.WriteLine("Enter the value of c:");
         double c = double.Parse(Console.ReadLine());

         double D = b * b - 4 * a * c;

         if(D < 0)
         {
            Console.WriteLine($"There are no real roots:{D}");
         }
         else if(D == 0)
         {
               
            double x = (-b /(2 * a));
            Console.WriteLine($"There is one real root: {x}");
         }
        else
         {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"There are two real roots:{x1} and {x2}");
         }
         Console.WriteLine();
         Console.WriteLine("-----Question 7------");
         Console.Write("Enter first Number:");
         decimal num1= decimal.Parse(Console.ReadLine());
         Console.Write("Enter second Number:");
         decimal num2 = decimal.Parse(Console.ReadLine());
         Console.Write("Enter third Number:");
         decimal num3 = decimal.Parse(Console.ReadLine());
         Console.Write("Enter fourth Number:");
         decimal num4 = decimal.Parse(Console.ReadLine());
         Console.Write("Enter fifth Number:");
         decimal num5 = decimal.Parse(Console.ReadLine());

         if((num1>=num2) && (num1>=num3) && (num1>=num4) && (num1>=num5))
         {
            Console.WriteLine($"The greatest number is: {num1}");
         }
        else if((num2>=num1) && (num2>=num3) && (num2>=num4) && (num2>=num5))
        {
            Console.WriteLine($"The greatest number is: {num2}");
        }
        else if((num3>=num1) && (num3>=num2) && (num3>=num4) && (num3>=num5))
        {
            Console.WriteLine($"The greatest number is: {num3}");
        }
        else if((num4>=num1) && (num4>=num2) && (num4>=num3) && (num4>=num5))
        {
            Console.WriteLine($"The greatest number is: {num4}");
        }
        else if((num5>=num1) && (num5>=num2) && (num5>=num3) && (num5>=num4))
        {
            Console.WriteLine($"The greatest number is: {num5}");
        }
        Console.WriteLine();

        Console.WriteLine("-----Question 8------");
        Console.WriteLine("Enter an input (0 - string , 1 - int , 2 - double):");
        int input  = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 0:
            {
                Console.WriteLine("Enter a string:");
                string stringvar = Console.ReadLine();
                stringvar = stringvar + '*';
                Console.WriteLine(stringvar);
                break;
            }
            case 1:
            {
                Console.WriteLine("Enter a int value:");
                int intVar = int.Parse(Console.ReadLine());
                intVar++;
                Console.WriteLine($"The int value + 1 is {intVar}");
                break;
            }
            case 2:
            {
                Console.WriteLine("Enter a double value:");
                double doubleVar = double.Parse(Console.ReadLine());
                doubleVar++;
                Console.WriteLine($"The double value + 1 is {doubleVar}");
                break;
            }
            default:
            Console.WriteLine("Wrong Input!");
            break;
         }
         Console.WriteLine();

         Console.WriteLine("-----Question 9------\nNot done");

         Console.WriteLine("-----Question 10------");
         Console.WriteLine("Enter the score between 1-9:");
         int numberInput = int.Parse(Console.ReadLine());
         switch(numberInput)
         {
            case 1:
            case 2:
            case 3:
                Console.WriteLine($"The bonus score is: {numberInput * 10}");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine($"The bonus score is: {numberInput * 100}");
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine($"The bonus score is: {numberInput * 1000}");
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
         }

         Console.WriteLine("-----Question 11------");
         Console.WriteLine("Enter a number between and 999:");
         int input = int.Parse(Console.ReadLine());
         int hundreds = (int)(input / 100 | 0);
            
            int tensAndOnes;
            if(input > 99)
            {
              tensAndOnes = (int)(input % 100);
            }
            else
                tensAndOnes = input * 1;

            int ones = (int)(input % 10);

            CountNumber(input);
         
         

         

         
         

    



         
    
         











        }

        static void  CountNumber(int input)
        {
           int hundreds = (int)(input / 100 | 0); 
           switch(hundreds)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;

                }
                
                
                int tensAndOnes = (int)(input % 100);
                if(hundreds >= 1 && tensAndOnes >= 1)
                    Console.Write("and ");
                
                if(tensAndOnes >= 20 && tensAndOnes < 30)
                    Console.Write("Twenty");
                else if(tensAndOnes >= 30 && tensAndOnes < 40)
                    Console.Write("Thirty");
                else if(tensAndOnes >= 40 && tensAndOnes < 50)
                    Console.Write("Fourty");
                else if(tensAndOnes >= 50 && tensAndOnes < 60)
                    Console.Write("Fifty");
                else if(tensAndOnes >= 60 && tensAndOnes < 70)
                    Console.Write("Sixty");
                else if(tensAndOnes >= 70 && tensAndOnes < 80)
                    Console.Write("Seventy");
                else if(tensAndOnes >= 80 && tensAndOnes < 90)
                    Console.Write("Eighty");
                else if(tensAndOnes >= 90 && tensAndOnes < 100)
                    Console.Write("Ninety");

                switch(tensAndOnes)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break; 
                    case 7:
                        Console.Write("Seven");
                        break; 
                    case 8:
                        Console.Write("Eight");
                        break; 
                    case 9:
                        Console.Write("Nine");
                        break;
                    case 10:
                        Console.Write("Ten");
                        break;
                    case 11:
                        Console.Write("Eleven");
                        break;
                    case 12:
                        Console.Write("Twelve");
                        break; 
                    case 13:
                        Console.Write("Thirteen");
                        break; 
                    case 14:
                        Console.Write("Fourteen");
                        break; 
                    case 15:
                        Console.Write("Fifteen");
                        break; 
                    case 16:
                        Console.Write("Sixteen");
                        break; 
                    case 17:
                        Console.Write("Seventeen");
                        break; 
                    case 18:
                        Console.Write("Eighteen");
                        break; 
                    case 19:
                        Console.Write("Nineteen");
                        break;      
                }

                if(tensAndOnes > 20)
                {
                    int ones = (int)(input % 10);
                    switch(ones)
                    {
                        case 1:
                            Console.Write("-one");
                            break;
                        case 2:
                            Console.Write("-two");
                            break;
                        case 3:
                            Console.Write("-three");
                            break;
                        case 4:
                            Console.Write("-four");
                            break;
                        case 5:
                            Console.Write("-five");
                            break;
                        case 6:
                            Console.Write("-six");
                            break;
                        case 7:
                            Console.Write("-seven");
                            break;
                        case 8:
                            Console.Write("-eight");
                            break;
                        case 9:
                            Console.Write("-nine");
                            break;
                        
                    }
                }

                if(input == 0)
                    Console.Write("Zero");
                Console.ReadKey();
                
            
        }

    }
}
