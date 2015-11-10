using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialClass
{
    class Program
    {
        class Polynom
        {
            protected const int leght = 10;
            protected double[] coef = new double[leght];

            public double[] COEF
            {
                get
                {
                    return coef;
                }
            }

            public Polynom(double[] coefficients)
            {
                
                for (int i = 0; i < coefficients.Length && i<leght; i++)
                {
                    coef[i] = coefficients[i];
                }
            }
            public Polynom(double[] coefficients, int qual_coef)
            {
                coef = new double[qual_coef];
                for (int i = 0; i < coefficients.Length && i < coef.Length; i++)
                {
                    coef[i] = coefficients[i];
                }
            }
            public Polynom()
            {
                for(int i=0;i<coef.Length;i++)
                    coef[i]=0;
            }
            public Polynom(int qual_coef)
            {
                coef = new double[qual_coef];
                for (int i = 0; i < coef.Length; i++)
                    coef[i] = 0;
            }

            public void EditCoef(int coefficient, double data)
            {
                if (coefficient > coef.Length)
                {
                    Polynom a = new Polynom(coefficient);
                    a = a + this;
                    a.EditCoef(coefficient, data);
                    this.coef = a.coef;
                }
                else
                this.coef[coefficient] = data;
            }

            public double[] GetCoef
            {
                get
                {
                    return (double[]) coef.Clone();
                }
            }

            public static Polynom operator + (Polynom a, Polynom b)
            {
                int max = Math.Max(a.coef.Length, b.coef.Length);
                Polynom result = new Polynom(max);
                for (int i = 0; i < a.coef.Length && i < b.coef.Length; i++)
                {
                    result.coef[i] = a.coef[i] + b.coef[i];
                }
                return result;
            }
            public static Polynom operator +(Polynom a, double b)
            {
                Polynom result = new Polynom(a.coef.Length);
                result = result + a;
                result.coef[0] += b;
                return result;
            }
            public static Polynom operator +(double b, Polynom a)
            {
                return a + b;
            }

            public static Polynom operator -(Polynom a, Polynom b)
            {

                int max = Math.Max(a.coef.Length, b.coef.Length);
                Polynom result = new Polynom(max);
                for (int i = 0; i < a.coef.Length && i < b.coef.Length; i++)
                {
                    result.coef[i] = a.coef[i] - b.coef[i];
                }
                return result;
            }
            public static Polynom operator -(Polynom a, double b)
            {
                Polynom result = new Polynom(a.coef.Length);
                result = result + a;
                result.coef[0] -= b;
                return result;
            }
            public static Polynom operator -(double b, Polynom a)
            {
                return (-1 * a) + b;
            }

            public static Polynom operator *(Polynom a, Polynom b)
            {

                Polynom result = new Polynom(((a.coef.Length-1) + (b.coef.Length-1))+1);
                for (int i = 0; i < a.coef.Length; i++)
                {
                    for (int j = 0; j < b.coef.Length; j++)
                    {
                        result.coef[i + j] =result.coef[i + j]+ a.coef[i] * b.coef[j];
                    }
                }
                    return result;
            }
            public static Polynom operator *(Polynom a, double b)
            {
                Polynom result = new Polynom(a.coef.Length);
                result = result + a;
                for (int i = 0; i < result.coef.Length; i++)
                    result.coef[i] *= b;
                return result;
            }
            public static Polynom operator *(double b, Polynom a)
            {
                return a * b;
            }
            public static Polynom operator /(Polynom a, double b)
            {
                Polynom result = new Polynom(a.coef.Length);
                result = result + a;
                for (int i = 0; i < result.coef.Length; i++)
                    result.coef[i] /= b;
                return result;
            }

            /*public Polynom Lagrange_Poly(double[,] X_FfromX)
            {
                Polynom[] l = new Polynom[X_FfromX.Length / 2];
                bool l_used;
                for (int i = 0; i < l.Length; i++)
                {
                    Polynom tempPoly;
                    double[] tempDoub = new double[2];
                    l_used = false;
                    for (int j = 0; j < l.Length; j++)
                    {
                        if (i != j)
                        {
                            tempDoub[0] =-1* X_FfromX[0, j] / (X_FfromX[0, i] - X_FfromX[0, j]);
                            tempDoub[1] = 1 / (X_FfromX[0, i] - X_FfromX[0, j]);
                            if (l_used)
                            {
                                tempPoly = new Polynom(tempDoub,2);
                                l[i] = l[i] * tempPoly;
                            }
                            else
                            {
                                l_used = true;
                                l[i] = new Polynom(tempDoub,2);
                            }
                        }
                    }
                    l[i] = l[i] * X_FfromX[1, i];
                    
                }
                Polynom result=l[0];
                for (int i = 1; i < l.Length; i++)
                {
                    result = result + l[i];
                }

                    return result;
            }*/
            
            public override string ToString()
            {
                string result = coef[0].ToString("0.#####");
                for (int i = 1; i < coef.Length; i++)
                {
                    string summand = Math.Abs(coef[i]).ToString("0.#####");
                    if (summand != "0")
                    {
                        if (coef[i] > 0)
                        {
                            result += " + ";
                        }
                        else
                        {
                            result += " - ";
                        }
                        result += summand + "*x^" + i;
                    }
                }
                return result;
            }
            
        }
        class Lagrange_Polynom : Polynom
        {
            public Lagrange_Polynom(double[,] X_FfromX)
            {

                Polynom[] l = new Polynom[X_FfromX.Length / 2];
                bool l_used;
                for (int i = 0; i < l.Length; i++)
                {
                    Polynom tempPoly;
                    double[] tempDoub = new double[2];
                    l_used = false;
                    for (int j = 0; j < l.Length; j++)
                    {
                        if (i != j)
                        {
                            tempDoub[0] = -1 * X_FfromX[0, j] / (X_FfromX[0, i] - X_FfromX[0, j]);
                            tempDoub[1] = 1 / (X_FfromX[0, i] - X_FfromX[0, j]);
                            if (l_used)
                            {
                                tempPoly = new Polynom(tempDoub, 2);
                                l[i] = l[i] * tempPoly;
                            }
                            else
                            {
                                l_used = true;
                                l[i] = new Polynom(tempDoub, 2);
                            }
                        }
                    }
                    l[i] = l[i] * X_FfromX[1, i];

                }
                Polynom result = l[0];
                for (int i = 1; i < l.Length; i++)
                {
                    result = result + l[i];
                }

                this.coef = result.COEF;
            }
        }
        static void Main(string[] args)
        {
            double[,] a= new double[2,3];
            for (int i = 0; i < a.Length/2; i++)
            {
                a[0, i] = i;
                a[1, i] = i * i + 1;
            }

            Lagrange_Polynom b= new Lagrange_Polynom(a);
        }
    }
}
