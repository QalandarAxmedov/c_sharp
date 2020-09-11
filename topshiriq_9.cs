using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_9 _9 = new Class_9();
            Console.Write("x=");
            _9.x = double.Parse(Console.ReadLine());
            Console.Write("a=");
            _9.a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _9.natija());
        }
    }
    class Class_9
    {
        public double x,a,sum=0;
        public double natija()
        {
            this.sum += Math.Pow(this.a, this.x) / (1 + Math.Pow(a, 2 * x));
            this.sum += x / (1 + 2 * Math.Pow(x, 2) / (1 + 3 * Math.Pow(x, 2) / (1 + 4 * Math.Pow(x, 2) / (1 + x))));
            this.sum += Math.Pow(Math.E, x / 2) * (1 + Math.Pow(Math.E, x));
            this.sum += Math.Sqrt(Math.Sin(x - 1));
            return this.sum;
        }
    }

}
