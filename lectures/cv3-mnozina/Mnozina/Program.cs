using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnozina {
	class Program {
		static void Main(string[] args) {
			int[] a = new int[] { 1, 2, 3, 4, 5, 6 };
			int[] b = new int[] { 2, 3, 4, 10 };

			Set A = new Set(a);
			Set B = new Set(b);

			Console.WriteLine("Mnozina A : {0}", A);
			Console.WriteLine("Mnozina B : {0}", B);
			Console.WriteLine("Mnozina A po provedeni prikazu A << 10 << 18 : {0}", A << 10 << 18);
			Console.WriteLine("Mnozina A po provedeni prikazu A >> 3 : {0}", A >> 3);
			Console.WriteLine("Mnozina B : {0}", B);
			Console.WriteLine("Sjedoceni A a B : {0}", A + B);
			Console.WriteLine("Rozdil A a B : {0}\n", A - B);
			Console.WriteLine("Mnozina A : {0}", A);
			Console.WriteLine("Mnozina B : {0}", B);
			Console.ReadKey();
		}
	}
}
