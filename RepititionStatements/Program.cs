// See https://aka.ms/new-console-template for more information

// For loop (Counter Controlled)

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("I am in a loop");
    Console.WriteLine($"Counter value: {i}");
}

Console.WriteLine();
Console.WriteLine("For loop is finished");

// While loop (Condition Controlled - Pre check)

int n = 10;
while (n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You number is {n}");
}

Console.WriteLine();
Console.WriteLine("While loop is finished");


// Do ... While loop (Condition Controlled - Post check)

do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You number is {n}");
} while (n < 5);

Console.WriteLine();
Console.WriteLine("Do while loop is finished");

// Foreach - Honourable Mention



