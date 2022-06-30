// See https://aka.ms/new-console-template for more information

// Declare list 
List<string> names = new List<string>();
string name = string.Empty;
List<int> grades = new List<int>();
int grade = 0;

// Add values to a list
names.Add("Dana");

Console.WriteLine("Enter Names and Grades");

//while (name != "-1")
//while (name.Equals("-1") == false)
while (!name.Equals("-1") && !grade.Equals(-1))
{
    Console.Write("Enter name: ");
    name = Console.ReadLine();
    Console.Write("Enter grade: ");
    grade = Convert.ToInt32(Console.ReadLine());

    if (!string.IsNullOrEmpty(name) && !name.Equals("-1") && !grade.Equals(-1))
    {
        names.Add(name);
        grades.Add(grade);
        Console.WriteLine($"{name} with grade {grade} was added successfully");

    }
}

// Print values in list
Console.WriteLine("Printing names and grades via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names and grades via foreach");
foreach (string item in names)
{
    Console.WriteLine(item);
}
