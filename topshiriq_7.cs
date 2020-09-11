using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_7 _7 = new Class_7();
            Console.Write("x=");
            _7.x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            _7.y = double.Parse(Console.ReadLine());
            Console.Write("z=");
            _7.z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _7.function());          
        }
    }
    class Class_7
    {
        public double x,y,z;
        public double function()
        {
            this.z *= (Math.PI / 180);
            if (this.x == this.y) { return 0; } 
            return Math.Pow(this.y + Math.Pow(this.x - 1, 1 / 3), 1 / 4) / (Math.Abs(this.x - this.y) * (Math.Pow(Math.Sin(this.z), 2) + Math.Tan(this.z)));
        }
    }
}
