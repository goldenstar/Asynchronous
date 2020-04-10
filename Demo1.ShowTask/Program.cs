﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo1.ShowTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Mastery 5.0!");

            // 1
            Task task = new Task(() => GetFactorial(11));
            task.Start();

            // 2
            Task.Run(() => GetFactorial(12));

            // 3
            Task[] tasks = new Task[3];
            int number = 3;
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Factory.StartNew(() => GetFactorial(number++));
            }

            // 4
            #region Task Status
            
            task = new Task(() => GetFactorial(number));
            Console.WriteLine($"Status: {task.Status}");

            task.Start();
            Console.WriteLine($"Status: {task.Status}");

            Thread.Sleep(8000);
            Console.WriteLine($"Status: {task.Status}");

            #endregion 3

            Console.WriteLine("Useful work...");

            Console.Read();
        }

        private static void GetFactorial(int number)
        {
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Thread.Sleep(1000);

            Console.WriteLine($"{number}! = {result}");
        }
    }
}
