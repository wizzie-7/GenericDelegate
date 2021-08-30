using System;
using System.Collections.Generic;

namespace GenericDelegate
{
    public class GenericDelegateDemo
    {
        public delegate void GenDel<T>(T arg);

        public void GenInsta()
        {
            GenDel<string> GT = new GenDel<string>(PrintString);
            PrintString("Hellow World");

            GenDel<int> GT2 = new GenDel<int>(PrintInt);
            PrintInt(7);
        }
        public void PrintString(string s)
        {
            Console.WriteLine("Strin in upper case: {0}", s.ToUpper());
        }
        public void PrintInt(int num)
        {
            Console.WriteLine("Print number: {0}", ++num);
        }
    }
    class DelegateGeneric
    {
        static void Main(string[] args)
        {
            GenericDelegateDemo GOD = new GenericDelegateDemo();

            GOD.GenInsta();


        }
    }
}
