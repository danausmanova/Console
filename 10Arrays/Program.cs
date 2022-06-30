// See https://aka.ms/new-console-template for more information

// Declare fixed size array
int[] grades = new int[5];
// 5 space addresses - 0, 1, 2, 3, 4, 5
// If n is the size of array, then your array has addresses between 0 to n-1

// Add values to Fixed Size Array
/*grades[0] = 12;
grades[1] = 34;
grades[2] = 23;
grades[3] = 54;
grades[4] = 43;*/

//grades = new int[] {12, 23, 22, 43, 54, 34};

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}
// Print values in Fixed Size Array
Console.Write("Entered grades: ");

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

// Declare Variable Sized array
string[] studentsNames = new string[] { "Anna", "Tom", "Bob", "etc..." };

// Add values to variable sized array
for (int i = 0; i < studentsNames.Length; i++)
{
    Console.Write("Enter student Name: ");
    studentsNames[i] = Console.ReadLine();
}

// Print values in Variable Sized array
Console.WriteLine("Entered Students Names:");

for (int i = 0; i < studentsNames.Length; i++)
{
    Console.WriteLine(studentsNames[i]);
}