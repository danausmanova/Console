// See https://aka.ms/new-console-template for more information

string firstName = "Dana";
string lastName = "Usmanova";
DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine(firstName.ToUpper());
Console.WriteLine("String being printed");

// Concatination
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine($"Your full name is {firstName} {lastName}");
Console.WriteLine("Your full name is " + firstName + " " + lastName);
Console.WriteLine("Yout full name is {0} {1}", firstName, lastName);

// String length
int length = firstName.Length;
Console.WriteLine($"Your first name is {length} letters long");

// Replace string parts
string newName = firstName.Replace('D', 'Y');
Console.WriteLine($"Your new name is {newName}");

string newName1 = firstName.Replace('D', ' ');
Console.WriteLine($"Your new name is {newName1}");

// Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}");

// Split string
string[] splitName = firstName.Split('a');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// Compare string
string nullString = null;
string emptyString = "";//string.Empty
string whitespaceString = " ";

if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}
if (firstName == lastName)
{
    Console.WriteLine("Names are equal");
}
if (firstName != lastName)
{
    Console.WriteLine("Names aren't equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

// Convert to string
string convertedString = null;
int number = 12345543;

convertedString = number.ToString();

