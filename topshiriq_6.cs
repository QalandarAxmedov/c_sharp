using System;

namespace Mustaqil_bajarish_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_6 _6 = new Class_6();
            Console.Write("a=");
            _6.a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            _6.b = int.Parse(Console.ReadLine());
            Console.WriteLine("[{0},{1}] dagi mukammal sonlar quyidagilardir", _6.a,_6.b);
            _6.mukammal_sonlar();
            
        }
    }
    class Class_6
    {
        public int a,b;
        public bool is_mukammal(int num)
        {
            int summa = 0;
            for (int i=1; i < num; i++)
            {
                if (num % i == 0) { summa += i; }
            }
            return (summa == num) ? true : false;
        }
        public void  mukammal_sonlar()
        {
            bool natija = false;
            for(int j=this.a; j <= this.b; j++)
            {
                if (is_mukammal(j))
                {
                    natija = true;
                    Console.WriteLine("{0} soni mukammal son", j);
                }
                else { continue; }
            }
            if(!natija){ Console.WriteLine("Bu oraliqda mukammal son mavjud emas");}
            
        }
    }

}
