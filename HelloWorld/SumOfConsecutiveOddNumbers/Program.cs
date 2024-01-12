//using System;

//public class Program
//{
//    public static void Main()
//    {
//       int n = int.Parse(Console.ReadLine());

//       int l = int.Parse(Console.ReadLine());

//        int start, end;

//        int Count = 0;  

//        if(n > l)
//        {
//            start = l;
//            end = n;
//        }
//        else
//        {
//            start = n;
//            end = l;
//        }

//        for(int i = start+1; i < end; i++)
//        {
//            if(i % 2 == 1)
//            {
//                Count = Count + i;
//            }
//        }
//        Console.WriteLine(Count);




//    }
//}
using System;

namespace SumOfOddValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            int start, end;
            if (X < Y)
            {
                start = X;
                end = Y;
            }
            else
            {
                start = Y;
                end = X;
            }

            int sum = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
