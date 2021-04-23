using System;
using System.Collections.Generic;

//HashSet - contém um lista não ordenada de itens distintos;
//SortedSet - contém uma lista ordenada de itens distintos;
//Nao foi necessario o metodo Intersect da biblioteca System.Linq

public class Program
{
	public static void Main()
	{						
		//Lista de feriados
		List<DateTime> feriados = new List<DateTime>() { new DateTime(2021, 4, 21), new DateTime(2021, 4, 22), new DateTime(2021, 4, 22) ,new DateTime(2021, 4, 23),new DateTime(2021, 4, 24) }; 		
		
		//Lista distinta de elementos da lista de feriados 
		HashSet<DateTime> distinct = new HashSet<DateTime>( feriados );
		
		//Lista de dias
       		HashSet<DateTime> dias = new HashSet<DateTime>() { new DateTime(2021, 4, 21), new DateTime(2021, 4, 23) };		
		
		Console.WriteLine("Lista de dias");  
	  	foreach (DateTime day in dias) {
		  	Console.WriteLine(day.ToString("dd/MM/yyyy"));		  
	  	}			
		Console.WriteLine("");  
		
		Console.WriteLine("Lista de feriados");  
	  	foreach (DateTime day in feriados) {
		  	Console.WriteLine(day.ToString("dd/MM/yyyy"));		  
	  	}			
		Console.WriteLine("");  
				
		Console.WriteLine("Lista distinta de feriados com HashSet");  
	  	foreach (DateTime day in distinct) {
		  	Console.WriteLine(day.ToString("dd/MM/yyyy"));		  
	  	}			
		Console.WriteLine("");  
				
		//Realiza intersecao entre a lista distinta de feriados com a lista distinta de dias
		distinct.IntersectWith(dias);
		
		Console.WriteLine("Interseção de Lista entre dias e feriados com HashSet");  
	  	foreach (var day in distinct) {
		  	Console.WriteLine(day.ToString("dd/MM/yyyy"));		  
	  	}	
				
	}
}
