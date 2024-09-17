using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1.1

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //ex1.2
            Dictionary<string, int> fruit = new Dictionary<string, int>() {
    {"apple", 1},
    {"banana", 2},
    {"pear", 3},
    {"peach", 4},
    {"kiwi", 5}
};

            //ex1.3
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            //ex1.4
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);


            //ex2.1
            int sum = numbers.Sum();
            Console.WriteLine(sum);

            //ex2.2
            int Summary = 0;
            foreach (var key in fruit.Keys)
            {
                Summary += fruit[key];
            }
            Console.WriteLine(Summary);

            //ex2.3
            queue.Dequeue();
            queue.Dequeue();
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            //ex2.4
            stack.Pop();
            stack.Pop();
            foreach (int x in stack)
            {
                Console.WriteLine(x);
            }

            //ex3.1
            foreach (int y in numbers)
            {
                Console.WriteLine(y);
            }

            //ex3.2
            int num = 357;
            int first_digit = num / 100;
            int second_digit = (num / 10) % 10;
            int third_digit = num % 10;
            int largestDigit = Math.Max(first_digit, Math.Max(second_digit, third_digit));
            Console.WriteLine(largestDigit);

            //ex3.3
            int number = 445;
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;
            int smallestDigit = Math.Min(firstDigit, Math.Min(secondDigit, thirdDigit));
            Console.WriteLine(smallestDigit);

            //ex3.4
            int[] num_arr = { 1, 2, 3, 4, 5 };
            foreach (var z in num_arr)
            {
                if (z % 2 == 0)
                {
                    Console.WriteLine(z);
                }
            }

            //ex3.5
            double average = num_arr.Average();
            Console.WriteLine(average);
        }
    }
}
