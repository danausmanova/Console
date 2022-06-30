using System;

// primitive data types
//int, string, char, bool

// Object Oriented Programming - Creating your own datatype

// Single Responsibility Principle - lets each unit has only 1 responsibility

	public class Person
	{
		// Properties when public
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Age { get; set; }
		
		// Fields
		private double _salary { get; set; }

		public void setSalary(double salary)
		{
			_salary = salary;
		}

		public double getSalary()
		{
			return _salary;
		}

		public string getFullName()
		{
			return $"{FirstName} {LastName}";
		}

		public string getFullName(string middleName)
		{
		return $"{FirstName} {middleName} {LastName}";
		}
}


