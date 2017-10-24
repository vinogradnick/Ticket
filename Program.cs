using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num = new int[6],//Массив для записи числа
                  _1000lucky = new int[1000];//Массив счастливых билетов на тысячу

            int a,//Нахождение частей числа
                j = 1000,//Счетчик по тысячам
                Counter = 0,//Счетчик для билетов на тысячу
                luckyCount = 0;//Количество счастливых билетов


            for (int i = 0; i <= 999999; i++)
            {
                a = (i / 1000);
                Num[2] = (a % 10);
                a = (a % 100);
                Num[1] = (a / 10);
                Num[0] = (i / 100000);
                a = (i % 1000);
                Num[3] = (a / 100);
                a = (a % 100);
                Num[4] = (a / 10);
                Num[5] = (a % 10);

                if ((Num[0] + Num[1] + Num[2]) == (Num[3] + Num[4] + Num[5]))//Проверка суммы конца и начала
                {
                    if (i <= j)
                    {
                        _1000lucky[Counter]++;//Счет счастливых билетов на тысячу
                    }
                    else
                    {
                        j = j + 1000;//Увелечение счетчика
                        _1000lucky[Counter]++;//Увелечение значения
                        Counter++;//Переход к следующей тысяче
                    }
                    luckyCount++;//Увелечение счетчика общего чис
                    Console.WriteLine("Билет = {0}{1}{2}{3}{4}{5} Количество счастливых билетов = {6}", Num[0], Num[1], Num[2], Num[3], Num[4], Num[5], luckyCount);

                }
            }

            Counter = 0;
            j = 0;

            for (int i = 1000; i < 101000; i = i + 1000)
            {
                Console.WriteLine("Счастливых билетов с {0} по {1} равно {2}", i - 1000, i, _1000lucky[j]);
                j++;
            }
            Console.ReadLine();
        }
    }
}
