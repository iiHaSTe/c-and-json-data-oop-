using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Haste {

  public class Easy {
		public static int[] range(int lenght){
			int[] name = new int[lenght];
			for (int i=1; i<=lenght; i++)
				name[i-1] = i;
  		return name;
  	}
  	public static string input(string text){
  		Console.Write(text);
  		return Console.ReadLine();
  	}
  }
}