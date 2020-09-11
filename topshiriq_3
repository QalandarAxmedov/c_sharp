using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_2 _2 = new Class_2();
            Console.Write("a=");
            _2.a = int.Parse(Console.ReadLine());
            Console.Write("d=");
            _2.d = int.Parse(Console.ReadLine());
            Console.Write("n=");
            _2.n = int.Parse(Console.ReadLine());
            Console.WriteLine(_2.Summa(_2.n));
            Console.ReadKey();
        }
    }
    class Class_2
    {
        public double a, n, d, summa = 0;
        public double Summa(double n)
        {
            this.n = this.n - 1;
            if (this.n != -1)
            {
                this.summa += a + this.n * this.d + Summa(this.n);

            }
            return this.summa;
        }
    }

}
