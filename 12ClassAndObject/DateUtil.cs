
	internal static class DateUtil  // you can have static methods in a regular class
	{
	// What's your year of birth based on age
	public static int YearOfBirth(int age)
		{
			return DateTime.Now.Year - age;
		}

	// What's your year of bitrh based on date of birth
		public static int YearOfBirth(DateTime dateOfBirth)
		{
			if (dateOfBirth == null)
				return 0;
			return dateOfBirth.Year;
		}

	// Determine your age based on the date of birth
		public static int Age(DateTime dateOfBirth)
		{
			if (dateOfBirth == null)
				return 0;
			return DateTime.Now.Year - dateOfBirth.Year;
		}

}


