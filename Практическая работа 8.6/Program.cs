using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_8._6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Первый цикл");
            List<int> randomList = RandomNumberList() ;
            PrintList(randomList);
            Console.WriteLine("Второй цикл");
            List<int> sortedList = SortedNumber(randomList);
            PrintList(sortedList);
            Console.ReadKey();
            

           


                }
        private static List<int> RandomNumberList()
        {
            
            Random rm = new Random();
            return Enumerable.Range(0,100).Select(i => rm.Next(0,101)).ToList() ; 
        } 
             
        private static void PrintList(List<int> list)
        {
            foreach(int element in list)
            {
              Console.WriteLine(element);
            } 
                
        }

             private static List<int> SortedNumber(List<int> list)
            {
             return list.Where(number => number <= 25 || 50 <= number).ToList();
            }

        
    }
}
