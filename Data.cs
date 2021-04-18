using System;
using System.Collections.Generic;
using System.Linq;

public class Data {
   public static void Main() {

	  //Quantidade de dias 
	  long qtdeDias = 7;
	  
	  //Data atual							
	  DateTime startDT = DateTime.Today;
	  //Data fim com periodo de dias
	  var endDT = startDT.AddDays(qtdeDias);
	  //Auxiliar
	  var workDT = startDT;
  
	  Console.WriteLine("Lista de dias formato Default..."); 
	  for (int j=0; j<qtdeDias; j++){
		  workDT = workDT.AddDays(1);
		  Console.WriteLine(workDT); 
		   
	  }
	  
	  Console.WriteLine("Lista de dias formato dd/MM/yyyy..."); 	  
	  for (int j=0; j<qtdeDias; j++){
		  workDT = workDT.AddDays(1);
		  Console.WriteLine(workDT.ToString("dd/MM/yyyy")); 
		   
	  }
	  //Mais formatos em 
	  //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1  	  	  	  	   
   }
}
