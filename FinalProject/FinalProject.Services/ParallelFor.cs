using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Services
{
   public static class ParallelFor
    {
        public static TextBox textboxGeneral = new TextBox();
        public static TextBox textTimeGeneral = new TextBox();

        public static TextBox textboxGeneralPi = new TextBox();
        public static TextBox textTimeGeneralPi = new TextBox();

        public static  void ExcecParallelForPi(int numThreads, int loops, decimal digits, bool isParallelFor = true )
        {
            int numProcs = numThreads, height = loops;
            Task.Factory.StartNew(() =>
            {
                int nextId = -1; // assign each thread a unique id
                var threadId = new ThreadLocal<int>(() => Interlocked.Increment(ref nextId));

                var sw = Stopwatch.StartNew(); // time the operation

                if (isParallelFor)
                {
                    Parallel.For(0, height, new ParallelOptions { MaxDegreeOfParallelism = numProcs }, i =>
                    {
                        int id = threadId.Value;
                        var content = DoWork(digits);

                        textboxGeneralPi.AppendText(content);
                        textboxGeneralPi.AppendText($" == Executed by Thread {id} == ");

                    });

                    MessageBox.Show(textboxGeneralPi.Text);
                }
                else
                {
                    for (int i = 0; i < height; i++)
                    {
                        int id = threadId.Value;
                        var content = DoWork(digits);

                        textboxGeneralPi.AppendText(content);
                        textboxGeneralPi.AppendText($" == Executed by Thread {id} == ");
                       
                    }
                    
                }
                // Return the total time from the task
                return sw.Elapsed;

                // When the work completes, run the following on the UI thread
            }).ContinueWith(t =>
            {

                textTimeGeneralPi.Text = t.Result.ToString();
            }, TaskScheduler.FromCurrentSynchronizationContext());
      
        }

        /// <summary>Does an amount of work relative to the amount requested.</summary>
        /// <param name="workAmount">The amount of work to perform.</param>
        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private static string DoWork(decimal workAmount)
        {
            //  int value = 1;


            var digits = Convert.ToInt32(workAmount);
            StringBuilder pi = new StringBuilder("3", digits + 2);


            if (digits > 0)
            {
                pi.Append(".");
                for (int j = 0; j < digits; j += 9)
                {
                    int nineDigits = NineDigitsOfPi.StartingAt(j + 1);
                    int digitCount = Math.Min(digits - j, 9);
                    string ds = string.Format("{0:D9}", nineDigits);
                    pi.Append(ds.Substring(0, digitCount));

                }
            }

            return pi.ToString();
        }

    }
}
