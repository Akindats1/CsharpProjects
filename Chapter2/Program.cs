using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 2");
            //1 Declare several variables by selecting for each one of them the most 
              //appropriate of the types sbyte, byte, short, ushort, int, uint, long
              //and ulong in order to assign them the following values: 52,130; -115; 
              //4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
              //1990; 123456789123456789;

              /*sbyte firstNum = 52,97,-44,-115;
              byte secondNum2 = 130,224,112;
              short thirdNum3 = -10000,1990;
              ushort fourthNum4 = 4825932U;
              int fifthNum5 = -1000000 ;
              uint sixthNum6 = 20000U ;
              long seventhNum7 = 9707000000 ;
              ulong eightNum8 = 123456789123456789U;*/
        

             //2. Which of the following values can be assigned to variables of type float, 
             //double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
             //3456.091124875956542151256683467?

             /*float firstNumber = 5f;
             float secondNumber2 = -5.01f;
             float thirdNumber3 =12.345f;
             double fourthNumber4 = 34.567839023;
             double fifthNumber5 = 8923.1234857;
             decimal sixthNumber6 = 3456.091124875956542151256683467m;*/


             //Write a program, which compares correctly two real numbers with 
             //accuracy at least 0.000001.

             decimal firstRealNumber = 34.76557666466464846m;
             decimal secondRealNumber =34.64764684847467474m;
             bool equal = Math.Abs(firstRealNumber - secondRealNumber) < 0.000001m;
             Console.WriteLine(equal);
             


             //Initialize a variable of type int with a value of 256 in
             //hexadecimal format (256 is 100 in a numeral system with base 16).

             int hexadecimalnumber = 0x100;
             Console.WriteLine(hexadecimalnumber);


             //Declare a variable of type char and assign it as a value the character, 
             // which has Unicode code, 72 (use the Windows calculator in order to find 
             // hexadecimal representation of 72).

              char character = '\u0072';
             Console.WriteLine(character);

             //Declare a variable isMale of type bool and assign a value to it depending 
             //on your gender.

             bool isMale = true;
             Console.WriteLine(isMale);

             //Declare two variables of type string with values "Hello" and "World". 
             //Declare a variable of type object. Assign the value obtained of 
             //concatenation of the two string variables (add space if necessary) to this 
             //variable. Print the variable of type object.

             string firstWord ="Hello";
             string secondWord ="World";
             object object1 =  firstWord + " " + secondWord;
             Console.WriteLine(object1);

             /*Declare two variables of type string and give them values "Hello" and 
             "World". Assign the value obtained by the concatenation of the two 
              variables of type string (do not miss the space in the middle) to a 
               variable of type object. Declare a third variable of type string and 
               initialize it with the value of the variable of type object (you should use 
                type casting)*/

                
             // string firstWord ="Hello";
             // string secondWord ="World";
             // object statement = firstWord + " " + secondWord;
             // string bothWord = statement.ToString();

             //Declare two variables of type string and assign them a value “The 
             //"use" of quotations causes difficulties.” (without the outer quotes). 
             //In one of the variables use quoted string and in the other do not use it.

             string firstValue = "The \"use\" of quotations causes diffculties";
             string secondValue = "\"The  \"use\" of quotations causes difficulties\"";
             Console.WriteLine(firstValue);
             Console.WriteLine(secondValue);

             //Write a program to print a figure in the shape of a heart by the sign "o".
             Console.WriteLine("  o         o");
             Console.WriteLine("o   o     o   o");
             Console.WriteLine(" o    o  o   o ");
             Console.WriteLine("  o   o o   o");
             Console.WriteLine("    o      o");
             Console.WriteLine("      o   o   ");
             Console.WriteLine("       o o");
             Console.WriteLine();
            

             // Write a program that prints on the console isosceles triangle which 
             //sides consist of the copyright character "©"
             Console.WriteLine("    @");
             Console.WriteLine("   @ @ ");
             Console.WriteLine("  @   @    ");
             Console.WriteLine(" @    @    ");
             Console.WriteLine("@@@@@@@   ");

            /* A company dealing with marketing wants to keep a data record of its 
             employees. Each record should have the following characteristic – first 
             name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
             (27560000 to 27569999). Declare appropriate variables needed to 
             maintain the information for an employee by using the appropriate data 
             types and attribute names.*/

             /*string firstName;
             string lastname;
             byte age;
             char gender;
             int employeeNumber;*/

             // Declare two variables of type int. Assign to them values 5 and 10 
             // respectively. Exchange (swap) their values and print them.

             int a = 5;
             int b = 10;
             int sum = a + b;
             int b2 = sum - b;
             int a2 = sum - b2;
             Console.WriteLine($"a:{a2} and b:{b2}");


         









        }
    }
}
