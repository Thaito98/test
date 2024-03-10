using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class fraction
    {
        private int numerator;
        private int denominator;
        public fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public fraction(int n, int d)
        {
            this.numerator = n;
            this.denominator = d;
        }
        public fraction(int n)
        {
            this.numerator = n;
            this.denominator = 1;
        }
        public void simplify()
        {
            int ucln = UCLN(numerator, denominator);
            numerator = numerator / ucln;
            denominator = denominator / ucln;

        }
        public int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return UCLN(b, a % b);
        }
        public void input()
        {
            Console.WriteLine("nhap tu so");
            numerator = Convert.ToInt32(Console.ReadLine());
            int d;
            do
            {
                Console.WriteLine("nhap mau so");
                d = int.Parse(Console.ReadLine());
            }
            while (d == 0);
            denominator = d;
            simplify();
        }
        public double Decimal()
        {
            return (double)numerator / denominator;
        }
        public fraction add(fraction p)
        {
            int n = this.numerator * p.denominator + this.denominator * p.numerator;
            int d = this.denominator * p.denominator;
            fraction ketqua = new fraction(n, d);
            ketqua.simplify();
            return ketqua;
        }
        public fraction sub(fraction p)
        {
            int n = this.numerator * p.denominator - this.denominator * p.numerator;
            int d = this.denominator * p.denominator;
            fraction ketqua = new fraction(n, d);
            ketqua.simplify();
            return ketqua;
        }
        public fraction mul(fraction p)
        {
            int n = this.numerator * p.numerator;
            int d = this.denominator * p.denominator;
            fraction ketqua = new fraction(n, d);
            ketqua.simplify();
            return ketqua;
        }
        public fraction div(fraction p)
        {
            int n = this.numerator * p.denominator;
            int d = this.denominator * p.numerator;
            fraction ketqua = new fraction(n, d);
            ketqua.simplify();
            return ketqua;

        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                fraction f1 = new fraction();
                f1.input();
                Console.WriteLine("phan so" + f1);
                fraction f2 = new fraction(3,4);
                f2.input();
                Console.WriteLine("phan so" + f2);

                fraction f3 = f1.add(f2);
                Console.WriteLine("tong" + f3);

                f3 =f1.sub(f2);
                Console.WriteLine("hieu" + f3);

                f3 = f1.mul(f2);
                Console.WriteLine("tich" + f3);
                
                f3 = f1.div(f2);
                Console.WriteLine("thuong" + f3);

            }
        }
    }
}
