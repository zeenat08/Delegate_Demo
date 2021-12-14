﻿using System;

namespace Delegate_Demo
{
 
    class Program
    {
        public delegate int operation(int x, int y);
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Demo");
            operation obj = new operation(Addition);
            //Console.WriteLine("Addition is = {0}",obj(23,27));
            MulticastDelegate.ImplementDelegate();
            Console.ReadKey();
        }
    }
}
