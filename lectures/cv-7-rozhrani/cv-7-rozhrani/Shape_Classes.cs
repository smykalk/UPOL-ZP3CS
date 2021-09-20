using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_7_rozhrani {
	class Circle : IShape, ICompare {
		double r;
		public Circle(double r) {
			this.r = r;
		}
		public double Area() {
			return Math.PI * r * r;
		}
		public double Circumference() {
			return 2 * Math.PI * r;
		}
		public bool GreaterCircumference(IShape shape) {
			return (shape.Circumference() < this.Circumference());
		}
		public bool GreaterArea(IShape shape) {
			return (shape.Area() < this.Area());
		}
		public override string ToString() {
			return "Útvar je kruh, obvod je: " + this.Circumference().ToString() + ", obsah je:" + this.Area().ToString();
		}
	}
	class Rectangle : IShape, ICompare {
		double a, b;
		public Rectangle(double a, double b) {
			this.a = a;
			this.b = b;
		}
		public double Area() {
			return a * b;
		}
		public double Circumference() {
			return 2 * (a + b);
		}
		public bool GreaterCircumference(IShape shape) {
			return (shape.Circumference() < this.Circumference());
		}
		public bool GreaterArea(IShape shape) {
			return (shape.Area() < this.Area());
		}
		public override string ToString() {
			return "Útvar je obdélník, obvod je: " + this.Circumference().ToString() + ", obsah je:" + this.Area().ToString();
		}
	}
}
