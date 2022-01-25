using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Haste {
	public static class Program {
		public static void Main() {
			
			var name = new DataSettings("./data.json");
			name.main();
			Console.WriteLine("finish");
			Console.ReadKey();
		}
	}
}