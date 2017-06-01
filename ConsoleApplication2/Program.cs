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
            Console.WriteLine("---------------------------------------------------------\n");
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
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" I) Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них.\n По какому участку протекает меньший ток?");
            double ValTelo1Voltage, ValTelo1Power, ValTelo2Voltage, ValTelo2Power;
            Console.Write(" Укажите мощьность  тела 1 =  "); ValTelo1Power = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Укажите напряжение тела 1 =  "); ValTelo1Voltage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write(" Укажите мощьность  тела 2 =  "); ValTelo2Power = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Укажите напряжение тела 2 =  "); ValTelo2Voltage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------\n");
            if ((ValTelo1Power / ValTelo1Voltage) < (ValTelo2Power / ValTelo2Voltage))
                Console.WriteLine(" По участку Тела 1 ток меньше");
            else if ((ValTelo1Power / ValTelo1Voltage) == (ValTelo2Power / ValTelo2Voltage))
                Console.WriteLine(" Сила тока обоих участков двух тел равна");
            else
                Console.WriteLine(" По участку Тела 2 ток меньше");
            Console.WriteLine(" Сила тока участка 1: " + ValTelo1Power / ValTelo1Voltage + "\n Сила тока участка 2: " + ValTelo2Power / ValTelo2Voltage);
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" J) Напечатать \"столбиком\":\n a. все целые числа от 20 до 35");
            int[] massiv = new int[16];
            int j = 20;
            for (int i = 0; i < 16; i++)
            {
                massiv[i] = j;
                j++;
                if ((massiv[i] % 2) == 0)
                    Console.WriteLine(" massiv = " + massiv[i]);
            }
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("b. квадраты всех целых чисел от 10 до b\n  (значение b вводится с клавиатуры; b > 10);");
            int f = 10, ch = 0 /*счетчик для цикла*/, b;
            do
            {
                Console.WriteLine("--------------------------------");
                Console.Write(" Укажите конечный диапазон: ");
                b = int.Parse(Console.ReadLine());
                if (b <= 10)
                    Console.WriteLine(" Значение должно быть больше 10");
                else
                    ch = 1;
            } while (ch != 1);

            int[] mass = new int[b - 10 + 1];
            for (int i = 0; i < b - 10 + 1; i++)
            {
                mass[i] = f;
                f++;
                if ((mass[i] % 2) == 0)
                    Console.WriteLine(" massiv = " + System.Math.Pow(mass[i], 2));
            }
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("c. третьи степени всех целых чисел от a до 50\n  (значение \"a\" вводится с клавиатуры; a < 50);");
            int chh = 0 /*счетчик для цикла*/, end_a, ff;
            do
            {
                Console.WriteLine("--------------------------------");
                Console.Write(" Укажите начальный диапазон: ");
                end_a = int.Parse(Console.ReadLine());
                ff = end_a;
                if (end_a >= 50)
                    Console.WriteLine(" Значение должно быть меньше 50");
                else
                    chh = 1;
            } while (chh != 1);

            int[] array = new int[50 - end_a + 1];
            for (int i = 0; i < 50 - end_a + 1; i++)
            {
                array[i] = ff;
                ff++;
                if ((array[i] % 2) == 0)
                    Console.WriteLine(" massiv = " + System.Math.Pow(array[i], 3));
            }
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("d. все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).");
            int cchh = 0 /*счетчик для цикла*/, begin_a, end_b;
            do
            {
                Console.WriteLine("--------------------------------");
                Console.Write(" Укажите начальный диапазон: ");
                begin_a = int.Parse(Console.ReadLine());
                Console.Write(" Укажите конечный диапазон: ");
                end_b = int.Parse(Console.ReadLine());

                if (begin_a >= end_b)
                    Console.WriteLine(" Начало должно быть меньше чем конец");
                else
                    cchh = 1;
            } while (cchh != 1);

            int[] mas = new int[end_b - begin_a]; int jj = begin_a;
            for (int i = 0; i < end_b - begin_a; i++)
            {
                mas[i] = jj;
                jj++;
                if ((mas[i] % 2) == 0)
                    Console.WriteLine(" massiv = " + mas[i]);
            }
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" K) вычисления значения функции y=7x^2-3x+4  при любом значении x;");
            Console.Write(" Укажите \"x\": ");
            double xValue = double.Parse(Console.ReadLine());
            double valOne = 7 * System.Math.Pow(xValue, 2); //7x^2
            double valTwo = 3 * xValue; //3x
            double valOneTwoEnd = valOne - valTwo + 4; //7x^2-3x

            Console.WriteLine(" y = " + valOneTwoEnd);
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" L) Дан радиус окружности. Найти длину окружности и площадь круга.");
            Console.Write(" Укажите радиус окружности: ");
            double valradius = double.Parse(Console.ReadLine());
            Console.WriteLine(" Длина окружности = " + 2 * 3.14 * valradius);
            Console.WriteLine(" Площадь круга    = " + 3.14 * System.Math.Pow(valradius, 2));
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" M) Дано расстояние в сантиметрах. Найти число полных метров в нем\n   '1 cm = 0.01 m'");
            Console.Write(" Укажите см.:  ");
            double ValCentim = Convert.ToDouble(Console.ReadLine());// преобразовываем в вещественный вид ввода
            Console.WriteLine(" Полных метров =  " + ValCentim / 100 + "m");
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" N) Задача №14 повторяется с задачей №4");
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" O) Задача №15 повторяется с задачей №5");
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" P) Дано четырехзначное число. Найти:\n a. сумму его цифр \tb. произведение его цифр");
            Console.Write(" Укажите число ");
            int valChislo = Convert.ToInt32(Console.ReadLine());
            int valSumAddition = 0, valSumComposition = 1;
            while (valChislo != 0)
            {
                valSumAddition = valSumAddition + valChislo % 10;
                valSumComposition = valSumComposition * (valChislo % 10);
                valChislo = valChislo / 10;
            }
            Console.WriteLine(" a. Сумма равна = " + valSumAddition);
            Console.WriteLine(" b. Произведение равно = " + valSumComposition);
            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" P) В трехзначном числе x зачеркнули его вторую цифру.\n   Когда к образованному при этом двузначному числу\n   справа приписали вторую цифру числа x,\n   то получилось число 456. Найти число x.\n");
            string xChislo = "456";
            string valEndSlovo = xChislo[xChislo.Length - 1].ToString(); //преобразовываем в строку из одного последнего символа строки трехзначного числа

            xChislo = xChislo.Insert(xChislo.Length - 2, valEndSlovo);//вставляем во второй символ последний символ строки
            Console.WriteLine(" Число Х = " + xChislo.Remove(xChislo.Length - 1)); //удаляем последний символ

            //------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\n");
            Console.WriteLine(" Q) Вычислить значение логического выражения при всех возможных\n   значениях логических величин X и Y:");
            //----------------------------------------------------
            Console.WriteLine("\n ------------------------");
            Console.WriteLine(" Если X = TRUE\n      Y = FALSE");
            bool valX = true, valY = false;
            if (!valX && !valY)
                Console.WriteLine(" не X и не Y = True");
            else
                Console.WriteLine(" не X и не Y = False");
            if (valX || (!valX && valY))
                Console.WriteLine(" X или (не X и Y) = True");
            else
                Console.WriteLine(" X или (не X и Y) = False");
            if ((!valX && valY) || valY)
                Console.WriteLine(" (не X и Y) или Y = True");
            else
                Console.WriteLine(" (не X и Y) или Y = False");
            //----------------------------------------------------
            Console.WriteLine("\n ------------------------");
            Console.WriteLine(" Если X = TRUE\n      Y = TRUE");
            valY = true;
            if (!valX && !valY)
                Console.WriteLine(" не X и не Y = True");
            else
                Console.WriteLine(" не X и не Y = False");
            if (valX || (!valX && valY))
                Console.WriteLine(" X или (не X и Y) = True");
            else
                Console.WriteLine(" X или (не X и Y) = False");
            if ((!valX && valY) || valY)
                Console.WriteLine(" (не X и Y) или Y = True");
            else
                Console.WriteLine(" (не X и Y) или Y = False");
            //----------------------------------------------------
            Console.WriteLine("\n ------------------------");
            Console.WriteLine(" Если X = FALSE\n      Y = TRUE");
            valX = false;
            if (!valX && !valY)
                Console.WriteLine(" не X и не Y = True");
            else
                Console.WriteLine(" не X и не Y = False");
            if (valX || (!valX && valY))
                Console.WriteLine(" X или (не X и Y) = True");
            else
                Console.WriteLine(" X или (не X и Y) = False");
            if ((!valX && valY) || valY)
                Console.WriteLine(" (не X и Y) или Y = True");
            else
                Console.WriteLine(" (не X и Y) или Y = False");
            //----------------------------------------------------
            Console.WriteLine("\n ------------------------");
            Console.WriteLine(" Если X = FALSE\n      Y = FALSE");
            valY = false;
            if (!valX && !valY)
                Console.WriteLine(" не X и не Y = True");
            else
                Console.WriteLine(" не X и не Y = False");
            if (valX || (!valX && valY))
                Console.WriteLine(" X или (не X и Y) = True");
            else
                Console.WriteLine(" X или (не X и Y) = False");
            if ((!valX && valY) || valY)
                Console.WriteLine(" (не X и Y) или Y = True");
            else
                Console.WriteLine(" (не X и Y) или Y = False");


            Console.WriteLine("\n\n\n\t\t---Для выхода нажмите любую клавишу!---");
            Console.ReadKey();
        }
    }
}
