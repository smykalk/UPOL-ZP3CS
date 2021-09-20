using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_7_rozhrani {
	class Program {
		static void Main(string[] args) {
			Circle c1 = new Circle(5);
			Circle c2 = new Circle(7);
			Rectangle r1 = new Rectangle(6, 7);
			Rectangle r2 = new Rectangle(3, 12);
			Console.WriteLine(c1.ToString());
			Console.WriteLine(c2.ToString());
			Console.WriteLine(r1.ToString());
			Console.WriteLine(r2.ToString());
			string circles = "První kruh má ";
			if (c1.GreaterArea(c2))
				circles += "větší";
			else
				circles += "menší";
			circles += " obsah, než druhý kruh";
			string rectangles = "První obdélník má ";
			if (r1.GreaterCircumference(r2))
				rectangles += "větší";
			else
				rectangles += "menší";
			rectangles += " obvod, než druhý obdélník";

			Console.WriteLine(circles);
			Console.WriteLine(rectangles);
			Console.ReadKey();
		}
	}
}