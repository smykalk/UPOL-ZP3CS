using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_4_tridy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid c1 = new Cuboid();
            Cuboid c2 = new Cuboid(4);
            Cuboid c3 = new Cuboid(4,5);
            Cuboid c4 = new Cuboid(4,5,6);

            Console.WriteLine("Kvadr byl zadan: Cuboid c1 = new Cuboid(); Objem: {0}  Povrch: {1}", c1.Volume(), c1.Surface());
            Console.WriteLine("Kvadr byl zadan: Cuboid c2 = new Cuboid(4); Objem: {0}  Povrch: {1}", c2.Volume(), c2.Surface());
            Console.WriteLine("Kvadr byl zadan: Cuboid c3 = new Cuboid(4,5); Objem: {0}  Povrch: {1}", c3.Volume(), c3.Surface());
            Console.WriteLine("Kvadr byl zadan: Cuboid c4 = new Cuboid(4,5,6);  Objem: {0}  Povrch: {1}", c4.Volume(), c4.Surface());
            Console.ReadKey();
        }
    }

    class Cuboid
    {
        private double A,B,C;

        public Cuboid()
        {
            this.A = 1;
            this.B = 1;
            this.C = 1;
        }

        public Cuboid(double A)
        {
            this.A = A;
            this.B = 1;
            this.C = 1;
        }

        public Cuboid(double A, double B)
        {
            this.A = A;
            this.B = B;
            this.C = 1;
        }

        public Cuboid(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public double Volume()
        {
            return this.A * this.B * this.C;
        }

        public double Surface()
        {
            return 2 * (this.A * this.B + this.B * this.C + this.A * this.C);
        }
    }
}
