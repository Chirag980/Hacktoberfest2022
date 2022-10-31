// C# program to illustrate the above concept
using System;
using System.Linq;

class GFG{

static public void Main()
{
	
	// Initializing count variable
	var totalCount = 0;

	// Creating an array of strings
	string[] elements = { "Rem", "Hisoka", "Gon",
						"Monkey D Luffy", "Alvida",
						"Shank" };

	// Invoking count function on the above elements
	totalCount = elements.Count();

	// Displaying the count
	Console.WriteLine(totalCount);
}
}
