using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_060223
{
    internal static class Task
    {
        public static void N1()
        {
            Console.WriteLine("N1:");

            string example = "The example";
            Console.Write($"{example} -> ");
            example = example.Remove(3, 1);
            Console.Write(example);
        }
        public static void N2()
        {
            Console.WriteLine("\n\nN2:");

            string example = "The example";
            Console.Write($"{example} -> ");
            char[] charsToRemove = { 'e', 'a' };
            example = new string(example.Where(c => !charsToRemove.Contains(c)).ToArray());
            Console.Write(example);
        }
        public static void N3()
        {
            Console.WriteLine("\n\nN3:");

            string example = "The example";
            Console.Write($"{example} -> ");
            const int placeToInput = 3;
            const char charToInput = '_';
            char[] newStr = new char[example.Length];
            for (int i = 0; i < placeToInput; i++)
            {
                newStr[i] = example[i];
            }
            newStr[3] = charToInput;
            for (int i = placeToInput + 1; i < example.Length; i++)
            {
                newStr[i] = example[i];
            }
            example = new string(newStr);
            Console.Write(example);
        }
        public static void N4()
        {
            Console.WriteLine("\n\nN4:");

            string input = Console.ReadLine();
            Console.Write($"\n{input}");
             
            Console.Write(" is polindrom");
        }
        public static void N5()
        {
            Console.WriteLine("\n\nN5:");

            string example = "Lorem ipsum dolor sit amet";
            Console.WriteLine(example);
            int wordCount = example.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"word count = {wordCount}");
        }
        public static void N6()
        {
            Console.WriteLine("\n\nN5:");

            string example = "Lorem ipsum dolor sit amet";
            Console.WriteLine(example);
            int wordCount = example.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"word count = {wordCount}");
        }
    }
}