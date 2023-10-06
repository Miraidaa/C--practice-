using System.Globalization;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program to find the area and perimeter of a rectangle. Get the length and width of the rectangle as input from the user. Sample input/output statements are given below:
          Enter the length of the rectangle:  20
         Enter the width of the rectangle: 10
         The area of rectangle is (l x w) = 200
         The perimeter of rectangle is 2(l + w) = 60*/


            /*

            Console.WriteLine("Enter the length of the rectangle : "); 
            int recLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle : ");
            int recWidth = Convert.ToInt32(Console.ReadLine());

            int areaOfRec = recLength * recWidth;
            int perOfRec = 2 * (recLength + recWidth);

            Console.WriteLine("The area of the Rectangle is : " + areaOfRec);
            Console.WriteLine("The perimeter of the Rectangle is : " + perOfRec);
            */


            /*Program 2:
            Write a Program to print the expansion of (a+b)2. Get the values of 'a' and 'b' from the user. Sample input/output statements are given below:
        Enter a: 3
        Enter b: 4
        (3 + 4)^2
         = 3^2 + 2*3*4 + 4^2
         = 9 + 24 + 16 
         = 49*/

            /*
            Console.WriteLine("Enter the value of a : "); 
            int valOfA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b : ");
            int valOfB = Convert.ToInt32(Console.ReadLine());

            double expanOfVals = (Math.Pow (valOfA, 2)) + ( 2 * valOfA * valOfB) + ( Math.Pow (valOfB,2));
            Console.WriteLine("The expansion of the given two values is: " + expanOfVals);
            */



            /*Program 3:
        Write a program to accept the length of all 3 sides of the triangle and then display whether a triangle is a right-angled triangle or not. 
            Sample input/output statements are given below:
   Sample 1:
      Enter Length for Side 1: 10
      Enter Length for Side 2: 10
      Enter Length for Side 3: 20
      The given triangle is not right angled triangle.
   Sample 2:
      Enter Length for Side 1: 10
      Enter Length for Side 2: 24
      Enter Length for Side 3: 26
      The given triangle is a right angled triangle.*/

            /*
            Console.WriteLine("Enter the first side of the triangle : ");
            double firstSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second side of the triangle : ");
            int secondSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third side of the triangle : ");
            int thirdSide = Convert.ToInt32(Console.ReadLine());

            if (Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) == Math.Pow(thirdSide, 2))
            {
                Console.WriteLine("The given triangle is a right angled triangle.");
            }
            else if (Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2))
            {
                Console.WriteLine("The given triangle is a right angled triangle.");
            }
            else if (Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2))
            {
                Console.WriteLine("The given triangle is a right angled triangle.");
            }
            else
            {
                Console.WriteLine("The given triangle is not right angled triangle.");
            }
            */



            /*Program 4:

            A car consumes L liters of petrol on a K km long trip (L and K are given by the user). Calculate the consumption of the car (how many liters it consumes on 100 km). Sample input/output:
            Amount of petrol consumed (liters): 17
            Length of the trip (km): 200
            The consumption of the car is 8.5 (liters / 100km).*/


            /*
            Console.WriteLine("Amount of petrol consumed in liters : "); 
            int consumedL = Convert.ToInt32(Console.ReadLine()) * 100;

            Console.WriteLine("Length of the trip (km) : ");
            int lengthOfTrip = Convert.ToInt32(Console.ReadLine());

            int consumptionOfCar = consumedL / lengthOfTrip;

            Console.WriteLine("The consumption of the car is : " + consumptionOfCar);
            
            */




            /*Program 5:

            There are N kids sharing K apples. Everyone gets the same number of apples and they don't cut them, so there might be some apples left in the basket. 
            The values N and K are given by the user. Calculate how many apples each kid gets, and how many are left. Sample input/output:
            Number of kids: 6
             Number of apples: 26
                Every kid gets 4 apples and there are 2 apples left.*/


            /*
            Console.WriteLine("Enter the number of Kids : "); 
            int numOfKids = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the number of apples : "); 
            int numOfApps = Convert.ToInt32(Console.ReadLine());

            int numOfLeftApp = numOfApps % numOfKids;
            Console.WriteLine("The number of left apples is : " + numOfLeftApp);
            */



            /*Program 6:

            Read two integer numbers from the user input and print the smaller one. Sample input/output:
            Enter two integers: 6 -17
             The smaller number is -17.*/

            /*
            Console.WriteLine("Enter two numbers:");
            string input = Console.ReadLine();
            int firstNum = Convert.ToInt32(input.Split(" ")[0]);
            int secondNum = Convert.ToInt32(input.Split(" ")[1]);


            int theMin = Math.Min(firstNum, secondNum); 
            Console.WriteLine("The smaller number is  : " + theMin);
           */



            /*Program 7:

            You are given an N natural number.  Decide whether N has 3 digits or not. Sample input/output:

            N: 1001
            1001 is not a 3-digit number.*/

            /*

            Console.WriteLine("Enter any natural number : "); 
            int myNum = Convert.ToInt32(Console.ReadLine());

            int lenOfN = myNum.ToString().Length; 
            if (lenOfN == 3 ) {
                Console.WriteLine(myNum + "is a 3-digit number"); 
            } else {
                Console.WriteLine(myNum + " is not a 3-digit number");
            }
            */


            /*Program 8:

            Read two natural numbers. If at least one of them is odd, print "Yes, there is an odd one", otherwise "None of them is odd". Sample input/output:

            Enter two numbers: 60 27
            Yes, there is an odd one.*/

            /*

            Console.WriteLine("Enter two numbers:");
            string input = Console.ReadLine();
            int int1 = Convert.ToInt32(input.Split(" ")[0]);
            int int2 = Convert.ToInt32(input.Split(" ")[1]);

            if (int1 % 2 != 0 || int2 % 2 != 0)
            {
                Console.WriteLine("There is an odd number");
            } else{
                Console.WriteLine("None of them is odd"); 
            }
            
            */






            /*Program 9:

            Given three words, determine the longest one of them. (If there are multiple longest, any of them can be given.) Sample input/output:
            Enter three words: apple banana cherry
            The longest word is banana.*/


            /*
            Console.WriteLine("Enter three words : ");
            string input = Console.ReadLine();
            string word1 = Convert.ToString(input.Split(' ')[0]);
            string word2 = Convert.ToString(input.Split(' ')[1]);
            string word3 = Convert.ToString(input.Split(' ')[2]);

            if (word1.Length > word2.Length && word1.Length > word3.Length)
            {
                Console.WriteLine("The longest word is : " + word1);
            } else if (word2.Length > word1.Length && word2.Length > word3.Length) {
                Console.WriteLine("The longest word is : " + word2);
            }else {
                Console.WriteLine("The longest word is : " + word3);
            }
            */



            /* Program 10:

            Write a program that solves a quadratic equation. Sample input/output:
            In the equation a*x^2 + b*x + c = 0
            the value of a: 4
            the value of b: -4
            the value of c: 1
            The equation has a solution, x = 0.5 */



            
            Console.WriteLine("Give the value of a:");
            
  double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the value of b: ");
     double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the value of c:");
    double  c= Convert.ToInt32(Console.ReadLine());


            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant > 0) {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The equation has two real solutions:");
                Console.WriteLine("x1 = " + root1);
                Console.WriteLine("x2 = " + root2);
            } else if (discriminant == 0) {
                double root = -b / (2 * a);
                Console.WriteLine("The equation has one real solution:");
                Console.WriteLine("x = " + root);
            }else {
                Console.WriteLine("The equation has no real solutions.");
            }

            


        }
    }
}