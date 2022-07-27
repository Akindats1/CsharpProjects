using System;

namespace Chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 8!");

          //1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.
          Console.WriteLine("-----Question1-----");
          int n= 151, o = 35, p = 43, q = 251, r = 1023, s = 1024;

          ConvertToBinary(n);
          ConvertToBinary(o);
          ConvertToBinary(p);
          ConvertToBinary(q);
          ConvertToBinary(r);
          ConvertToBinary(s);

         
         //  2. Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.

          Console.WriteLine("-----Question2-----");

          string m =  "1111010110011110";
          Console.WriteLine($"{m} to decimal is {Convert.ToInt64(m ,2)}");
          Console.WriteLine($"{m} to hexadecimal is {Convert.ToInt64(m ,2).ToString("X")}");
          Console.WriteLine();

         //   3. Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and 
         //      decimal numeral systems.

          Console.WriteLine("-----Question3-----");

          ConversionToBinaryAndDecimal("FA");
          ConversionToBinaryAndDecimal("2A3E");
          ConversionToBinaryAndDecimal("FFF");
          ConversionToBinaryAndDecimal("5A0E9");
         
         // 4. Write a program that converts a decimal number to binary one.
         Console.WriteLine("-----Question4-----");
         Console.Write("Enter decimal number:");
         int decimalNumber = (int)decimal.Parse(Console.ReadLine());
         string binaryNumber = Convert.ToString(decimalNumber , 2);
         Console.WriteLine($"Binary value: {binaryNumber}");
         Console.WriteLine();

         // 5. Write a program that converts a binary number to decimal one.
         Console.WriteLine("-----Question5-----");
         Console.Write("Enter binary number: ");
         int binaryValue = (int)decimal.Parse(Console.ReadLine());
         int decimalValue = Convert.ToInt32(binaryValue.ToString(), 2);           
         Console.WriteLine($"Decimal Value : {decimalValue} ");
         Console.WriteLine();

         // 6. Write a program that converts a decimal number to hexadecimal one.
         Console.WriteLine("-----Question6-----");
         Console.Write("Enter decimal number: ");
         int decimalNum = (int)decimal.Parse(Console.ReadLine());
         string hexaDecimalValue = (decimalNum.ToString("x"));           
         Console.WriteLine($"Hexadecimal Value : {hexaDecimalValue} ");
         Console.WriteLine();

         // 7. Write a program that converts a hexadecimal number to decimal one.
         Console.WriteLine("-----Question7-----");
         Console.Write("Enter hexadecimal number: ");
         string hexaDecimalNum = Console.ReadLine();
         Console.WriteLine($"Decimal Value : {Convert.ToInt32(hexaDecimalNum , 16)} ");
         Console.WriteLine();

         // 8. Write a program that converts a hexadecimal number to binary one.
          Console.WriteLine("-----Question8-----");
          Console.Write("Enter hexadecimal number: ");
          string hexaDecimalNumber = Console.ReadLine();
          Console.WriteLine($"Binary Value : {Convert.ToString(Convert.ToInt32(hexaDecimalNum , 16) , 2)} ");
          Console.WriteLine();

         // 9. Write a program that converts a binary number to hexadecimal one.
          Console.WriteLine("-----Question8-----");
          Console.WriteLine("Enter binary number: ");
          string binary = Console.ReadLine();
          Console.WriteLine($"Hexadecimal Value : {Convert.ToInt32(binary , 2).ToString("X")}");
          Console.WriteLine();


         















        }

        static void ConversionToBinaryAndDecimal(string number)
        {
            Console.WriteLine($"{number} to binary is {Convert.ToString(Convert.ToInt32(number,16) , 2)}");
            Console.WriteLine($"{number} to decimal is {Convert.ToInt32(number,16)}");
            Console.WriteLine();

        }

        static void ConvertToBinary(int value)
        {
          Console.WriteLine($"{value} to binary is {Convert.ToString(value , 2)}");
        }

      
    }
}
