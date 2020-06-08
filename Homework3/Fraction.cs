﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Fraction
    {
        private int nomerator;
        private int denomerator;
        public int Nominator
        {
            get 
            {
                return nomerator;
            }
            set
            {                
                nomerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return denomerator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException(String.Format("ЧИСЛО НЕ ДОЛЖНО РАВНЯТЬСЯ 0!", value));
                }
                else
                {
                    denomerator = value;
                }
            }
        }

        public Fraction()
        {
            Nominator = 1;
            Denominator = 1;
        }
        public Fraction(int nom,int den)
        {
            Nominator = nom;
            Denominator = den;

        }

        /// <summary>
        /// outputs the fraction
        /// ADD-ON: general summary + whole number
        /// TODO: add on a partition of the integers 
        /// </summary>
        public void Display()
        {
            //get a simply fraction
            int i = this.Denominator;
            while(i > 1)
            {
                if (this.Denominator%i == 0 && this.Nominator % i == 0)
                {
                    this.Denominator /= i;
                    this.Nominator /= i;

                }
                i--;
            }

            //get whole number
            int wholeNimber = 0;
            int nom = this.Nominator;
            int den = this.Denominator;

            if (this.Nominator>this.Denominator)
            {
                wholeNimber = this.Nominator / this.Denominator;
                nom = this.Nominator - (wholeNimber * this.Denominator);
                den = this.Denominator;
            }
            //get result
            Console.WriteLine($" {wholeNimber}({nom}/{den})");
        }



        /// <summary>
        /// The sum of the fractions
        /// TODO: find a general summary (using "for(int i = MAX; i>2; i--)" -> to the new method!)
        /// </summary>
        /// <param name="f1">first fraction</param>
        /// <param name="f2">second fraction</param>
        /// <returns>new Fraction-object </returns>
        public static Fraction Sum(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            if (f1.Denominator == f2.Denominator)
            {
                f3.Denominator = f1.Denominator;
                f3.Nominator = f1.Nominator + f2.Nominator;
            }
            else
            {
                f3.Denominator = f1.Denominator * f2.Denominator;
                f3.Nominator = f1.Nominator * f2.Denominator + f2.Nominator * f1.Denominator;
            }
            return f3;
        }
        /// <summary>
        /// The difference of the fractions
        /// </summary>
        /// <param name="f1">first fraction</param>
        /// <param name="f2">second fraction</param>
        /// <returns>new Fraction-object </returns>
        public static Fraction Dif(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            if (f1.Denominator == f2.Denominator)
            {
                f3.Denominator = f1.Denominator;
                f3.Nominator = f1.Nominator - f2.Nominator;
            }
            else
            {
                f3.Denominator = f1.Denominator * f2.Denominator;
                f3.Nominator = f1.Nominator * f2.Denominator - f2.Nominator * f1.Denominator;
            }
            return f3;
        }
        /// <summary>
        /// The multiplication of the fractions
        /// </summary>
        /// <param name="f1">first fraction</param>
        /// <param name="f2">second fraction</param>
        /// <returns>new Fraction-object </returns>
        public static Fraction Mul(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.Nominator = f1.Nominator * f2.Nominator;
            f3.Denominator = f1.Denominator * f2.Denominator;
            return f3;
        }
        /// <summary>
        /// The dividing of the fractions
        /// </summary>
        /// <param name="f1">first fraction</param>
        /// <param name="f2">second fraction</param>
        /// <returns>new Fraction-object </returns>
        public static Fraction Div(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction
            {
                Nominator = f1.Nominator * f2.Denominator,
                Denominator = f1.Denominator * f2.Nominator
            };
            return f3;
        }



    }
    public partial class Homework3
    {
        public static Fraction NewFraction()
        {
            Console.WriteLine("Enter nominator:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter denominator:");
            int d = Convert.ToInt32(Console.ReadLine());
            return new Fraction(n, d);
        }
        public static void Task2()
        {
            Fraction frac1 = NewFraction();
            Fraction frac2 = NewFraction();
            frac1.Display();
            frac2.Display();
            Console.ReadLine();
            Console.Clear();

            //Let's run operations
            Fraction fracSum = Fraction.Sum(frac1, frac2);
            Console.WriteLine("SUM:");
            fracSum.Display();

            Fraction fracDif = Fraction.Dif(frac1, frac2);
            Console.WriteLine("DIFFERENCE:");
            fracDif.Display();

            Fraction fracMul = Fraction.Mul(frac1, frac2);
            Console.WriteLine("MULTIPLICATION:");
            fracMul.Display();

            Fraction fracDiv = Fraction.Div(frac1, frac2);
            Console.WriteLine("DIVIDING:");
            fracDiv.Display();




        }

    }
}
