using System;
					
public class Program
{
	 public static void Main() {
		String horaIni = "0800";
		String horaFim = "1300";
				 
		//Timezone 
       		DateTime DateTimeUtc = DateTime.UtcNow;
    		TimeZoneInfo TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");//(GMT-03:00) Brasília
    		DateTime DatetimeBrasilia = TimeZoneInfo.ConvertTimeFromUtc(DateTimeUtc, TimeZoneInfo);
		
		String horaAgora = DatetimeBrasilia.Hour.ToString() + DatetimeBrasilia.Minute.ToString(); 
		//String horaAgora = "129";//Teste
														   	 
		Console.WriteLine("Hora Inicial :" + horaIni); 
		Console.WriteLine("Hora Fim     :" + horaFim);  
		Console.WriteLine("Hora Atual   :" + horaAgora);  		 
		 
		Console.WriteLine();  
		 
		//primeira comparacao
		if (int.Parse(horaAgora) >= int.Parse(horaIni) && int.Parse(horaAgora) <= int.Parse(horaFim)){
			Console.WriteLine("Teste 1 - A hora atual está entre os valores");
		}
		//ou segunda comparacao
		if (horaAgora.CompareTo(horaIni) > -1 && horaAgora.CompareTo(horaFim) < 1)
		{
			Console.WriteLine("Teste 2 - A hora atual está entre os valores");
		}
	 }
	//https://ecode10.com/artigo/1501/Comparar-Hora-Atual-com-Hora-Inicial-e-Hora-Final
	//https://duanbrito.net/2014/05/04/funcao-obter-horario-brasilia/
}
