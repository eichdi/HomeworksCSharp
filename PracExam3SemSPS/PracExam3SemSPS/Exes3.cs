using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracExam3SemSPS
{
    class Dot
    {
        private double x=0;
        private double y=0;
        private double z=0;
        public Dot(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X
        {
            set
            {
                
                this.x = value;
                
            }
            get
            {
                return this.x;
            }
        }
        public double Y
        {
            set
            {
                
                this.y = value;
                
            }
            get
            {
                return this.y;
            }
        }
        public double Z
        {
            set
            {
                
                    this.z = value;
                
            }
            get
            {
                return this.z;
            }
        }
        public static double Lenght(Dot a, Dot b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2)) + Math.Sqrt(Math.Pow(a.Y - b.Y, 2)) + Math.Sqrt(Math.Pow(a.Z - b.Z, 2));
        }

    }
    interface Ifigure
    {
        double GetArea();
      
    }
    class Triangle:Ifigure
    {
        private Dot a;
        private Dot b;
        private Dot c;
        public Triangle(Dot a, Dot b, Dot c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
           
        }
        public static  bool operator > (Triangle a, Triangle b)
        {
            return (a.GetArea() > b.GetArea());
        }
        public static bool operator < (Triangle a, Triangle b)
        {
            return b > a;
        }
        public double A
        {
            
            get
            {
                return Dot.Lenght(a, b);
            }
        }
        public double B
        {
            
            get
            {
                return Dot.Lenght(b, c);
            }
        }
        public double C
        {
            get
            {
                return Dot.Lenght(c, a);
            }
        }
        public static double  AreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;//Полупериметр
            return  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double GetArea()
        {
            return AreaTriangle(A, B, C);
        }
    }
    class Quadrangle : Ifigure
    {
        private Dot a;
        private Dot b;
        private Dot c;
        private Dot d;

        public Quadrangle(Dot a, Dot b, Dot c, Dot d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = b;
           
        }
        public double A
        {

            get
            {
                return Dot.Lenght(a, b);
            }
        }
        public double B
        {

            get
            {
                return Dot.Lenght(b, c);
            }
        }
        public double C
        {
            get
            {
                return Dot.Lenght(c, d);
            }
        }
        public double D
        {
            get
            {
                 return Dot.Lenght(d, a);
            }
        }
        public static bool operator >(Quadrangle a, Quadrangle b)
        {
            return (a.GetArea() > b.GetArea());
        }
        public static bool operator <(Quadrangle a, Quadrangle b)
        {
            return b > a;
        }
        public double GetArea()
        {
            double gip = Math.Sqrt(C * C + D * D);
            return Triangle.AreaTriangle(A, B, gip) + Triangle.AreaTriangle(C, D, gip);
        }


    }
    class Figures
    {
        private List<Ifigure> figures = new List<Ifigure>();
        public void AddTriangle(Dot a, Dot b, Dot c)
        {
            Triangle temp = new Triangle(a,b,c);
            figures.Add(temp);
        }
        public void AddTriangle(Triangle triangle)
        {
            figures.Add(triangle);
        }
        public void AddQuadrangle(Dot a, Dot b, Dot c, Dot d)
        {
            Quadrangle temp = new Quadrangle(a, b, c, d);
            figures.Add(temp);
        }
        public void AddQuadrangle(Quadrangle quadrangle)
        {
            figures.Add(quadrangle);
        }
        public double SummArea()
        {
            double result = 0;
            foreach (Ifigure e in figures)
            {
                result += e.GetArea();
            }
            return result;
        }
        public void Sort()
        {
            //figures.Sort();
            
        
            for (int i = 0; i < figures.Count - 1; i++)
            {
                for (int j = 0; j < figures.Count - 1; j++)
                {
                    if (figures[j].GetArea() > figures[j + 1].GetArea())
                    {
                        Object tempFigure = new Object();
                        tempFigure = figures[j];
                        figures[j] = figures[j + 1];
                        figures[j + 1] = tempFigure as Ifigure;
                    }
                }
            }
        
        }
        public void ShowList()
        {
            foreach (Ifigure e in figures)
            {
                Console.WriteLine(e.GetArea());
            }
        }

    }
}
