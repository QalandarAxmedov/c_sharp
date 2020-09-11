using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_13 _13 = new Class_13();
            
            Console.Write("x=");
            _13.x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            _13.y = double.Parse(Console.ReadLine());
            Console.Write("a=");
            _13.a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            _13.b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            _13.c = double.Parse(Console.ReadLine());
            Console.Write("R=");
            _13.R = double.Parse(Console.ReadLine());
            Console.WriteLine("Ifodaning qiymati {0}", _13.natija());
        }
    }
    class Class_13
    {
        public double x, y, a, b, c, R,sum=0;
        public double natija()
        {
            this.sum += this.R*this.a*this.x / (this.x - this.y + this.a);
            this.sum += Math.Pow(this.b*this.x,1/3)/ (this.x - this.y + this.b);
            this.sum += Math.Pow(this.c*this.x,1/4)/ (this.x - this.y + this.c);
            this.sum /= this.a*Math.Pow(Math.Pow(Math.Sin(x),3),1/5)+Math.Pow(Math.Log(b*Math.Pow(Math.Sin(x),3)),5)+Math.Pow(Math.E,Math.Abs(x));
            return this.sum;
        }
    }

}
