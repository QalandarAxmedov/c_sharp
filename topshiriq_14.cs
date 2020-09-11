using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_14 _14 = new Class_14();
            Console.Write("b=");
            _14.b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _14.natija());
        }
    }
    class Class_14
    {
        public double b;
        public double natija()
        {
            return Math.Sqrt(2 * this.b + Math.Sqrt(Math.Pow(b, 2) - 4)) / (Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2);   
        }
    }

}
