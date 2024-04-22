using System;
using System.Text;

public class Num1
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        ScoreOfString(word);
        Console.ReadKey();
    }
    static void ScoreOfString(string s)
    {
        string word = Console.ReadLine();
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