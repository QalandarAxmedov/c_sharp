using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_10 _10 = new Class_10();
            Console.Write("x=");
            _10.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _10.natija());
        }
    }
    class Class_10
    {
        public double x;
        public double natija()
        {
            if (this.x == 0) return 0;
            return Math.Sqrt(1 + Math.Pow(1 + Math.Pow(1 + Math.Pow(x, 4), 1 / 4), 1 / 3)) + Math.Abs(Math.Atan(1 / Math.Sqrt(1 / Math.Tan(1 / Math.Pow(x, 2)))));
        }
    }

}
