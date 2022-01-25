using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
namespace Haste {
	public class DataSettings {
		private Dictionary<int, string[]> dic = new Dictionary<int, string[]>();
		private string data = "";
		private int id = 0;
		private string hmmm = "";
		StreamWriter file;
		public DataSettings(string path){
			this.file = new StreamWriter(path);
		}
		public void main(){
			while (true){
				string[] user = new string[2];
				user[0] = Easy.input("enter name: ");
				user[1] = Easy.input("enter age: ");
				try {
					var aa = Convert.ToInt32(user[1]);
					Console.WriteLine(aa);
				} catch {
					Console.WriteLine("Please enter a number");
					Thread.Sleep(1500);
					Console.Clear();
					continue;
				}
				this.dic.Add(++id, user);
				this.jsonData();
				this.settings();
				if (this.hmmm=="yes"){
					break;
				}
				Console.Clear();
			}
		}
		private void jsonData(){
			this.data = "";
				this.data += "[\n";
				foreach (var item in this.dic) {
					this.data += "\t{\n";
					this.data += "\t\t\"id\": "+item.Key+",\n";
					this.data += "\t\t\"name\": "+"\""+item.Value[0]+"\""+",\n";
					this.data += "\t\t\"age\": "+item.Value[1]+"\n";
					this.data += "\t},\n";
				}
				this.data += "]";
		}
		private void settings() {
			var show = Easy.input("show [yes/no]: ");
			if (show=="yes"){
				Console.WriteLine("###############\n\n");
				Console.WriteLine(this.data);
				Console.WriteLine("\n\n###############");
			}
			show = Easy.input("save [yes/no]: ");
			if (show=="yes"){
				this.file.Write(this.data);
				this.file.Close();
			}
			show = Easy.input("continue [yes/no]: ");
			if (show=="no"){
				show = Easy.input("save [yes/no]: ");
				if (show=="yes"){}
				this.hmmm = "yes";
			}
		}
	}
}