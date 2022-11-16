double num01;
double num02;

Console.Write("Input a number: ");
num01 = Convert.ToDouble(Console.ReadLine() );

Console.Write("Input a second number:");
num02 = Convert.ToDouble(Console.ReadLine());

double result = num01 / num02;
Console.WriteLine("The result is " + result); 

// average = (x + y + z) / 3
double number1;
double number2;
double number3;

Console.Write("Input a number: ");
number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a second number: ");
number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a third number: ");
number3 = Convert.ToDouble(Console.ReadLine());

double result2 = (number1 + number2 + number3) / 3;
Console.WriteLine("The average of " + number1 + ", " + number2 + " and " + number3 + " is " + result2);
Console.ReadKey();

// Wait before closing
Console.Clear();
Console.WriteLine("Press key to exit...");
Console.ReadKey();