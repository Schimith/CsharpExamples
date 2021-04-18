using System;
using System.Collections.Generic;
using System.Linq;

public class Lista {
   public static void Main() {

	  //Lista X 
	  List < int > x = new List < int > () { 1, 2, 3, 4, 5, 6, 7 };
  
	  Console.WriteLine("Conteudo Lista X...");
      foreach(int value in x) {
         Console.WriteLine(value);
      }
	  
	  //Lista Y 
	  List < int > y = new List < int > () { 5, 7, 6, 8, 9 };
	  
	  Console.WriteLine("Conteudo Lista Y...");
      foreach(int value in y) {
         Console.WriteLine(value);
      }

	  //Lista Z com os elementos existentes nas listas x e y
	  var z = x.Intersect(y).ToList(); 
	   
	  Console.WriteLine("Conteudo Lista Z..."); 
	  foreach(int value in z) {
         Console.WriteLine(value);
      } 
	   
   }
}
