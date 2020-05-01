using System;

namespace construct_test
{
    class TestConstruct {
        static int i;
        static  TestConstruct() { i = 1; Console.WriteLine("i = " + i);}//статический конструктор
        public TestConstruct() { i=2; Console.WriteLine("i = " + i); }//обычный конструктор
        public TestConstruct(int j) { i=j; Console.WriteLine("i = " + i); }// инициализатор
}
    class Program
    {
        static void Main(string[] args)
        {
            TestConstruct my = new TestConstruct(3);
            Console.WriteLine("iiiiii = "+4);
        }
    }
}
