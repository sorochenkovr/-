﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;


namespace labor_3
{

    class Program
    {
        static void Main(string[] args)
        {
            TakesAWhileDelegate dl = TakesAWhile;
            dl.BeginInvoke(1, 3000, TakesAWhileCompleted, dl);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(50);
            }
        }
    }

    static void TakesAWhileCompleted(IAsyncResult ar)
    {
        if (ar == null) throw new ArgumentNullException("ar");
        TakesAWhileDelegate dl = ar.AsyncState as TakesAWhileDelegate;
        Trace.Assert(dl != null, "Неверный тип объекта");
        int result = dl.EndInvoke(ar);
        Console.WriteLine("result: {0}", result);
    }
}