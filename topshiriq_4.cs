using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_4 _4 = new Class_4();
            Console.Write("R_1=");
            _4.R_1 = double.Parse(Console.ReadLine());
            Console.Write("R_2=");
            _4.R_2 = double.Parse(Console.ReadLine());
            Console.Write("R_3=");
            _4.R_3 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Umumiy qarshilik R_umumiy={0}", _4.R_umumiy());
            
        }
    }
    class Class_4
    {
        public double R_1,R_2,R_3;
        public double R_umumiy()
        {

            return 1 / (1 / this.R_1 + 1 / this.R_2 + 1 / this.R_3);
             
        }
    }

}
