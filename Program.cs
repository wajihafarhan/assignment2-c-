// See https://aka.ms/new-console-template for more information


//1) Write a C# program that takes two numbers as input from the user and performs the following arithmetic operations:
//Addition , Subtraction , Multiplication , Division , Modulus (Remainder)

//Console.Write("Enter the first number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("\nEnter the second number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//double Addition = num1 + num2;
//double Subtraction = num1 - num2;
//double Multiplication = num1 * num2;

//if (num2 != 0)
//{
//    double Division = num1 / num2;
//    double remainder = num1 % num2;

//    Console.WriteLine($"\nSum: {Addition}");
//    Console.WriteLine($"\nDifference: {Subtraction}");
//    Console.WriteLine($"\nProduct: {Multiplication}");
//    Console.WriteLine($"\nQuotient: {Division}");
//    Console.WriteLine($"\nRemainder: {remainder}");
//}
//else
//{
//    Console.WriteLine("Cannot perform division or modulus with the second number being zero.");
//}

//2) Write a C# program to compare two numbers entered by the user and print whether the first number is greater than, less than, or equal to the second number.

//Console.Write("\nEnter the First Number: ");
//int num3 = Convert.ToInt32(Console.ReadLine());

//Console.Write("\nEnter the Second Number: ");
//int num4 = Convert.ToInt32(Console.ReadLine());

//if (num3 == num4)
//{
//    Console.WriteLine("\nThe First Number is Equal to the Second Number.");
//}
//else if (num3 > num4)
//{
//    Console.WriteLine("\nThe First Number is Greater than to the Second Number.");
//}
//else
//{
//    Console.WriteLine("\nThe First Number is Less than to the Second Number.");
//}

//3) Write a C# program to print the multiplication table of a number entered by the user using a loop (for, while, or do-while).

//For Loop

//Console.Write("\nFor Loop: ");
//Console.Write("\nEnter a number to display its multiplication table: ");
//int num5 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"\nMultiplication Table for {num5}:");
//for (int a = 1; a <= 10; a++)
//{
//    int result = num5 * a;
//    Console.WriteLine($"{num5} * {a} = {result}");
//}

//While Loop

//Console.Write("\nWhile Loop: ");
//Console.Write("\nEnter a number to display its multiplication table: ");
//int num6 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"\nMultiplication Table for {num6}:");
//int b = 1;
//while (b <= 10)
//{
//    int result1 = num6 * b;
//    Console.WriteLine($"{num6} * {b} = {result1}");
//    b++;
//}

//Do While loop

//Console.Write("\nDo While Loop: ");
//Console.Write("\nEnter a number to display its multiplication table: ");
//int num7 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"\nMultiplication Table for {num7}:");
//int c = 1;
//do
//{
//    int result2 = num7 * c;
//    Console.WriteLine($"{num7} * {c} = {result2}");
//    c++;
//} while (c <= 10);

//4) Write a C# program to print a pattern of asterisks (*) in the following format using nested loops:
//Console.Write("\nNested Loops: \n\n");
//int rows = 5;

//for (int d = 1; d <= rows; d++)
//{
//    for (int g = 1; g <= d; g++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//5) Write a C# program to find the sum of all even numbers between 1 and 100 using loop control statements (break and continue).
//Console.Write("\nSum_of_Even_Number\n\n");

//int Sum_of_Even = 0;

//for (int f = 1; f < 102; f++)
//{
//    if (f % 2 != 0)
//    {
//        continue;
//    }
//    Sum_of_Even += f;
//    if (f > 50)
//    {
//        break;
//    }
//    Console.WriteLine(f);
//}
//Console.WriteLine("\nSum Of Even Number " + Sum_of_Even);

//6) Write a C# program to reverse a string entered by the user without using any built-in reverse functions or methods.

Console.Write("\nEnter a String to display: ");
string wajiha = Console.ReadLine();

Console.WriteLine($"\nReverse String for {wajiha}:\n");

int length = wajiha.Length;

for (int i = length - 1; i >= 0; i--)
{
    Console.Write(wajiha[i]);
}


//7) Write a C# program to print all the prime numbers between 1 and 100 using a loop and conditional statements.

//Console.WriteLine("\n\nPrime numbers between 1 and 100:");

//for (int number = 2; number <= 100; number++)
//{
//    bool isPrime = true;

//    for (int divisor = 2; divisor < number; divisor++)
//    {
//        if (number % divisor == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.Write($"{number} ");
//    }
//}
