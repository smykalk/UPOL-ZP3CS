using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_6_dedicnost {
	class Program {
		static void Main(string[] args) {
			Osoba o1 = new Osoba("JS", "95839");
			o1.vypis();

			Console.WriteLine();

			Student_skoly ss1 = new Student_skoly("JS", "4324", "UPOL");
			ss1.vypis();

			Console.WriteLine();

			Student s1 = new Student("JS", "6765", "MUNI", "Informatika");
			s1.vypis();
			Console.ReadKey();
		}
	}

	class Osoba {
		protected string jmeno;
		protected string RodneCislo;
		public Osoba(string j, string rc) {
			this.jmeno = j;
			this.RodneCislo = rc;
		}
		public void zmen_jmeno(string j) {
			this.jmeno = j;
		}
		public void zmen_rc(string rc) {
			this.RodneCislo = rc;
		}

		public void vypis() {
			Console.Write("Jméno: {0}, RČ: {1}", this.jmeno, this.RodneCislo);
		}
	}
	class Student_skoly : Osoba {
		protected string nazevSkoly;
		public Student_skoly(string j, string rc, string nsk) : base(j, rc) {
			this.nazevSkoly = nsk;
		}

		public void nastav_skolu(string nsk) {
			this.nazevSkoly = nsk;
		}

		public new void vypis() {
			base.vypis();
			Console.Write(", Název školy: {0}", this.nazevSkoly);
		}
	}

	class Student : Student_skoly {
		string obor;

		public Student(string j, string rc, string nsk, string obor) : base(j, rc, nsk) {
			this.obor = obor;
		}

		public void zmen_obor(string obor) {
			this.obor = obor;
		}

		public new void vypis() {
			base.vypis();
			Console.Write(", Obor: {0}", this.obor);
		}
	}
}
