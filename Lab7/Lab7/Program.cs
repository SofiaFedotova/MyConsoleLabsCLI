using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Vector
    {
        private double x;
        private double y;
        private double z;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }

        public Vector(double x1, double y1, double z1)
        {
            X = x1;
            Y = y1;
            Z = z1;
        }
        public Vector() { }

        public Vector AddV(Vector A, Vector B)
        {
            return new Vector(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }
        public static Vector Subtract(Vector A, Vector B)
        {
            /* Vector C = new Vector
             {
              X = A.X + B.X,
              Y = A.Y + B.Y,
              Z = A.Z + B.Z
             };*/
            return new Vector(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }
        public double Length(Vector A)
        {
            return Math.Pow(Math.Pow(A.X, 2) + Math.Pow(A.X, 2) + Math.Pow(A.X, 2), 0.5);
        }
        public static double ScProduct(Vector A, Vector B)
        {
            return A.X * B.X + A.Y * B.Y + A.Z * B.Z;
        }

    }
}
