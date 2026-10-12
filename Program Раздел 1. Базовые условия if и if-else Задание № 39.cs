using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program39
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Уровень громкости (0–100): ");
            if (int.TryParse(Console.ReadLine(), out int volume) && volume >= 0 && volume <= 100)
            {
                if (volume > 80)
                    Console.WriteLine("Слишком громко для слуха");
                else
                    Console.WriteLine("Громкость в норме.");
            }
            else
            {
                Console.WriteLine("Ошибка: громкость должна быть от 0 до 100.");
            }
        }
    }
}