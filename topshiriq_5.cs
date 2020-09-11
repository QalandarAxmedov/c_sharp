using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_5 _5 = new Class_5();
            Console.Write("a=");
            _5.a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            _5.b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            _5.c = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Parallelepipedning to'la sirti S={0}\nHajmi={1}", _5.S_tula(),_5.Hajm());
            
        }
    }
    class Class_5
    {
        public double a,b,c;
        public double S_tula()
        {
            return 2 * (this.a * this.b + this.b * this.c + this.a * this.c);
        }
        public double Hajm()
        {
            return this.a * this.b * this.c;
        }
    }

}
