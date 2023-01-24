using System;

namespace MethodsPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 5, 1, 9,5 };
            var index = Array.LastIndexOf(numbers, 5);
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Array.Clear(numbers, 0, 2);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(index);
            string str = "Hikmet";
            str=str.ToUpper();
            Console.WriteLine(str);

            Console.WriteLine(str.Contains("HIK"));
            str = "Hello World";
            var word = str.Substring(0,5);
            Console.WriteLine(word);
            Console.WriteLine(str.IndexOf('l'));
            Console.WriteLine(str.LastIndexOf('l'));
            Console.WriteLine(str.Substring(str.IndexOf(' ')+1));
            //str = str.Replace('l', 'L');
            str = str.Replace("Hello", "Goodby");
            str = "  Hello, World";
            str = str.Trim();
            str.StartsWith("Hello");
            str.StartsWith("Hello");
            Console.WriteLine(str);
            
            

            Console.WriteLine(char.IsDigit('f'));
            Console.WriteLine(char.IsLetterOrDigit('2'));
            Console.WriteLine(char.IsUpper('l'));
            Console.WriteLine(char.IsLower('S'));
            Console.WriteLine(char.ToUpper('A'));

            string sentence = "Salam Faiq";
            var wordsentence=sentence.Split(' ');

            var newsentence=string.Join('+', wordsentence);
            Console.WriteLine(newsentence);

            string name;
            do
            {
                Console.WriteLine("Ad daxil edin:");
                name = Console.ReadLine();
            } while (!char.IsUpper(name[0]));
        }
    }
}
