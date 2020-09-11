using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_8 _8 = new Class_8();
            Console.Write("x=");
            _8.x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            _8.y = double.Parse(Console.ReadLine());
            Console.Write("z=");
            _8.z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _8._t());
            
            
        }
    }
    class Class_8
    {
        public double x,y,z;
        public double _t()
        {
            this.y *= (Math.PI / 180);
            this.x *= (Math.PI / 180);
            if (Math.Pow(z,2)==15) { return 0; }
            return (2 * Math.Cos(x - Math.PI / 4)) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));
        }
    }

}
