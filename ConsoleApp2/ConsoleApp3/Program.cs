using System;

namespace ConsoleApp3
{
    class Program
    {
        private string name = "Himanshu";
        private void Msg(String msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.name);
            p.Msg("welcome");
        }
    }
}
