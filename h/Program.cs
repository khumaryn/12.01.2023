using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace h
{
    internal class Program
    {
        delegate bool CheckNum(int num);
        delegate int Calculate(int num1, int num2);
        static void Main(string[] args)
        {
  
            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            CheckNum method ;
            //method = IsOdd;
            method = delegate (int num)
                {
                    return num % 3 == 0;
                };
            method = x => x % 5 == 0;
            var result = method.Invoke(25);
            Console.WriteLine(result);
            CheckNum method2;
            method=x=>x%8 == 0;
            var cs = method.Invoke(64);
            Console.WriteLine(cs);
            // Func<int, int, int> sum = (x, y) => x + y;
            Func<int, int, int> sumcount = (x, y) => x * y;
            Action<int, int> sum = ShowSum;
            Predicate<int> predicate = IsOdd;
            predicate = x => x % 8 == 0;
            predicate = y => y%8==0;
            Func<int,int> pow=x=>x*x;
            predicate = delegate (int x) { return x > 10; };
            predicate = delegate (int y) { return y < 0; };
            sumcount = delegate (int s,int y) {return s *y; };
            Calculate add = delegate (int num1, int num2) { return num1 + num2; };
              Console.WriteLine(  add(10,32)  );
            Calculate add1 = delegate (int x, int y) { return x / y; };
            Console.WriteLine(add1(45,9));
            Console.WriteLine(Sum(numbers, IsEven));
            Console.WriteLine(Sum(numbers, IsOdd));
            Console.WriteLine(SumOfDividedBy5(numbers));
            
        }
        static int Sum(int[] numbers, Func<int,bool> check)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                if (check(num))
                    sum += num;
            }
            return sum;
        }
        static int SumofOdd(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 1)
                    sum += num;
            }
            return sum;
        }
        static int SumOfDividedBy3(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 3 == 0)
                    sum += num;
            }
            return sum;
        }
        static int SumOfDividedBy5(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 5 == 0)
                    sum += num;
            }

            return sum;
        }
        static bool IsEven(int num)
        {
            return (num % 2 == 0);
        }
        static bool IsOdd(int num)
        {
            return (num % 3 == 0);
        }
        static void ShowSum(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }


    }
}
