using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_1 _1 = new Class_1();
            Console.Write("a=");
            _1.a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            _1.b = int.Parse(Console.ReadLine());
            Console.Write("alfa=");
            _1.alfa = int.Parse(Console.ReadLine());
            Console.WriteLine(_1.Trapetsiya_yuzi());
            Console.ReadKey();
        }
    }
    class Class_1
    {
        public double a, b, alfa;
        public double Trapetsiya_yuzi()
        {
            this.alfa = (Math.PI / 180) * this.alfa;
            return  (this.a + this.b)  * (this.a - this.b) *Math.Tan(this.alfa)/4;
             
        }
    }

}
