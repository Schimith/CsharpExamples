using System;
using System.Linq;
using System.Collections.Generic;

public class DataManipulation {   	
   
   public static IEnumerable<DateTime> ListDays(DateTime start, DateTime end){
	   for(var day = start.Date; day.Date <= end.Date; day = day.AddDays(1))
       yield return day;
   }


   public static void Main() {  
	  //Data atual							
	  DateTime startDT = new DateTime(2021, 4, 18);
	  //Data fim 
	  var endDT = new DateTime(2021, 4, 25);
	  //Auxiliar
	  var workDT = startDT;
	   
	  //Feriado unico de exemplo
	  var feriado = new DateTime(2021, 4, 22);	 
	   
	  //Lista de feriados
	  //DateTime[] feriados = {new DateTime(2021, 4, 22), new DateTime(2021, 4, 23) };	  
	  List<DateTime> feriados = new List<DateTime>() { new DateTime(2021, 4, 22),new DateTime(2021, 4, 23) }; 	  
	  //feriados.Add(new DateTime(2021, 4, 22));
	  //feriados.Add(new DateTime(2021, 4, 23)); 
	   
	  //Lista de dias
	  //0-Sun, 1-Mon, 2-Tue, 3-Wed, 4-Thu, 5-Fri, 6-Sat   
	  var diaDaSemana = new List<int>{0, 6};   
  
	  Console.WriteLine("Data Inicial: " + startDT.ToString("dd/MM/yyyy-ddd"));  
	  Console.WriteLine("Data Final: " + endDT.ToString("dd/MM/yyyy-ddd")); 
	  Console.WriteLine("Feriado: " + feriado.ToString("dd/MM/yyyy-ddd"));  
	  Console.WriteLine();  
	  
	  //------------------------------------------------------------------------- 
	  Console.WriteLine("Lista de dias da funcao ListDays com dia da semana...");  
	  foreach (DateTime day in ListDays(startDT, endDT)){		    		  
		  Console.WriteLine(day.ToString("dd/MM/yyyy-ddd") + " Dia da semana : " + (int) day.DayOfWeek);		  
	  }  
	  
	  Console.WriteLine();
	  
	  //------------------------------------------------------------------------- 
	  Console.WriteLine("Lista de dias da funcao ListDays, exceto feriado unico...");  
	  foreach (DateTime day in ListDays(startDT, endDT)){		  
  		  //Retorna inteiro 0 ou 1
		  int result = DateTime.Compare(feriado, day); 

		  //Verifica se e feriado		  
		  if (result == 0)
			  continue;			  
		  Console.WriteLine(day.ToString("dd/MM/yyyy-ddd"));		  
	  }   

	  Console.WriteLine();
	 
	  //------------------------------------------------------------------------- 
	  Console.WriteLine("Lista de feriados...");  
	  foreach (var f in feriados) {
		  Console.WriteLine(f.ToString("dd/MM/yyyy"));		  
	  }
	  
	  Console.WriteLine();
	  
	  //------------------------------------------------------------------------- 
	  Console.WriteLine("Lista de dias da funcao ListDays, exceto lista de feriados...");  
	  //Lista auxiliar
	  List<DateTime> aux = new List<DateTime>();  
	  foreach (DateTime day in ListDays(startDT, endDT)){
		  aux.Add(day);
      }
	   
	  bool check = feriados.Intersect(ListDays(startDT, endDT)).Any();	   
      //Console.WriteLine(feriados.Any(x => ListDays(startDT, endDT).Contains(x)));	  
	   
	  if (check){
		  Console.WriteLine();
		  Console.WriteLine("Feriados encontrados : ");
		  //Exibe os feriados encontrados
		  var resultado = feriados.Intersect(ListDays(startDT, endDT)); 
		  
          foreach (DateTime day in resultado){	
			   Console.WriteLine(day.ToString("dd/MM/yyyy"));
			   //Remove o feriado da lista de dias
			   aux.Remove(day);
	  	  }
		  Console.WriteLine();
		  Console.WriteLine("Dia uteis : ");
		  foreach (DateTime day in aux){	
			   Console.WriteLine(day.ToString("dd/MM/yyyy"));			   
	  	  }
	  }else{Console.WriteLine("Nao existe feriado na lista");}
	  
	  Console.WriteLine(); 		  	        
	  
	  //------------------------------------------------------------------------- 
	  Console.WriteLine("Lista de dias nao usados...");  
	  foreach (var d in diaDaSemana) {
		  Console.WriteLine(d);		  
	  }
	  
	  Console.WriteLine(); 
	   
	  //------------------------------------------------------------------------- 
	  Console.WriteLine("Lista de dias da funcao ListDays, exceto lista de dias da semana nao usados ..."); 
	  //Lista auxiliar
	  List<DateTime> aux2 = new List<DateTime>();  	    	  	   
	  foreach (DateTime day in ListDays(startDT, endDT)){
		  aux2.Add(day);	
      }
	   
      //Remove os dias da semana nao usados
	  foreach (DateTime day in ListDays(startDT, endDT)){			  
		  foreach (int d in diaDaSemana){
			  if (d == ((int) day.DayOfWeek))
				  aux2.Remove(day);
		  }		  
	  }
   
	  Console.WriteLine();

	  Console.WriteLine("Dia uteis : ");
	  foreach (DateTime day in aux2)	
	      Console.WriteLine(day.ToString("dd/MM/yyyy") + " Dia da semana : " + (int) day.DayOfWeek);			   	  	  	  
	  
	  Console.WriteLine(); 		  	        
	   
	  //Exemplos
	  //https://docs.microsoft.com/pt-br/dotnet/api/system.datetime.compare?view=net-5.0
	  //https://stackoverflow.com/questions/1847580/how-do-i-loop-through-a-date-range 
	  //https://stackoverflow.com/questions/51540322/remove-weekend-days-from-date-range/51542397
   }		
}
