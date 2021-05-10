using System;
using System.Linq;
using System.Collections.Generic;
					
public class ListaIntersect
{
	public static void Main()
	{
		List<string> store1 = new List<string>{ "apple", "orange" };
		List<string> store2 = new List<string>{ "apple", "lemon" };
		
		IEnumerable<string> duplicates =  store1.Intersect(store2);
		
		foreach (var product in duplicates)
			Console.WriteLine(product);
		
		var listB = new List<int>{3, 4, 5};  
        	var listA = new List<int>{1, 2, 3, 4, 5};
       		var listFinal = listA.Intersect(listB);
		
		foreach (var product in listFinal)
			Console.WriteLine(product);
	}
}
