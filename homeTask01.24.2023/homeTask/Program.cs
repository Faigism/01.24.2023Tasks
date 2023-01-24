using System;
using System.ComponentModel;
using System.Linq;

namespace homeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
            //Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm, arrayim dəyişilməli və
            //arrayin  içində əvəlki elementləri, əlavə olaraq son indexində isə 5 elementi olmalıdır və
            //arrayin uzunluğu 1 vahid artmış olmalıdır.
            int[] number = { 4, 1, 5, 9, 2 };
            int n;
            var result=newIndex(ref number,5);
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
        static int[] newIndex(ref int[] arr,int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length-1!=n)
                {
                    arr[i] += n;
                }
            }
            return arr;
        }
    }
}
