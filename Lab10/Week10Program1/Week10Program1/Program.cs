﻿using System;

namespace Week10Program1
{
    public delegate void AddOperations(int number1, int number2);

    // Write code here to Create the MathOperation class
    class MathOperations
    {
        public static void add(int n1, int n2)
        {
            Console.WriteLine("{0} + {1} = {2}", n1, n2, (n1 + n2));
        }
        public static void sub(int n1, int n2)
        {
            Console.WriteLine("{0} - {1} = {2}", n1, n2, (n1 - n2));
        }
        public static void mult (int n1, int n2)
        {
            Console.WriteLine("{0} * {1} = {2}", n1, n2, (n1 * n2));
        }
        public static void div(int n1, int n2)
        {
            Console.WriteLine("{0} / {1} = {2}", n1, n2, (n1 / n2));
        }
        public static void mod(int n1, int n2)
        {
            Console.WriteLine("{0} % {1} = {2}", n1, n2, (n1 % n2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AddOperations operation = new AddOperations(MathOperations.add);

            Console.WriteLine("Executing the Multicast Delegate:");
            operation += new AddOperations(MathOperations.sub);
            operation += new AddOperations(MathOperations.mult);
            operation += new AddOperations(MathOperations.div);
            operation += new AddOperations(MathOperations.mod);

            operation(5, 4);

            Console.WriteLine("\nExecuting the Multicast Delegate after removing some operations:");
            operation -= new AddOperations(MathOperations.sub);
            operation -= new AddOperations(MathOperations.div);

            operation(5, 4);

            Console.Read();
        }
    }
}