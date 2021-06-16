using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<string> list = new List<string>();
		DateTime start = DateTime.Today;				
	    DateTime end = DateTime.Today.AddDays(1);

		while (end > start)
		{
    		list.Add(start.ToString("HH:mm"));
   			start = start.AddMinutes(30);
		}	
	
		foreach (string hora in list)
			Console.WriteLine(hora);
	}
}//https://stackoverflow.com/questions/30755563/storing-datetimes-in-30-min-intervals-to-array
