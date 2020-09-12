using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YoutubeLinkFinder
{
    class Program
    {
        static void Main(string[] args)
        {
       string s= Convert.ToString(Console.ReadLine());
        bool find1=s.Contains("https://www.youtube.com/watch?v=");
        bool find2=s.Contains("https://youtu.be/");
        if(find1){
            s=s.Replace("https://www.youtube.com/watch?v=",String.Empty);
            
        }
        if(find2){
            s=s.Replace("https://youtu.be/",String.Empty);
            
        }
        
        Console.Write(s);
            
        }
    }
}
