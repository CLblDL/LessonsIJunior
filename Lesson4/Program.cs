using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age = 0;
            string zodiacSign;
            string placeOfWork;

            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

            bool corectAge = false;

            while (!corectAge)
            {
                Console.WriteLine("Введите целое число лет");
                corectAge = int.TryParse(Console.ReadLine(), out age);
                if (corectAge)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Возраст введен не верно");
                }
            }

            Console.WriteLine("Введите знак зодиака");
            zodiacSign = Console.ReadLine();

            Console.WriteLine("Введите место работы");
            placeOfWork = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age} лет, вы {zodiacSign} и вы работаете {placeOfWork}.");
        }
    }
}
