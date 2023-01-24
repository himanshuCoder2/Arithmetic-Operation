using System;

namespace consoleappliacation1
{
    class publictest
    {
        public String name= "Himanshu";
        public void Msg(String msg)
        {
            Console.WriteLine("msg");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            publictest p = new publictest();

            Console.WriteLine(p.name);
            p.Msg("welcome to nagpur");
        }
    }
}
