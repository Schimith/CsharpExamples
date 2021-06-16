using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{        
        DateTime horaIni = DateTime.Parse("08:15");	//Hora Inicio
		DateTime horaFim = DateTime.Parse("12:55"); //Hora Fim
        var step = 20; //Minutos

        var list = GetListOfHours(horaIni, horaFim, step);

        foreach (var item in list)
        {
           Console.WriteLine(item);
        }				
	}
	
    private static IEnumerable<string> GetListOfHours(DateTime start, DateTime end, int step)
    {
		while (start <= end)
		{
           yield return start.ToString("HH:mm");
           start = start.AddMinutes(step);
		}
     }
}

//https://stackoverflow.com/questions/25541560/create-a-list-of-hours/25541639
