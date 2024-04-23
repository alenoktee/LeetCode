using System;
using System.Text;

namespace ConsoleApp1
{
    public class Ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1:\nEnter the string:");
            string word = Console.ReadLine();
            ScoreOfString(word);

            Ex2 myObject = new Ex2();
            myObject.Mimimu();
            Console.ReadKey();
        }
        static void ScoreOfString(string s)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            int bytik = asciiBytes[0];
            int sum = 0;
            for (int i = 1; i < asciiBytes.Length; i++)
            {
                int now = (int)asciiBytes[i];
                int res = Math.Abs(bytik - now);
                Console.WriteLine($"{bytik} - {now} = {res}");
                bytik = now;
                sum += res;
            }
            Console.WriteLine("Output: " + sum);
        }
    }
}