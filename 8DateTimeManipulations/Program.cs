// See https://aka.ms/new-console-template for more information

// Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1997, 04, 23);
Console.WriteLine("My DOB is " + dateOfBirth);
Console.WriteLine("My DOB is " + dateOfBirth.Date);

Console.WriteLine("Day of week: {0}", dateOfBirth.DayOfWeek);
Console.WriteLine("Day of year: {0}", dateOfBirth.DayOfYear);
Console.WriteLine("Time of Day: {0}", dateOfBirth.TimeOfDay);
Console.WriteLine("Tick: {0}", dateOfBirth.Ticks);
Console.WriteLine("Kind: {0}", dateOfBirth.Kind);

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now is " + now);

// Create a DateTime for a String
DateTime datefromString = DateTime.Parse("01/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The Date from string is " + datefromString);

// Add additional time
Console.WriteLine("One hour from now is " + now.AddHours(1));
Console.WriteLine("One day from now is " + now.AddDays(1));

// Ticks from Date.Time
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only " + dateOnlyOfBirth);

// Time only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time Only " + timeOnly);