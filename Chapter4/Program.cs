using System;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 4");

        //  1. Write a program that reads from the console three numbers of type int
        //  and prints their sum.

        //  2. Write a program that reads from the console the radius "r" of a circle 
        //  and prints its perimeter and area.

        //  3. A given company has name, address, phone number, fax number, web 
        //  site and manager. The manager has name, surname and phone number.
        //  Write a program that reads information about the company and its 
        //  manager and then prints it on the console.

        //  4. Write a program that prints three numbers in three virtual columns
        //  on the console. Each column should have a width of 10 characters and 
        //  the numbers should be left aligned. The first number should be an 
        //  integer in hexadecimal; the second should be fractional positive; and 
        //  the third – a negative fraction. The last two numbers have to be 
        //  rounded to the second decimal place.

        //  5. Write a program that reads from the console two integer numbers (int)
        //  and prints how many numbers between them exist, such that the 
        //  remainder of their division by 5 is 0. Example: in the range (14, 25) 
        //  there are 3 such numbers: 15, 20 and 25.

        //  6. Write a program that reads two numbers from the console and prints the 
        //  greater of them. Solve the problem without using conditional 
        //  statements.

        //  7. Write a program that reads five integer numbers and prints their 
        //  sum. If an invalid number is entered the program should prompt the user 
        //  to enter another number.

        //  8. Write a program that reads five numbers from the console and prints the 
        //  greatest of them.

        //  9. Write a program that reads an integer number n from the console. After 
        //  that reads n numbers from the console and prints their sum.

        //  10. Write a program that reads an integer number n from the console and 
        //  prints all numbers in the range [1…n], each on a separate line.

        //  11. Write a program that prints on the console the first 100 numbers in the 
        //  Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

        //  12. Write a program that calculates the sum (with precision of 0.001) of 
        //  the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + 


        /*Console.WriteLine("------Question 1-----");
        Console.WriteLine("This program add three numbers and print their sum.");
        Console.WriteLine("Enter first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter third number:");
        double thirdNum = double.Parse(Console.ReadLine());
        Console.Clear();
        double sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("The sum of {0} + {1} + {2} = {3}", firstNum , secondNum , thirdNum , sum);
        Console.WriteLine();

        Console.WriteLine("------Question 2-----");
        Console.WriteLine("This program prints the perimeter and area.");
        Console.WriteLine("Enter radius:");
        double radius = double.Parse(Console.ReadLine());
        double C , A;
        C = 2 * Math.PI * radius;
        A = Math.PI * (radius * radius);
        Console.WriteLine($"The radius of the circle is {radius}, the perimeter is {Math.Round( C , 2)}cm and the area is  {Math.Round( A , 2)}cm ");
        Console.WriteLine();

        Console.WriteLine("------Question 3-----");
        Console.WriteLine("Enter company name:");
        string companyName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter company address:");
        string companyAddress = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter company phone number:");
        string companyPhoneNumber = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter company fax number:");
        string companyFaxNumber = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter company website:");
        string companyWebsite = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter manager first name:");
        string companyManagerFirstName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter manager surname:");
        string companyManagerSurName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter manager phone number:");
        string companyManagerNumber = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"The name of the company is {companyName}\nThe company address is {companyAddress}\nThe company phone number is {companyPhoneNumber}\nThe company fax number is {companyFaxNumber}\nThe company website is {companyWebsite}");
        Console.WriteLine($"The manager name is {companyManagerFirstName}{companyManagerSurName} and the manager phone number is {companyManagerNumber}");
        Console.WriteLine();

        Console.WriteLine("------Question 4-----");
        Console.WriteLine("Enter hexadecimal number:");
        string hexaDecimalNumber = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Enter postive fraction number:");
        double positiveFractionNumber = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Enter negative fraction number:");
        double negativeFractionNumber = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("[{0 , -10:x}]" , hexaDecimalNumber);
        Console.WriteLine("[{0 , -10:f2}]" , positiveFractionNumber);
        Console.WriteLine("[{0 , -10:f2}]" , negativeFractionNumber);
        Console.WriteLine();

        Console.WriteLine("------Question 5-----");
        Console.WriteLine("Enter first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int secondNumber = int.Parse(Console.ReadLine());

        for(int i = firstNumber; i <= secondNumber; i++)
        {
            if(i % 5 == 0)
            {
                Console.WriteLine($"The number between {firstNumber} and {secondNumber} that is divisible by 5 is {i}");
            }
        }
        Console.WriteLine();

        Console.WriteLine("-------------\"Question 6\"----------");
        double greatestNumber;
        Console.WriteLine("Enter first number");
        double firstNo = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        double secondNo = double.Parse(Console.ReadLine());
        greatestNumber = Math.Max(firstNo , secondNo);
        Console.WriteLine($"The greatest number is :{greatestNumber}");*/

        /*Console.WriteLine("-------------\"Question 7\"----------");
        int sum = 0;
        for(int i = 0; i <= 4; i++)
        {
            Console.WriteLine("Please input number:");
            string numberInput = Console.ReadLine();

            int x;
            bool isInteger = int.TryParse(numberInput , out x);
            sum += x;

            if(!isInteger)
            {
                i--;
                Console.Write("Invalid input!\n");
            }
        }
        Console.WriteLine($"The sum of the number is {sum}");
        Console.WriteLine();


        Console.WriteLine("-------------\"Question 8\"----------");
        Console.Write("Enter first number:");
        decimal num1= decimal.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Enter second number:");
        decimal num2 = decimal.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Enter third number:");
        decimal num3 = decimal.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Enter fourth number:");
        decimal num4 = decimal.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Enter fifth number:");
        decimal num5 = decimal.Parse(Console.ReadLine());
        Console.Clear();

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

         Console.WriteLine("-------\"Question 9\"------");
         int sumOfNumbers = 0;
         Console.WriteLine("Enter the number count:");
         int length = int.Parse(Console.ReadLine());

         for(int i = 1 ; i <= length; i++)
         {
            Console.Write("Enter {0} number:", i );
            sumOfNumbers += int.Parse(Console.ReadLine());
         }
         Console.WriteLine($"The sum of all the numbers is {sumOfNumbers}");


          Console.WriteLine("-------\"Question 10\"------");
          Console.WriteLine("Enter the number count:");
         int n = int.Parse(Console.ReadLine());

         for(int i = 1 ; i <= n; i++)
         {
            Console.Write(i);
            
         }*/

         Console.WriteLine("--------\"Question 11\"---------");
           uint firstNumber = 0, secondNumber = 1, nextNumber,number = 100;
            

            Console.Write($"{firstNumber + " " + secondNumber},");
            for(uint i = 0; i <= number; i++)
            {
               
                nextNumber = firstNumber + secondNumber;
                Console.Write($" {nextNumber}," );
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            Console.

         
        
        
       

        




        
        
        

        







        
        
        
        

        

        


    

    






















        }
    }
}
