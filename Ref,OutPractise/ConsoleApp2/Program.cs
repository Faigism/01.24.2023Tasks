using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            setZero(out num);
            Console.WriteLine(num);
            int[] number = { 2, 5, 1, 4, 2, 6, 60, 72, 112 };
            arrLength(ref number);
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            string name = "Tofiq";
            name = "Faiq";
            setZero(ref name);
            Console.WriteLine(name);

            int num1 = -34;
            MakePositive(ref num1);
            Console.WriteLine(num1);

            string nam = "Faiq";
            AddZero(ref nam);
            Console.WriteLine(nam);
            
            number = new int[] { 34, 12, -5, 6, -3, -12 };
            MakePositive(ref number);
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
        static void arrLength(ref int[] arr)
        {
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = 0;
            //}
            arr=new int[arr.Length]; 
        }
        static void setZero(out int num)
        {
            num = 2;
        }
        static void setZero(ref string str)
        {
            str = "0";
        }
        static void MakePositive(ref int num)
        {
            if (num < 0)
                num *= -1;
        }
        static void AddZero(ref string str1)
        {
            str1 += 0;
        }
        static void MakePositive(ref int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>0)
                    count++;
            }
            int[] newArr = new int[count];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>0)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            arr= newArr;
        }
    }
}
