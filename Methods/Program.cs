// See https://aka.ms/new-console-template for more information

// Prototype - Defines the functions (types, name, and parameters)
// Definition - Has the code. It contains the code block
// Function call - Makes the function
// DRY - Don't repeat yourself
// YAGNI - You aren't going to need it

// Void functions - Completes a task and moves along

void PrintName()
{
    Console.WriteLine("Dana Usmanova");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}

// Value returning functions - Completes a task, returns a result

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if (num1 < num2)
    {
        largest = num2;
    }
    if (num2 < num3)
    {
        largest = num3;
    }

    return largest;
}


PrintName();
Console.WriteLine("End of void function");

Console.WriteLine("Enter the number1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);
Console.WriteLine("End of void function");

Console.WriteLine("Enter the number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3); //Console.WriteLine($"The largest number is {LargestNumber(number1, number2, number3)}");
Console.WriteLine($"The largest number is {result}");
