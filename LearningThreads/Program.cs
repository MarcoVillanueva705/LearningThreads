﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(new ThreadStart(Work));

            myThread.Start();

            Console.ReadLine();
        }

        static void Work()
        {
            Thread.Sleep(3000);
            Console.WriteLine("data computed...");
        }
    }
}
