using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        private static void Separator()
        {
            Console.WriteLine(new string('-', 30));
        }

        private static string GetElapsedTimeAsString(TimeSpan time)
        {
            return String.Format("sort elapsed time: {0:00}:{1:00}:{2:00}:{3:0000}",
                                time.TotalHours, time.TotalMinutes, time.TotalSeconds, time.TotalMilliseconds);
        }

        internal static void Main(string[] args)
        {
            List<int> ListToSort = new List<int>();
            Random rand = new Random();
            for(int i = 0; i < rand.Next(5, 20); i++)
            {
                ListToSort.Add(rand.Next(-100, 100));
            }

            Stopwatch watch = new Stopwatch();

            #region Sorting algorithms

            #region Bubble Sort
            watch.Start();
            BubbleSort.Sort(ListToSort);
            watch.Stop();

            Console.WriteLine($"Bubble {GetElapsedTimeAsString(watch.Elapsed)}");
            #endregion

            Separator();

            #endregion
        }
    }
}
