using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._3
{
    internal class Program
    {
        static void Main(string[] args) 
            
         {    
            
            HashSet<string> set = new HashSet<string>();
       
            while (true)
            {
           
            Console.WriteLine("Введите число или пустую строку для выхода");
            string number = Console.ReadLine();
          

            if (!set.Contains(number))
                {
                   set.Add(number);
                    Console.WriteLine("Число сохраненно");
                }
                else
                {
                    Console.WriteLine("такое число уже есть в коллекции");
                }
                  
                if(number == "")
                {
                    break;
                }
                
            }
          
            foreach(string element in set)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine() ;
        
            

        }
    }
}
