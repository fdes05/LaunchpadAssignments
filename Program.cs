using System;
using System.Collections;

namespace LaunchpadAssigment1
{
    class Program
    {
        static void Main(string[] args)
        {
			


			/*
			Instructions
			The following should all be executed using a simple .NET Core 3.1 or 5 console application.

			1. OPERATOR
			Input 2 numbers.Display the result of operator on console
			Input:
						Enter first number: 6
				Enter second number: 5
			Output:
						6 + 5 = 11
			6 - 5 = 1
			6 * 5 = 30
			6 / 5 = 1
			6 % 5 = 1
			*/

			var A = 6;
				var B = 5;

				Console.WriteLine($"{A} - {B} = {A - B} \n"+
								  $"{A} * {B} = {A * B} \n"+
								  $"{A} / {B} = {A / B} \n"+
								  $"{A} % {B} = {A % B} \n");

			Console.WriteLine();

			/*
			2. Input first name and last name. Display full name on console
			Input:
				Enter your first name: Tom
				Enter your last name: Jerry
				Output:
				Your full name is:  Tom Jerry
			*/

			Console.WriteLine("Enter your first name:");
			var firstName = Console.ReadLine();
			Console.WriteLine("Enter your last name:");
			var lastName = Console.ReadLine();
			Console.WriteLine($"Your full name is: {firstName} {lastName}");

			Console.WriteLine();

			/*
			3. Convert Celsisus to Fahrenheit, (0°C × 9 / 5) +32 = 32°F
			 Input:
				Input celsius:  10
			Output:
					Fahrenheit: 50
			*/

			Console.WriteLine("10 degrees celcius are....");
			int celcius = 10;
			var fahrenheit = (celcius * 9 / 5) + 32;
			Console.WriteLine($"Farenheit: {fahrenheit}");

			Console.WriteLine();

			/*
			IF - STATEMENT
			1. Input your age.Display your age and stages likes this pattern
			< 1     Baby
			2-> 3      Toddler
			4 - > 12 Kid
			13-> 18    Teenager
			19-> 60    Adult
			> 60        Senior
			Input:
			Enter your age: 5
			Output:
						Your age is 5.You are kid
			*/

			Console.WriteLine("What is your age?");
			var age = int.Parse(Console.ReadLine());
			
			if (age <= 1)
            {
				Console.WriteLine($"Your age is {age}. You are a baby.");
            }
			else if(age == 2 || age <= 3)
			{
				Console.WriteLine($"Your age is {age}. You are a toddler.");

			}
			else if (age == 4 || age <= 12)
			{
				Console.WriteLine($"Your age is {age}. You are a kid.");

			}
			else if (age == 13 || age <= 18)
			{
				Console.WriteLine($"Your age is {age}. You are a teenager.");

			}
			else if (age == 19 || age <= 60)
			{
				Console.WriteLine($"Your age is {age}. You are an adult.");

			}
            else
            {
				Console.WriteLine($"Your age is {age}. You are a senior.");
			}
			Console.WriteLine();

			/*
			2. Input 2 numbers.Show the comparison of 2 numbers on console
			Input:
				Enter first number: 5
				Enter second number: 4
			Output:
						5 > 4
			*/

			Console.WriteLine("Enter first number to show comparison of two numbers:");
			var firstNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter second number:");
			var secondNumber = int.Parse(Console.ReadLine());

			if (firstNumber > secondNumber)
            {
				Console.WriteLine($"{firstNumber} > {secondNumber}");
            }
            else
            {
				Console.WriteLine($"{secondNumber} > {firstNumber}");
			}
			Console.WriteLine();

			/*
			3. Input the year and print whether that year is a leap year or not.
			A year is a leap year if the following conditions are satisfied: Year is multiple of 400 and year is multiple of 4 and not multiple of 100.
			
			Microsoft definition:
			Any year that is evenly divisible by 4 is a leap year: for example, 1988, 1992, and 1996 are leap years.

			However, there is still a small error that must be accounted for. To eliminate this error, the Gregorian 
			calendar stipulates that a year that is evenly divisible by 100 (for example, 1900) is a leap year only
			if it is also evenly divisible by 400.
			Input:
				Input the year: 2016
			Output:
						2016 is a leap year
			*/

			Console.WriteLine("Enter a year:");
			var year = int.Parse(Console.ReadLine());
			if( year % 4 == 0 && year % 100 != 0)
				
			{
				Console.WriteLine($"{year} is a leap year");
			}
			else if (year % 400 == 0)
			{
				Console.WriteLine($"{year} is a leap year");
			}
            else
            {
				Console.WriteLine($"{year} is not a leap year");
			}
			Console.WriteLine();

			/*
			4. Check n is divisor of m or not
					Input:
				m = 10
				n = 2
			Output:
						2 is divisor of 10
			*/

			Console.WriteLine("Enter a number:");
			var number = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter divisor number:");
			var divisor = int.Parse(Console.ReadLine());

			if(number % divisor == 0)
            {
				Console.WriteLine($"{divisor} is divisor of {number}");
            }
            else
            {
				Console.WriteLine($"{divisor} is not divisor of {number}");

			}
			Console.WriteLine();

			/*
			5. Input 2 numbers.Show the maximum and minimum number on console
			Input:
						Enter first number: 5
				Enter second number: 4
			Input:
						Maximum number is 5
				Minimum number is 4
			*/

			Console.WriteLine("Compare two numbers by entering first number:");
			var firstNumber2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter second number:");
			var secondNumber2 = int.Parse(Console.ReadLine());

			if (firstNumber2 > secondNumber2)
			{
				Console.WriteLine($"Maximum number is {firstNumber2} \nMinimum number is {secondNumber2}");
			}
			else
			{
				Console.WriteLine($"Maximum number is {secondNumber2} \nMinimum number is {firstNumber2}");
			}
			Console.WriteLine();

			/*
			6. Input 3 numbers.Display the list of number from lowest to highest
			Input:
				Enter first number: 20
				Enter second number: 60
				Enter third number: 10
			Output:
						10, 20, 60
			*/

			//THIS IS WHERE ARRAY SORT OR OTHER SORTING FUNCTIONS WOULD MAKE MORE SENSE 

			Console.WriteLine("Sort numbers by entering first number of three:");
			var firstNumber3 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter second number:");
			var secondNumber3 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter third number:");
			var thirdNumber3 = int.Parse(Console.ReadLine());

			if (firstNumber3.CompareTo(secondNumber3 ) == 1)
            {
				if(firstNumber3.CompareTo(thirdNumber3) == 1)
                {
					if (secondNumber3.CompareTo(thirdNumber3) == 1)
                    {
						Console.WriteLine($"{thirdNumber3}, {secondNumber3}, {firstNumber3}");
                    }
                    else
                    {
						Console.WriteLine($"{secondNumber3}, {thirdNumber3}, {firstNumber3}");
					}
                }
                else
                {
					Console.WriteLine($"{secondNumber3}, {firstNumber3}, {thirdNumber3}");
				}
            }
            else
            {
				if(secondNumber3.CompareTo(thirdNumber3) == 1)
                {
					if(thirdNumber3.CompareTo(firstNumber3) == 1)
                    {
						Console.WriteLine($"{firstNumber3}, {thirdNumber3}, {secondNumber3}");
					}
                    else
                    {
						Console.WriteLine($"{thirdNumber3}, {firstNumber3}, {secondNumber3}");
					}
                }
                else
                {
					Console.WriteLine($"{firstNumber3}, {secondNumber3}, {thirdNumber3}");
				}
            }
			Console.WriteLine();

			/*
			7. Find x  in function ax2 +bx + c = 0
			Input:
						a = 1
				b = 3
				c = 2

				x1 = ((-b + 1) Math.Sqrt(Math.Pow(b,2) - 4ac)) / 2a
				x2 = ((-b - 1) Math.Sqrt(Math.Pow(b,2) - 4ac)) / 2a
			Output:
						x1 = -1
				x1 = -2
			*/

			gettingx1x2(1, 3, 2);
            void gettingx1x2(int a, int b, int c)
            {
				double x1 = (-b + 1) * Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a); ;
				double x2 = (-b - 1) * Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a);
				Console.WriteLine($"x1 is {x1} and x2 is {x2}\n");

			}
			Console.WriteLine();


			/*
			8. Find x and y, using Cramer's rule 2 linear equations

			Input:
						a1, b1, c1, a2, b2, c2
				   Output:
				x = ?
				y = ?

			x = Dx/D = (c1b2 - c2b1) / (a1b2 - a2b1)
			y = Dy/D = (a1c2 - a2c1) / (a1b2 - a2b1)
			*/

			findxandy(4, -3, 11, 6, 5, 7);

            void findxandy(int a1, int b1, int c1, int a2, int b2, int c2)
            {
                var x = ((c1 * b2) - (c2 * b1)) / ((a1 * b2) - (a2 * b1));
                var y = ((a1 * c2) - (a2 * c1)) / ((a1 * b2) - (a2 * b1));
                Console.WriteLine($"x is {x} and y is {y}");
            }
			Console.WriteLine();

			/*
			SWITCH CASE

			1. Input day number in integer and display day name in the word
			Input:
						Input day number: 1
			Output:
						Monday

					Input month number in integer and display month name in the word
			Input:
						Input month number: 10
			Output:
						January
			*/

			Console.WriteLine("Input day of the week in number. e.g. Tuesday = 2");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("This is no a valid entry!");
                    break;
            }

            Console.WriteLine("Input month of as number. e.g. March = 3");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
				case 1:
					Console.WriteLine("January");
					break;
				case 2:
					Console.WriteLine("February");
					break;
				case 3:
					Console.WriteLine("March");
					break;
				case 4:
					Console.WriteLine("April");
					break;
				case 5:
					Console.WriteLine("May");
					break;
				case 6:
					Console.WriteLine("June");
					break;
				case 7:
					Console.WriteLine("July");
					break;
				case 8:
					Console.WriteLine("August");
					break;
				case 9:
					Console.WriteLine("September");
					break;
				case 10:
					Console.WriteLine("October");
					break;
				case 11:
					Console.WriteLine("November");
					break;
				case 12:
					Console.WriteLine("December");
					break;
				default:
					Console.WriteLine("This is not a valid entry!");
					break;
			}
			Console.WriteLine();

			/*
             
			LOOPS

			1. Input n, n is natural number, display the list of number from 0 to n
			Intput:
						n = 11
			Output:
						1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11.
			*/
			Console.WriteLine("Enter a number n to display the list of numbers from 0 to n:");
			var n1 = int.Parse(Console.ReadLine());

			for (var i = 1; i <= n1; i++)
			{
				Console.Write($"{i}, ");
			}
			Console.WriteLine();


            /*
			2. Input n, display the multiplication table of n
			Input:
				n = 2
			Output
				2 x 1 = 2
				…………
				2 x 10 = 20
			*/

            Console.WriteLine("Enter the number n to display the multiplication table n:");
            var n2 = int.Parse(Console.ReadLine());

            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n2} x {i} = {n2 * i}");
            }
			Console.WriteLine();

			/*
			3. Input n, n is natural number,  calculate the sum of number from 1 to n
			Input:
						n = 4
			Output:
						1 + 2 + 3 + 4 = 10
			*/

			Console.WriteLine("Enter a number n to calculate the sum from 1 to n:");
			var n3 = int.Parse(Console.ReadLine());
			int sum3 = 0;


			for (var i = 1; i <= n3; i++)
			{
				sum3 += i;
				if (i < n3)
				{
					Console.Write($"{i} + ");
				}
				else
				{
					Console.Write($"{i} = {sum3}");
				}

			}
			Console.WriteLine();

			/*
			4. Input n, n is natural number,  calculate the average all numbers from 1 to n
			Output:
						n = 4
			Output:
						(1 + 2 + 3 + 4) / 4 = 2.5
			*/

			Console.WriteLine("Enter a number n to calculate the average from 1 to n:");
			var n4 = int.Parse(Console.ReadLine());
			Console.Write("(");
			double sum4 = 0;

			for (double i = 1; i <= n4; i++)
			{
				sum4 += i;
				if (i < n4)
				{
					Console.Write($"{i} + ");
				}
				else
				{
					double average = (sum4 / i);
					Console.Write($"{i}) / {i} = {average}");
				}

			}
			Console.WriteLine();

			/*
			5. Input n, n is natural number,  display the sum of odd numbers from 1 to n
			Input:
						n = 4
			Output:
						1 + 3 = 4
			*/

			Console.WriteLine("Enter a number n to calculate the sum of odd numbers from 1 to n:");
			var n5 = int.Parse(Console.ReadLine());
			double sum5 = 0;

			if (n5 % 2 != 0)
			{
				for (int i = 1; i <= n5; i++)
				{
					if (i % 2 != 0 && i != n5)
					{
						sum5 += i;
						Console.Write($"{i} + ");
					}
					else if (i == n5)
					{
						sum5 += i;
						Console.Write($"{i} = {sum5}");
					}
				}
			}
			else
			{
				for (int i = 1; i <= n5; i++)
				{
					if (i % 2 != 0 && i != n5 - 1)
					{
						sum5 += i;
						Console.Write($"{i} + ");
					}
					else if (i == n5 - 1)
					{
						sum5 += i;
						Console.Write($"{i} = {sum5}");
					}
				}
			}

			Console.WriteLine();

			/*
			6. Input n, n is natural number,  display the avagate of all event numbers from 1 to n
			Input:
				n = 4
			Output:
				(2 + 4) / 2 = 3
			*/

			Console.WriteLine("Enter a number n to calculate the average of all even numbers from 1 to n:");
			var n6 = int.Parse(Console.ReadLine());
			Console.Write("(");
			double sum6 = 0;


			if (n6 % 2 == 0)
			{
				int evenNumbersCount = 0;

				for (double i = 1; i <= n6; i++)
				{
					if (i % 2 == 0 && i != n6)
					{
						sum6 += i;
						evenNumbersCount += 1;
						Console.Write($"{i} + ");
					}
					else if (i == n6)
					{
						sum6 += i;
						evenNumbersCount += 1;
						double average1 = sum6 / evenNumbersCount;
						Console.Write($"{i}) / {evenNumbersCount} = {average1}");
					}
				}
			}
			else //n6 is odd
			{
				int oddNumbersCount = 0;

				for (double i = 1; i <= n6; i++)
				{
					if (i % 2 == 0 && i != n6 - 1)
					{
						sum6 += i;
						oddNumbersCount += 1;
						Console.Write($"{i} + ");
					}
					else if (i == n6 - 1)
					{
						sum6 += i;
						oddNumbersCount += 1;
						double average2 = sum6 / oddNumbersCount;
						Console.Write($"{i}) / {oddNumbersCount} = {average2}");
					}
				}
			}

			Console.WriteLine();


			/*
			7. Input n, n is  natural number, display all n of dividtor  from 1 to n
			Input:
				n = 10
			Output:
				1, 2, 5, 10
			*/

			Console.WriteLine("Enter a number n to display all divisors from 1 to n:");
			var n7 = int.Parse(Console.ReadLine());
			ArrayList divisorList = new ArrayList();

			for (int i = 1; i <= n7; i++)
			{
				if (n7 % i == 0)
				{
					divisorList.Add(i);
				}
			}
			foreach (var item in divisorList)
			{
				Console.Write($"{item}, ");
			}

			Console.WriteLine();


			/*
			8. Input n, display the squart asterisk with n column and row.
			Input:
				n = 4
			Output:
				*  *  *  *
				*  *  *  *
				*  *  *  *
				*  *  *  *
			*/

			Console.WriteLine("Enter a number n to display square asterisks with n columns and rows:");
			var n8 = int.Parse(Console.ReadLine());

			for (var i = 0; i < n8; i++) //for the rows
			{
				for (var j = 0; j < n8; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}

			Console.WriteLine();

			//Console.WriteLine("Enter a number n to display square asterisks with n columns and rows:");
			//var n8 = int.Parse(Console.ReadLine());

			//for(var i = 0; i < n8; i++) //for the rows
			//         {
			//	for(var j = 0; j < n8; j++)
			//             {
			//		Console.Write("* ");
			//             }
			//         }


			/*
			9. Input n, display the border squart asterisk with n column and row.
			Input:
				n = 4
			Output:
				*  *  *  *
				*         *
				*         *
				*  *  *  *
			
			10. Input n, display the border squart asterisk with n column and row and its diagonal line . 
			Input:
				n = 6
			Output:
			*   *   *   *   *   *
			*   *            *   *
			*       *   *        *
			*       *   *        *
			*   *            *   *
			*   *   *   *   *   *
			 
			11. Input n row and m column, display the rectangle asterisk with n row and m column.
			Input:
				row = 4
				column = 6
			Output:
			*  *  *  *  *  *
			*  *  *  *  *  *
			*  *  *  *  *  *
			*  *  *  *  *  *


			12. Input n row and m column, display the border rectangle  asterisk with n row and m column.
			Input:
				row = 4
				column = 6
			Output:
			*  *  *  *  *  * 
			*                *
			*                *
			*  *  *  *  *  *
			 
			13. Input n, display the right angle triangle asterisk
			Input:
				n = 4
			Output:
			* 
			*  * 
			*  *  * 
			*  *  *  *

			14. Input n, display the left angle triangle asterisk
			Input:
				n = 4
			Output:
			*  *  *  * 
			*  *  *
			*  * 
			*  

			15. Input n, display the pine asterisk
			Input:
				n = 5
			Output:
				    *  
			      *   *
			    *   *   *
			  *  *   *   * 
			*  *   *   *  *
			 
			16. Input n, display the diamond asterisk
			Input:
				n = 5
			Output:
				     *  
			       *   *
			     *   *   *
			   *  *   *   * 
			  *  *   *   *  *
			    *  *   *   * 
			     *   *   *
				   *   *
				     *  
			 
			17. Input n, display likes pattern
			1
			1 2
			1 2 3
			1 2 3 4
			 
			18. Input n, display likes pattern
			1
			2 2
			3 3 3 
			4 4 4 4
			 
			19. Input n, display likes pattern
			1
			2 3
			4 5 6 
			7 8 9 10
			
			20. Input n, display likes pattern
					 1 
				   2   3
			     4   5   6 
			   4   8   9  10
			
			21. Input n, display likes pattern
			Input:
				n = 4
			Output:
			1   1   1   1  1  1  1  1
			1   2   2   2  2  2  2  1 
			1   2   3   3  3  3  2  1 
			1   2   3   4  4  3  2  1
			1   2   3   4  4  3  2  1
			1   2   3   3  3  3  2  1
			1   2   2   2  2  2  2  1
			1   1   1   1  1  1  1  1  
			 
			22. Input n as UInt, convert n to binary
			Input:
				n = 2
			Output:
				10
			 
			23. Input n as integer, convert n to Octal
			Input:
				n = 10
			Output:
				12

			24. Input n as integer, convert n to Hex
			Input:
				n = 10
			Output:
				A
			 
			25. Input s as Binary String, convert s to Int
			Input:
				s = 10
			Output:
				2
			 
			26. Input s as Oct String, convert s to Int
			Input:
				s = 12
			Output:
				10
			 
			27. Input n, calculate the sum of the series 1 +11 + 111 + 1111 + .. n terms
			Input:
				n = 5
			Output:
				1 + 11 + 111 + 1111 + 11111 = 12345
			 Input n, list all primer number from 1 to n
			
			28. Input:
				n = 10
			Output:
				1, 2, 3, 5, 7
			 
			29. Input n, display Pascal’s triangle (*)
			Input:
				n = 5
			Output:
					1
				  1   1 
				1   2   1 
			  1   3   3   1
			1   4   6   4   1

			30. Input n, display Fibonacci series.
			Input:
				n = 10
			Output:
				 0 1 1 2 3 5 8 13 21 34

			31. Input n, reverse n (Don’t use string)
			Input:
				n = 12345
			Output:
				54321

			32. Input n, check n is palindrome or not
			Input:
				n = 12521
			Output: 
				12521 is a palindrome number.

			33. Input n and m, find the greatest common divisor of n and m
			Input:
				n = 15
				m = 20
			Output:
				 The greatest common divisor of 15 and 20 is 5
			 
			34. Input n and m, find the less common multiple of n and m
			Input:
				n = 15
				m = 20
			Output:
				 The less common multiple of 15 and 20 is 60
			 
			35. Input s as String, display revert s
			Input:
				s = ”hello”
			Output:
				”olleh”

			36. Input s as String,  convert s to upper case
			Input:
				s = ”hello”
			Output:
				”HELLO”
			 
			37. Input s as String,  convert s to lower case
			Input:
				s = ”HELLO”
			Output:
				”hello”

			 38. Input s as String,  convert s to first upper case (Title)
			Input:
				s = ”hello”
			Output:
				”Hello”

			39. Old McDonald has a total of 36 animals including  duck and cow.There are 100 animal’s legs.How many ducks and cows does he have? Make a program to count the ducks and cows.
			
			
			
			Array

			1. Input Int array with n element, display all element on console
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = 3

			   a[2] = 2
			Output:
				1, 3, 2
			Input Int array with n element, sort array, display all element on console
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = 3

			   a[2] = 2
			Output:
				1, 2, 3
			Input Int array with n element, calculate the sum of array
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = 3

			   a[2] = 2
			Output:
				1 + 3 + 2 = 6 
			Input Int array with n element, calculate the sum of even number in array
			Input:

			   n = 4

			   a[0] = 1

			   a[1] = 3

			   a[2] = 2

			   A[3] = 4
			Output:
				2 + 4 = 6
			Input Int array with n element, find the max value
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = 3

			   a[2] = 2
			Output:

			   Max value is 3
			Input Int array with n element, find the min value
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = 3

			   a[2] = 2
			Output:

			   Min value is 1
			Input Int array with n element, remove duplicate value in array
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = 2

			   a[2] = 2
			Output:
				1 2
			Input Int array with n element, find duplicate value in array
			Input:

			   n = 5

			   a[0] = 1

			   a[1] = 2

			   a[2] = 2

			   a[3] = 1

			   a[4] = 5
			Output:
				1, 2
			Input Int array with n element, find the second largest element
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = 2

			   a[2] = 3
			Output:
				2
			Input Int array with n element, find the second smallest element
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = 2

			   a[2] = 2
			Output:
				2
			Input Int array with n element, find the first negative number
			Input:

			   n = 3

			   a[0] = 1

			   a[1] = -2

			   a[2] = -3
			Output:
				-2
			Input Int matrix with n row and n column, calculate the sum of each row
			Input:

			   n = 3
				1 1 8
				5 4 7
				7 7 6


			Output:

			   Row 1: 10

			   Row 2: 16

			   Row 3: 20
			Input Int matrix with n row and n column, calculate the sum of each column
			Input:

			   n = 3
				1 1 8
				5 4 7
				7 7 6


			Output:

			   Col 1: 13

			   Col 2: 12

			   Col 3: 21
			Input Int matrix with n row and m column, calculate sum of matrix
			Input:

			   n = 2

			   m = 2 
				1 5
				2 3


			Output:
				1 + 5 + 2 + 3 = 11
			Input Int matrix with n row and m column, sort the matrix
			Input:

			   n = 2

			   m = 2 
				1 5
				2 3


			Output:
				1 2
				3 4
			Input Int matrix with n row and n column, revert matrix
			Input:

			   n = 3
				1 5 4
				2 3 9
				8 7 6


			Output:
				6 7 8
				9 3 2
				4 5 1
			Input Int matrix with n row and n column, find the max in each column
			Input:

			   n = 3
				1 5 4
				2 3 9
				8 7 6


			Output:

			   Col 1: 8

			   Col 2: 7

			   Col 3: 9
			Input Int matrix with n row and n column, find the queen number. The queen number is the max number in both row and column
			Input:

			   n = 3
				1 5 4
				2 3 9
				8 7 6


			Output:

			   [1,2] = 9
				[2,0] = 8
			Input Int matrix with n row and n column, change column to row
			Input:

			   n = 3
				1 5 4
				2 3 9
				8 7 6


			Output:
				1 2 8
				5 3 7
				4 9 6
			Create Int matrix with n row and n column, like parten
			Input:

			   n = 3


			Output:
				1 1 1
				2 2 2
				3 3 3
			Create Int matrix with n row and n column, like parten
			Input:

			   n = 4


			Output:
				1 2 3 4
				2 3 4 3
				3 4 3 2
				4 3 2 1

			Create Int matrix with n row and n column, like parten
			Input:

			   n = 4


			Output:
				1 2 3 4
				2 1 2 3
				3 2 1 2
				4 3 2 1

			Create Int matrix with n row and n column, like parten
			Input:

			   n = 5


			Output:
				01 02 03 04 05
				16 17 18 19 06
				15 24 25 20 07
				14 23 22 21 08
				13 12 11 10 09
			Input Int matrix with n row and n column, determine array increases continuously or not
			Input:

			   n = 3
				1 1 3
				5 5 7
				7 7 9


			Output:

			   Array increases continuously
			Input Int matrix with n row and n column, find the max and min value
			Input:

			   n = 3
				1 1 3
				5 5 7
				7 7 9


			Output:

			   Max is 9

			   Min is 1
			Input Int matrix with n row and n column, count zero in array
			Input:

			   n = 3
				1 1 0
				5 0 7
				7 7 0


			Output:

			   Found 3 zero
			Input 2 Int matrices with same n row and n column, calculate the sum of 2 matrices.C[i, j] = A[i, j] + B[i, j] with i = 1,..., N, and j = 1,..., M

			Input Int matrix with n row and n column, list of prime number in array
			Input:

			   n = 3
				1 1 8
				5 4 7
				7 7 6


			Output:
				1, 5, 7
			Function
			Make a power function: power(Double x, Int n) -> Double
			Input:

			   power(7,3)
			Output:
				343

			Make a maximum function: max(Int x, Int n) ->Int
			Input:
				max(7,3)
			Output:
				7

			Implement assignment 6 in IF-Statement by function

			Make a function to check the number is prime number or not: isPrimeNumber(Int x) ->Bool
			Input:
				isPrimeNumber(3)
			Output:
				true 

			Make a function to calculate sum of Int array: sum([Int]) -> Double
			Input:
			let a[Int] = [1, 2, 3, 4]
				sum(a)
			Output:
				10

			Make a function to calculate average of Int array: avergate([Int]) -> Double
			Input:
			let a[Int] = [1, 2, 3, 4]
				average(a)
			Output:
				2.5

			Make a function to convert number to string: numberToString(Int: n) -> String, n< 1,000,000
			Input:
				numberToString(121)
			Output:
				One Hundred Twenty One

			Make a power function: power(Double x, Int n) -> Double
			Input:
				power(7,3)
			Output:
				343

			Make a function to calculate factorial of n: factorial(Int n) -> Int
			Input:
				factorial(4)
			Output:
				24
			Class
			Create Subjects and Students Class
			Class: Subjects
				Property:
			name: String
			point: Float
					Construction:
			init()
			init(name: String, point: Float)

					Method:
			setName(name: String)
			getName() -> String
			setPoint(point: Float)
			getPoint() -> Float

			Class: Students
				Property:
			fistName: String
			lastName: String
			math: Subjects
			chemistry: Subjects
			physic: Subjects

				Construction:
			init()
			init(firstName: String, lastName: String)

					Method:
			setFirstName(name: String)
			getFirstName() -> String
			setLastName(name: String)
			getLastName() -> String
			getFullName() -> String
			setMath(subject: Subjects)
			getMath() -> Subjects
			setChemistry(subject: Subjects)
			getChemistry() -> Subjects
			setPhysic(subject: Subjects)
			getPhysic() -> Subjects
			getAvergate() -> Float // average of math, chemistry and physics

			Create Shapes, Circles, Squares Class and ShapeProtocol
			Class: Shapes
					Property:
			Private color: Int
					Construction:
			init()
			init(color: Int)
					Method:
			setColor(color: Int)
			getColor() -> Int

			Class: ShapeProtocol
					Method:
			getArea() -> Float

				Class: Circles: Shapes, ShapeProtocol
					Property:
			Private radius: Float
			Construction:
			init()
					Method:
			setRadius(radius: Float)
			getRadius() -> Float

				Class: Squares: Shapes, ShapeProtocol
					Property:
			Private edge: Float
			Construction:
			init()
					Method:
			setEdge(edge: Float)
			getEdge() -> Float
			*/

		}
    }
}
