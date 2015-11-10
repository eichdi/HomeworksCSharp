using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ГемертрическиеФигуры
{
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double Perimeter();
    }
    class Circle:Shape
    {
        private double a;
        private double b;
        public Circle(double a, double b)
        {
            this.A = a;
            this.B = b;
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = Math.Abs(value);
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = Math.Abs(value);
            }
        }
        public override double GetArea()
        {
            return A * B;
        }
        public override double Perimeter()
        {
            return ((A + B) * 2);
        }

    }
    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = Math.Abs(value);
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = Math.Abs(value);
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = Math.Abs(value);
            }
        }
        public double Hypotrnuse
        {
            get
            {
                if (A - B > 0 && A - C>0)
                {
                    return A;
                }
                if (B - A > 0 && B - C > 0)
                {
                    return B;
                }
                if(C-A>0&&C-B>0)
                {
                    return C;
                }
                return A;
            }
            
        }
        public override double Perimeter()
        {
            
                return A + B + C;
            
        }
        public double H
        {
            get
            {
                double p=Perimeter()/2;
                double x=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                return(((2*x)/Hypotrnuse));
            }
        }
        public override double GetArea()
        {
            
                return ((Hypotrnuse * H) / 2);
            
                
            
        }
    }
    class Square : Shape
    {
        private double r;
        public Square(double r)
        {
            this.R = r;
        }
        public double R
        {
            get
            {
                return r;
            }
            set 
            {
                r = Math.Abs(value);
            }
        }
        public override double GetArea()
        {
            
                return (Math.PI*R*R);
            
        }
        public override double Perimeter()
        {
            
                return (2*Math.PI*R);
            
        }
    }
    class Program
    {
        public double input()
        {
            String text=Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (!((text[i] >= '0' && text[i] <= '9')||text[i]=='.'))
                {
                    Console.WriteLine("Неправильно. Попробуй еще раз.");
                    return input();
                }
                
            }
            return double.Parse(text);
        }
        static void Main(string[] args)
        {
            Circle a = new Circle(5, 5);
            Triangle b = new Triangle(10, 14, 12);
            Square c = new Square(1);
            double[] result = new double[3];
            result[0] = a.GetArea();
            result[1] = b.GetArea();
            result[2] = c.GetArea();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
            
        }
    }
}
