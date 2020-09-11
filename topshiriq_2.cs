using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_2 _2 = new Class_2();
            Console.Write("alfa_1=");
            _2.alfa_1 = double.Parse(Console.ReadLine());
            Console.Write("alfa_2=");
            _2.alfa_2 = double.Parse(Console.ReadLine());
            Console.Write("alfa_3=");
            _2.alfa_3 = double.Parse(Console.ReadLine());
            Console.Write("R=");
            _2.R = double.Parse(Console.ReadLine());
            Console.WriteLine("1-tomon {0}", _2.Tomon(_2.alfa_1));
            Console.WriteLine("2-tomon {0}", _2.Tomon(_2.alfa_2));
            Console.WriteLine("3-tomon {0}", _2.Tomon(_2.alfa_3));
        }
    }
    class Class_2
    {
        public double alfa_1,alfa_2,alfa_3,R;
        public double Tomon(double alfa)
        {
            alfa = (Math.PI / 180) * alfa;
            return 2 * this.R * Math.Sin(alfa);
             
        }
    }

}
