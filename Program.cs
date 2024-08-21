
using System;

namespace TaskJunior2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "exit";
            string userInput;

            int triesCount = 3;

            Console.WriteLine("Приветствую тебя супер секретный агент.\n" +
                             $"У вас есть {triesCount} попытки отгадать.\nВведите пароль : ");

            for (int i = 0; i < triesCount; ++i)
            {
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("\nУрааа!!!, вот ваши самые секретные данные)))");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправельный пароль, попробуйте еще раз!\n");
                }
            }
        }
    }
}
