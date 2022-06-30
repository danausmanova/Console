// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the number of apples: ");
int numberofApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of oranges: ");
int numberofOranges = Convert.ToInt32(Console.ReadLine());

// If statements(==, <, >, <=, >=, !=)
if (numberofApples > numberofOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numberofApples < numberofOranges)
{
    Console.WriteLine("You have more oranges");
}
else if (numberofApples == numberofOranges)
{
    Console.WriteLine("You have the same number of apples and oranges");
}


Console.WriteLine("Enter Your Grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
// Switch statements
switch (grade)
{
    case int n when n <= 59: //case 0:
        Console.WriteLine("You failed");
        break;
    case int n when n > 60 && n <= 100:// between 60 and 100
        Console.WriteLine("You passed");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}
// Ternary Operator
var message = numberofApples > numberofOranges ? "You have more apples" : "You have more oranges";
Console.WriteLine(message);