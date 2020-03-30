using System;

namespace Dragon
{
    class Program
    {
        static void Main(string[] args)
        {
            int dragons, bulletts;
            Console.Write("Введите количество драконов: ");
            dragons = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество пуль: ");
            bulletts = Convert.ToInt32(Console.ReadLine());
            bool b = (dragons<=bulletts/2);
            if(b==true) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
