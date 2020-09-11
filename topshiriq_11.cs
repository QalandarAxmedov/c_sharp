using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_11 _11 = new Class_11();
            Console.Write("x=");
            _11.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _11.natija());
        }
    }
    class Class_11
    {
        public double x;
        public double natija()
        {
            return Math.Sqrt(Math.Sqrt(Math.Pow(x,4)+Math.Sqrt(Math.Pow(x,2)+Math.Sqrt(Math.Log(Math.Pow(x-Math.Sin(x)+5,2))))));
        }
    }

}
