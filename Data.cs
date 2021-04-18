using System;

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
  
	  Console.WriteLine("Data Inicial: " + startDT.ToString("dd/MM/yyyy"));  
	  Console.WriteLine("Data Final: " + endDT.ToString("dd/MM/yyyy"));  
	  Console.WriteLine();  
	   
	  Console.WriteLine("Lista com incremento de dias formato dd/MM/yyyy..."); 
	  for (int j=0; j<qtdeDias; j++){
		  workDT = workDT.AddDays(1);
		  Console.WriteLine(workDT.ToString("dd/MM/yyyy")); 		   
	  }	   	  	   
	  //Mais formatos em 
	  //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1  	  	  	  	   
   }
}
