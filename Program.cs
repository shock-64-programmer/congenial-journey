using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игра
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int otvet;
            Console.WriteLine("Привет.Сыграем в игру УГАДАЙ ЧИСЛО! Я загдываю число, а ты угадываешь.");
            Console.WriteLine("Я загадал число от 1 до 10. У тебя есть 3 попыток, чтобы его узнать!");
            Console.WriteLine("Введите число:");
            int chislo = r.Next(1, 10);
            int i;
            for (i = 0; i < 3; i++)
            {
                otvet = Convert.ToInt32(Console.ReadLine());
                if (otvet != chislo)
                {
                    Console.WriteLine("Неверный ответ!");
                }
                if (otvet == chislo)
                {
                    Console.WriteLine("ВЫ угадали за {0} попыток! Загадонное число = {1}!", i, chislo);
                }
            }
            Console.WriteLine("К сожалению вы проиграли!");
            Console.ReadLine();
        }
    }
}
