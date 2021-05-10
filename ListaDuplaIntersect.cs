using System;
using System.Linq;
using System.Collections.Generic;

					
public class Program
{
	public static void Main()
	{		
		List<string> lista = new List<string> { "123456789,consulta", "987654321,exame" };
		List<string> agendamento = new List<string>();
		
		// Type your username and press enter
		Console.WriteLine("Digite o CPF (apenas numeros):");

		// Create a string variable and get user input from the keyboard and store it in the variable
		string cpf = Console.ReadLine();
		
		Console.WriteLine();

		Console.WriteLine("Digite a opcao:");
		Console.WriteLine("Consulta;");
		Console.WriteLine("Exame;");
		string opcao = Console.ReadLine();
		
		agendamento.Add(cpf.ToString()+","+ opcao.ToString());
			
		//Compara com Intersect cada elemento	  	
		var result = lista.Intersect(agendamento);
		bool check = result.Any();
        
	   	Console.WriteLine();	
	  	if (check){					
		    Console.WriteLine("CPF ja agendado");
	  	}else{
			Console.WriteLine("Agendamento livre");
		}
		
		//https://stackoverflow.com/questions/12795882/quickest-way-to-compare-two-generic-lists-for-differences
		//https://stackoverflow.com/questions/3547746/how-should-i-compare-values-in-two-lists
	}
}
