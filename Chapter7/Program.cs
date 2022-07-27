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

            // 3. Write a program, which compares two arrays of type char
            //    lexicographically (character by character) and checks, which one is first 
            //    in the lexicographical order.

            Console.WriteLine("-------Question 3------");
            bool arrayEqual = true;
            char[] arrA = new char[5] { 'a', 'j', 'c', 'd', 'e' };
            char[] arrB = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (arrA.Length > arrB.Length) Console.WriteLine("Second array is lexicographicaly first.");
            else if (arrA.Length < arrB.Length) Console.WriteLine("First array is lexicographicaly first.");
            else
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] < arrB[i])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                    if (arrA[i] > arrB[i])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                }

                if (arrayEqual) Console.WriteLine("Arrays are lexicographicaly equal.");
            }

            // 4. Write a program, which finds the maximal sequence of consecutive 
            //    equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.

            Console.WriteLine("-------Question 4------");
             int count = 1, tempCount = 1, number = 0;

            Console.WriteLine("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter  element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[arr.Length-2] != arr[arr.Length - 1]) break;
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
                
            }

            for (int i = 0; i < count; i++) 
            Console.Write("{0}, ", number);
            Console.WriteLine();
            
            // 5. Write a program, which finds the maximal sequence of consecutively 
            // placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

            Console.WriteLine("-------Question 5------");
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

            for (int i = 0; i < arr.Length; i ++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else sames = 1;
            }

            for (int i = bestStart; i < bestSames + bestStart; i++) Console.Write("{0}, ", arr[i]);
            Console.WriteLine();

            // 6. Write a program, which finds the maximal sequence of increasing 
            // elements in an array arr[n]. It is not necessary the elements to be 
            // consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.

            Console.WriteLine("-------Question 6------");
            int counter = 0, tempIndex, tempCounter;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }            

            for (int i = 0; i < length; i++)
            {
                int[] tempResult = new int[length];
                tempIndex = tempCounter = 1;                
                tempResult[0] = arr[i];

                for (int j = i + 1; j < length; j++)
            {                
            	if (arr[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = arr[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && arr[j] > tempResult[tempIndex - 2] && arr[j] < tempResult[tempIndex - 1]) tempResult[tempIndex - 1] = arr[j];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write("{0},", result[i]);

            // 7. Write a program, which reads from the console two integer numbers N
            // and K (K<N) and array of N integers. Find those K consecutive 
            // elements in the array, which have maximal sum.

            Console.WriteLine("-------Question 7------");
            int sum = 0;

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K (K < N): ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i ++) sum += arr[i];

            Console.WriteLine("\nBiggest sum is {0}", sum);
            Console.WriteLine();

            // 8. Sorting an array means to arrange its elements in an increasing (or 
            // decreasing) order. Write a program, which sorts an array using the 
            // algorithm "selection sort".

            Console.WriteLine("-------Question 8------");
            int i, j, iMin, temp;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (j = 0; j < length - 1; j++)
            {
                iMin = j;

                for (i = j + 1; i < length; i++) if (arr[i] < arr[iMin]) iMin = i;

                if (iMin != j)
                {
                    temp = arr[j];
                    arr[j] = arr[iMin];
                    arr[iMin] = temp;
                }
            }

            for (i = 0; i < length; i++) 
            Console.Write("{0} ", arr[i]);

            // 9. Write a program, which finds a subsequence of numbers with 
            // maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11

            Console.WriteLine("-------Question 9------");
            int sum = 0, tempSum;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                tempSum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > sum) sum = tempSum;
                }
            }

            Console.WriteLine("Result is {0}. ", sum);

            // 10. Write a program, which finds the most frequently occurring element in 
            // an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).

            Console.WriteLine("-------Question 10------");
            int counter = 0, tempCounter = 1, foundNumber = 0;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCounter++;
                else tempCounter = 1;
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    foundNumber = arr[i];
                }
            }

            Console.WriteLine("{0} was found {1} times.", foundNumber, counter);
            Console.WriteLine();


            // 11. Write a program to find a sequence of neighbor numbers in an array, 
            // which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8},
            // S=11  {4, 2, 5}.

            Console.WriteLine("-------Question 11------");
            int sum = 0, start = 0, end = 0;
            bool sumFound = false;

            Console.Write("Enter S: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                sum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        start = i;
                        end = j;
                        sumFound = true;
                        break;
                    }
                }

                if (sumFound) break;
            }

            if (sumFound) for (int i = start; i <= end; i++) Console.Write("{0},", arr[i]);
            Console.WriteLine();

            // 12. Write a program, which creates square matrices like those in the 
            // figures below and prints them formatted to the console. The size of the 
            // matrices will be read from the console. See the examples for matrices 
            // with size of 4 x 4 and make the other sizes in a similar fashion:

            Console.WriteLine("------Question 12a-----");
            Console.Write("Enter Number of Rows ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter Number Of Column ");
            int column = int.Parse(Console.ReadLine());
            int[,] myArray = new int[row, column];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        myArray[i, j] = i + 1;
                    }
                    else
                    {
                        myArray[i, j] = myArray[i, j - 1] + row;
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }











            






            
                            

            









           


        }
    }
}
