using System;
using System.Globalization;

namespace LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Program 1
            /*Let's calculate N! (N! = N factorial = the product of numbers from 1 to N).*/

            /*
            Console.WriteLine("Please Enter desired number : ");
            int num = Convert.ToInt32(Console.ReadLine();
            int store = 1;

            for (int i = 1; i <= num; i++)
            {
                store *= i;
            }
            Console.WriteLine("The factorial of a given number is : " + store);
            */



            //Program2
            /*Compute the sum of the divisors of an N natural number.*/

            /*
            Console.WriteLine("Please Enter desired number : ");
            int num = Convert.ToInt32(Console.ReadLine();
            int divs = 0; 

            for (int i = 1; i <= num; i++) {
                if (num % i == 0 )
                {
                  divs += i;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("The sum of the divisors is : " + divs);
            */


            //Program 3
            /* Compute the sum of the odd divisors of an N natural number.*/

            /*

             Console.WriteLine("Please Enter desired number : ");
             int num = Convert.ToInt32(Console.ReadLine();
             int divs = 0;

             for (int i = 1; i <= num; i++)
             {
                if (num % i == 0 && i % 2 == 1)
                 {
                     divs += i;
                 }
             }

             Console.WriteLine("The sum of the odd divisors of a given number is : " + divs);
             */


            //Program 4
            /*Print the first N square numbers.*/

            /*
            Console.WriteLine("Please Enter desired number : ");
            int num = Convert.ToInt32(Console.ReadLine();

            for (int i = 1; i < num; i++)
            {
                int square = i * i;
                Console.WriteLine(square);
            }
            */


            //Program 5
            /*Print the square numbers that are less than N.*/


            /*
            Console.WriteLine("Please Enter desired number : ");
            int num = Convert.ToInt32(Console.ReadLine();
            int sqrNums = 0;


            for (int i = 1; i <= num; i++)
            {
                if (Math.Pow(i, 2) <= num)
                {
                    Console.WriteLine(Math.Pow(i,2);
                }
            }
            */




            //Program 6 
            /*Print the first N triangle numbers. (The K'th triangle number is 1+2+...+K)*/


            /*
            Console.WriteLine("Please Enter desired number : ");
            int num = Convert.ToInt32(Console.ReadLine();
          

            for (int i = 1; i <= num; i++)
            {
              int  triangleNumber = (i * (i + 1) / 2;
                Console.WriteLine(triangleNumber);
            }
            
            */


            //Program 7 
            /*Given a K number, determine the smallest power of 2 which is bigger than K.*/

            /*
            Console.WriteLine("Please Enter desired number : ");
            int num = Convert.ToInt32(Console.ReadLine();
            int result = 1; 

            while (result < num ) {
                result *= 2; 
            }

            Console.WriteLine(result); 
            */


            //Program 8 

            /*Read an integer and print a line with that number of stars (asterisks).*/

            /*
            Console.WriteLine("Please Enter desired number : ");
             int num = Convert.ToInt32(Console.ReadLine();

            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }

            */




            //Program 9 

            /*Draw a rectangle of w width and l length with '*' characters.*/

            /*
            Console.WriteLine("Enter the width of rectangle :");
            int w = Convert.ToInt32(Console.ReadLine();

            Console.WriteLine("Enter the length of rectagle"); 
            int l= Convert.ToInt32(Console.ReadLine();


            for (int i = 0; i < l; i++) 
            {
                for (int j = 0; j < w; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
           */


            //Program 10 

            /*Give the height and width of a triangle, and print it out like the examples below*/

            /*
            
            Console.WriteLine("Enter the height of the pyramid:");
            int h = Convert.ToInt32(Console.ReadLine();
         

            
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            */

            //Program 11 
            /*Write a computer program that has a menu, and the user can choose which of the tasks the program is going to do. 
            a: adds two numbers
            m: multiplies two numbers
            s: swaps two numbers
            e: exit
            The program should stop when the user chooses 'e', otherwise it should ask the user again what they would like to do.*/



            /*
            Console.WriteLine("Choose one of these letter :\r\n  a: adds two numbers\r\n            m: multiplies two numbers\r\n            s: swaps two numbers\r\n            e: exit");
            Console.WriteLine("Please enter your choice : ");
            string choice = Console.ReadLine();

            if (choice == "a")
            {
                Console.WriteLine("Enter the first num to add : ");
                int firstN = Convert.ToInt32(Console.ReadLine();

                Console.WriteLine("Enter the second num to add : ");
                int secondN = Convert.ToInt32(Console.ReadLine();

                int addNums = firstN + secondN;
                Console.WriteLine("The sum of the numbers you entered is : " + addNums);
            
            } else if (choice == "m") {
                Console.WriteLine("Enter the first num to multiply : ");
                int firstN = Convert.ToInt32(Console.ReadLine();

                Console.WriteLine("Enter the second num to multiply : ");
                int secondN = Convert.ToInt32(Console.ReadLine();

                int prodNums = firstN * secondN;
                Console.WriteLine("The product of the numbers you entered is : " + prodNums);
            } else if ( choice == "s") {
                Console.WriteLine("Enter the first num to swap : ");
                int firstN = Convert.ToInt32(Console.ReadLine();

                Console.WriteLine("Enter the second num to swap : ");
                int secondN = Convert.ToInt32(Console.ReadLine();

                firstN = secondN;
                secondN = firstN; 

                Console.WriteLine("Now when we swapped first number is equl to : " + firstN +  "And the second is : " + secondN); 
            } else if (choice == "e") {
                Console.WriteLine("User wants to exit");
                Environment.Exit(0);
            } else {
                Console.WriteLine("Please choose one letter");
            }
            */


            //Program 12
            /*A mathematician named Ulam proposed generating a sequence of numbers from any positive integer n (n > 0) as follows:

            If n is 1, stop.
            If n is even, the next number is n/2.
            If n is odd, the next number is 3*n + 1.
            Continue with this process until reaching 1.
            Write a program that reads a number and prints the Ulam sequence for it.*/

            /*

            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine();

            if (num == 1)
            {
                Console.WriteLine("Since the num is 1 program will be stopped");
            }
            else
            {
                while (num != 1)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                        Console.WriteLine(num);
                    }
                    else
                    {
                        num = 3 * num + 1;
                        Console.WriteLine(num);
                    }
                }

            }
            */




            //Program 13
            /*Replace all 0's with 5's  in a number!*/

            //Regex.Replace

            /*
           Console.WriteLine("Enter the number with at least 3 0s : ");
           string input = Console.ReadLine();
            string result = Regex.Replace(input, "0", "5"); 
            Console.WriteLine(result);
            */



            //for loop 
            /*
            Console.WriteLine("Enter the number with at least 3 0s : ");
            string input = Console.ReadLine();
            char[] inputChar = input.ToCharArray();

            for (int i = 0; i < inputChar.Length; i++)
            {
               if (inputChar[i] == '0')
                {
                    inputChar[i]  = '5';

                }
            }
            Console.WriteLine(inputChar);
            */

            //Program 14 
            /* Reverse the order of digits in an integer */

            /*
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine();
            int reversedNum = 0; 

            while (num != 0)
            {
                int digit = num % 10;         
                reversedNum = reversedNum * 10 + digit; 
                num = num / 10;              
            }
            */


            //Program 15
            /*Check whether the entered number is an Armstrong number or not.*/



             Console.WriteLine("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int originalNum = num;
                int numOfDigits = num.ToString().Length;
                int sumOfDigits = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    sumOfDigits += (int)Math.Pow(digit, numOfDigits);
                    num /= 10;
                }

                if (sumOfDigits == originalNum)
                {
                    Console.WriteLine($"{originalNum} is an Armstrong number.");
                } else {
                    Console.WriteLine($"{originalNum} is not an Armstrong number.");
                }
            }
        }
    

    s














    }

