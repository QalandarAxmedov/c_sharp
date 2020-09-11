using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_12 _12 = new Class_12();
            Console.Write("a=");
            _12.a = double.Parse(Console.ReadLine());
            Console.Write("x=");
            _12.x = double.Parse(Console.ReadLine());
            Console.Write("t=");
            _12.t = double.Parse(Console.ReadLine());
            Console.Write("y=");
            _12.y = double.Parse(Console.ReadLine());
            Console.Write("c=");
            _12.c = double.Parse(Console.ReadLine());
            Console.Write("d=");
            _12.d = double.Parse(Console.ReadLine());
            Console.Write("z=");
            _12.z = double.Parse(Console.ReadLine());
            Console.Write("e=");
            _12.e = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _12.natija());
        }
    }
    class Class_12
    {
        public double a,x,t,y,c,d,z,e,sum=0;
        public double natija()
        {
            this.sum += this.a * Math.Pow(this.x - this.t, 2) / (this.x + this.y - this.a);
            this.sum += this.a * Math.Pow(this.x - this.t, 3) / (this.x + this.e - this.d);
            this.sum += this.c * (this.x - this.t) / (this.x + this.y - this.c);
            this.sum /= Math.Sqrt(this.a + this.x + Math.Sqrt(this.a + this.y + Math.Sqrt(this.a + this.z)));
            return this.sum;
        }
    }

}
