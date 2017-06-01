using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" A) Вывод на экран в одну строку трех любых чисел с двумя пробелами между ними");
            //int[] arr_A = new int [3]; //объявляем массив и создаем его экземпляр размером 3 числа (с нуля начиная)
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                //arr_A[i] = rand.Next(0,11); //записываем в массив случайные числа от 0 до 10
                //Console.Write(arr_A[i] + "  "); //выводим их
                Console.Write(" " + rand.Next(0, 11) + "  "); // вывод случайных чисел от 0 до 10 без массива
            }
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" B) Вывести на экран числа 5, 10 и 21 одно под другим");
            int[] arr_B = new int[] { 5, 10, 21 };
            for (int i = 0; i < 3; i++)
                Console.WriteLine(" " + arr_B[i]);
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" C) Дано расстояние в сантиметрах. Найти число полных метров в нем.");
            Console.Write(" Укажите см.:  ");
            double ValCentimeter = Convert.ToDouble(Console.ReadLine());// преобразовываем в вещественный вид ввода
            Console.WriteLine(" Полных метров =  " + (int)ValCentimeter / 100);
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" D) С некоторого момента прошло 234 дня.\n Сколько полных недель прошло за этот период?");
            Console.WriteLine(" " + 234 / 7 + " недели");
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" E) Дано двузначное число. Найти:");
            Console.Write(" Укажите число:  ");
            int ValChislo = Convert.ToInt32(Console.ReadLine());//преобразовываем в целый вид ввода
            Console.WriteLine(" число десятков:        " + ValChislo / 10);
            Console.WriteLine(" число едениц:          " + ValChislo % 10);
            Console.WriteLine(" сумма его цифр:        " + ((ValChislo / 10) + (ValChislo % 10)));
            Console.WriteLine(" произведение его цифр: " + (ValChislo / 10) * (ValChislo % 10));
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" F) Вычислить значение логического выражения при следующих значениях логических величин А, В и С:\n А = Истина, В = Ложь, С = Ложь:");
            bool A = true, B = false, C = false;
            Console.WriteLine("--------------------------------");
            if (A || B)
                Console.WriteLine(" А или В = True");
            else
                Console.WriteLine(" А или В = False");
            if (A && B)
                Console.WriteLine(" А  и  В = True");
            else
                Console.WriteLine(" А  и  В = False");
            if (B || C)
                Console.WriteLine(" B или C = True");
            else
                Console.WriteLine(" B или C = False");
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" G) Даны радиус круга и сторона квадрата. У какой фигуры площадь больше:");
            Console.Write(" Укажите радиус круга:  "); double R = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Укажите сторону квадрата:  "); double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" Площадь круга = " + 3.14 * (R * R));
            Console.WriteLine(" Площадь квадрата = " + (a * a));
            if ((3.14 * (R * R)) > (a * a))
                Console.WriteLine(" Площадь КРУГА больше");
            else
                Console.WriteLine(" Площадь КВАДРАТА больше");
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" H) Даны объемы и массы двух тел из разных материалов.\n Материал какого из тел имеет большую плотность?:\n");

            int text = 0;
            double[] ValTelo_1 = new double[2];
            for (int i = 0; i < 2; i++)
            {
                if (text == 0)
                {
                    Console.Write(" Объём первого тела =  ");
                    text++;
                }
                else
                    Console.Write(" Масса первого тела =  ");

                ValTelo_1[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            double[] ValTelo_2 = new double[2];
            for (int i = 0; i < 2; i++)
            {
                if (text == 2)
                {
                    Console.Write(" Объём второго тела =  ");
                    text++;
                }
                else
                    Console.Write(" Масса второго тела =  ");

                ValTelo_2[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------------------------------\n");

            double P1 = ValTelo_1[1] / ValTelo_1[0];
            Console.WriteLine(" Плотность первого тела = " + P1);
            double P2 = ValTelo_2[1] / ValTelo_2[0];
            Console.WriteLine(" Плотность второго тела = " + P2);
            if (P1 > P2)
                Console.WriteLine(" Плотность ПЕРВОГО тела БОЛЬШЕ");
            else if (P1 == P2)
                Console.WriteLine(" ПЛОТНОСТИ РАВНЫ");
            else
                Console.WriteLine(" Плотность ВТОРОГО тела БОЛЬШЕ");





            Console.WriteLine("\n\n\t---Для выхода нажмите любую клавишу!---");
            Console.ReadKey();
        }
    }
}
