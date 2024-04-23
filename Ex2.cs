using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex2
    {
        public void Mimimu()
        {
            Console.WriteLine("\nExercise 2:");

            var list1 = InputItems(1);
            var list2 = InputItems(2);

            var list3 = new List<string>(list1);
            list3.AddRange(list2);
            Console.WriteLine("\n\nCombined: " + string.Join(", ", list3));

            list3.Sort();
            Console.WriteLine("Sort: " + string.Join(", ", list3));
        }
        // entering elements
        public List<string> InputItems(int n)
        {
            Console.Write($"\n\nEnter the list{n} items:\n");
            var list = new List<string>(3);
            string s;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                s = Console.ReadLine();
                list.Add(s);
            }
            Console.Write($"\nList: ");
            Console.Write(string.Join(", ", list));
            return list;
        }
    }
}