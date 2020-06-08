using System;

namespace Homework3
{
    public struct Complex
    {
        private double a;
        private double b;

        //real number
        public double A
        {
            get 
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        //imaginary number
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public Complex(double re, double im)
        {
            a = re;
            b = im;
        }
        /// <summary>
        /// adds complex numbers together
        /// </summary>
        /// <param name="value1">First complex number</param>
        /// <param name="value2">Second complex number</param>
        public static void SumComplex(Complex value1, Complex value2)
        {
            Console.WriteLine($"SUM: \n({value1.A + value2.A}) + ({value1.B + value2.B}i)");
        }
        /// <summary>
        /// subtracts complex numbers
        /// </summary>
        public static void DifComplex(Complex value1, Complex value2)
        {
            Console.WriteLine($"DIFFERENCE: \n({value1.A - value2.A}) - ({value1.B - value2.B}i)");
        }
        /// <summary>
        /// multiply complex numbers
        /// </summary>
        public static void MulComplex(Complex value1, Complex value2)
        {
            double mulA = (value1.A * value2.A) + (value1.B * value2.B * (-1));
            double mulB = (value1.A * value2.B) + (value1.B * value2.A);
            Console.WriteLine($"MULTIPLY: \n({mulA}) + ({mulB}i)");
        }
        /// <summary>
        /// outputs the complex number
        /// </summary>
        public void Display ()
        {
            Console.WriteLine($"{this.A} + {this.B}i");
        }

    }
    public partial class Homework3
    { 
        public static void Task1()
        {
            // First complex number
            Console.WriteLine("Please enter your  first complex number");
            Console.Write("A: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bi: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Complex compl1 = new Complex(a1, b1);            
            compl1.Display();            

            // Second complex number
            Console.WriteLine("Please enter your  second complex number");
            Console.Write("A: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bi: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Complex compl2 = new Complex(a2, b2);
            compl2.Display();

            //sum of complex numbers
            Complex.SumComplex(compl1, compl2);
            //difference of complex numbers
            Complex.DifComplex(compl1, compl2);
            //multiply of complex numbers
            Complex.MulComplex(compl1, compl2);

            Console.ReadLine();



        }
    
    }

    }
