using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Program
    {
        public class Point {
            public double x, y;
            public Point() {
                x = 0;
                y = 0;
            }
            public Point(double x, double y) {
                this.x = x;
                this.y = y;
            }
            public void Read() {
                var s = Console.ReadLine();
                string[] arg = s.Split(new char[] {' '});
                x = Int32.Parse(arg[0]);
                y = Int32.Parse(arg[1]);
            }
            public double Vec(Point a)
            {
                return x * a.y - y * a.x;
            }
        }
   
        class Polygon {
            int n;
            Point[] vertexes;
            public Polygon() {
                n = 0;
                vertexes = new Point[0];
            }
            public Polygon(int n, Point[] vertexes) {
                this.n = n;
                this.vertexes = vertexes;   
            }
            public void Read() {
                var s = Console.ReadLine();
                n = Int32.Parse(s);
                vertexes = new Point[n];
                for (int i = 0; i < n; i++) {
                    vertexes[i] = new Point();
                    vertexes[i].Read();
                }
            }
            public double GetArea() {
                double area = 0;
                for (int i = 0; i < n - 1; i++) {
                    area += vertexes[i].Vec(vertexes[i + 1]);
                }
                area += vertexes[n - 1].Vec(vertexes[0]);
                return Math.Abs(area) * 0.5;
            }
        }
        static void Main(string[] args)
        {
            Polygon a = new Polygon();
            a.Read();
            Console.WriteLine(a.GetArea());
            Console.ReadKey();
        }
    }
}
