using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_8_vlastnosti {
	class Program {
		static void Main(string[] args) {
			Person p1 = new Person("Jakub", "Smykal", "Olomouc", 20);
			Person p2 = new Person("Tonda", "Vomacka", "Brno", 26);
			Person p3 = new Person("Blanka", "Kratka", "Ostrava", 76);
			Person p4 = new Person("Zorka", "Horka", "Plzen", 22);
			PersonList pl = new PersonList();
			pl.AddPerson(p1);
			pl.AddPerson(p2);
			pl.AddPerson(p3);
			pl.AddPerson(p4);
			Console.WriteLine(pl.ToString());
			Console.ReadKey();

			Console.WriteLine(pl["Tonda Vomacka"]);
			Console.WriteLine(pl[4]);

			Console.ReadKey();
		}
	}
}
