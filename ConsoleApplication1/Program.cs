using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameValue,
                   strValue;
            int sumValue = 0, chislo;
            bool CheckFor = true;

            Console.Write(" Введите ваше ФИО (*либо Имя) :  ");
            NameValue = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n\t\t  Приветствую Вас \"" + NameValue + "\"");
            Console.WriteLine();
            //---------------------------------------------------------------------------------------------------------------------------

            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\t  Приветствую Вас \"" + NameValue + "\"");
                Console.WriteLine();
                Console.Write(" Введите ПЕРВОЕ число :  ");
                strValue = Console.ReadLine();
                if (!Int32.TryParse(strValue, out chislo)) // если не число то обоработать
                {
                    Console.WriteLine("\n\n\n\n\t\t Вы ввели не число,\n повторите ввод после нажатия любой клавиши... ");
                    CheckFor = false;
                    Console.ReadKey();
                }
                else
                    CheckFor = true;
            } while (!CheckFor);
            sumValue = sumValue + chislo;

            int PreviousNumber = chislo;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\t  Приветствую Вас \"" + NameValue + "\"");
                Console.WriteLine();
                Console.WriteLine(" Вы ввели первое число " + PreviousNumber + "\n\n");
                Console.Write(" Введите ВТОРОЕ число :  ");
                strValue = Console.ReadLine();
                if (!Int32.TryParse(strValue, out chislo)) // если не число то обоработать
                {
                    Console.WriteLine("\n\n\n\n\t\t Вы ввели не число,\n повторите ввод после нажатия любой клавиши... ");
                    CheckFor = false;
                    Console.ReadKey();
                }
                else
                    CheckFor = true;
            } while (!CheckFor);
            sumValue = sumValue + chislo;

            Console.Clear();
            Console.WriteLine("\n\t\t  Приветствую Вас \"" + NameValue + "\"");
            Console.WriteLine();
            Console.WriteLine(" Вы ввели первое число " + PreviousNumber);
            Console.WriteLine(" Вы ввели второе число " + chislo);

            Console.WriteLine(" Сумма двух чисел = " + sumValue);

            Console.WriteLine("\n\n\n");
            Console.Write("Для выхода нажмите любую клавишу... ");
            Console.ReadKey();
        }
    }
}
