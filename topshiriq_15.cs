using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_15 _15 = new Class_15();
            Console.Write("a=");
            _15.a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            _15.b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            _15.c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _15.natija());
        }
    }
    class Class_15
    {
        public double a,b,c;
        public double natija()
        {
            if(this.c==0 || this.a == -this.b) { return 0; }
            return this.a * this.b / this.c + this.c / (this.a + this.b);
        }
    }

}
