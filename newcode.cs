using System;
using System.Linq;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            string s1 = "hello";
            string s2 = "world";
            
            if(s1.Equals(s2)){
                Console.WriteLine("yay");
            }else{
                Console.WriteLine("no");
            }

            if(s1 == s2){
                Console.WriteLine("yay2");
            }else{
                Console.WriteLine("no2");
            }

        }
    }
}
