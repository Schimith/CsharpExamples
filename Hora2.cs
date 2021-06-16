using System;
					
public class Program
{
	public static void Main()
	{
		
		DateTime d1 = DateTime.Parse("23:30");
		DateTime d2 = DateTime.Parse("00:40:00");
		DateTime d3 = d1.Add(d2.TimeOfDay); 
		Console.WriteLine(d3.TimeOfDay); // 00:10:00
	}
}//https://stackoverflow.com/questions/510778/add-or-sum-of-hours-like-1330000020-133020-but-how
