using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int damage1 = 0, armor1 = 0, health1 = 0;
            string fraction1 = "";

            int damage2 = 0, armor2 = 0, health2 = 0;
            string fraction2 = "";

            bool isOpen = true;
            while (isOpen)
            {
                // Данные 1-го персонажа
                Console.SetCursorPosition(0, 0);
                TextColor("Характеристики персонажа №1: ", ConsoleColor.DarkGray);
                Console.Write($"\n\nФракция - {fraction1}\n\nЗдоровье - ");
                DrawBar(health1 / 10, 10, ConsoleColor.Green, health1); // Шакала здоровья у первого игрока 
                Console.Write($"\n\nЗащита - ");
                DrawBar(armor1 / 10, 10, ConsoleColor.Blue, armor1); // Шкала защиты у первого игрока
                Console.WriteLine($"\n\nУрон - {damage1}");
                // Данные 2-го персонажа
                Console.SetCursorPosition(0, 11);
                Console.WriteLine("-----------------------------------------");
                Console.SetCursorPosition(0, 13);
                TextColor("Характеристики персонажа №2: ", ConsoleColor.DarkGray);
                Console.Write($"\n\nФракция - {fraction2}\n\nЗдоровье - ");
                DrawBar(health2 / 10, 10, ConsoleColor.Green, health2); // Шакала здоровья у второго игрока 
                Console.Write($"\n\nЗащита - ");
                DrawBar(armor2 / 10, 10, ConsoleColor.Blue, armor2); // Шкала защиты у второго игрока
                Console.WriteLine($"\n\nУрон - {damage2}");
                // Меню действий
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("-----------------------------------------\n\n\n");
                Console.WriteLine("Выберите пункт:\n\n1 - Настроить персонажа №1\n2 - Настроить персонажа №2\n3 - Начать сражение\n\n0 - Выход\n\n\n");
                Console.Write("Введите действие, которое вы хотите выполнить: ");
                string input = Console.ReadLine();
                int value;
                string[] choice = { "0", "1", "2", "3" };
                while (choice.Contains(input) == false) 
                {
                    Console.WriteLine("Неверное значение... Попробуйте ещё раз");
                    input = Console.ReadLine();
                }
                value = int.Parse(input);
                if (value == 0)
                    break;
                else
                {
                    switch (value)
                    {
                        case 1: // Настройка первого персонажа
                            Console.Clear();
                            health1 = 100;
                            Console.Write("Выберите, к какой фракции будет принадлежать персонаж (Добрые, Злые, Нейтральные): ");
                            fraction1 = Console.ReadLine();
                            while (fraction1 != "Добрые" && fraction1 != "Злые" && fraction1 != "Нейтральные")
                            {
                                Console.WriteLine("Неверное наименование фракции... Попробуйте еще раз");
                                fraction1 = Console.ReadLine();
                            }
                            Console.Write("\n\nВыберите значение базовой защиты (от 0 до 99): ");                           
                            string inputArmor = Console.ReadLine();
                            while (int.TryParse(inputArmor, out armor1) == false || armor1 < 0 || armor1 > 99)
                            {
                                Console.WriteLine("Неверное значение... Попробуйте ещё раз");
                                inputArmor = Console.ReadLine();
                            }
                            Console.Write("\n\nВыберите значение урона, который будет наносить ваш персонаж (от 1 до 75): ");
                            string inputDamage = Console.ReadLine();
                            while (int.TryParse(inputDamage, out damage1) == false || damage1 < 1 || damage1 > 75)
                            {
                                Console.WriteLine("Неверное значение... Попробуйте ещё раз");
                                inputDamage = Console.ReadLine();
                            }
                            Console.Clear();
                            Console.WriteLine("Характеристики персонажа №1: ");
                            Console.Write($"\n\nФракция - {fraction1}\n\nЗдоровье - ");
                            DrawBar(health1 / 10, 10, ConsoleColor.Green, health1);
                            Console.Write($"\n\nЗащита - ");
                            DrawBar(armor1 / 10, 10, ConsoleColor.Blue, armor1);
                            Console.WriteLine($"\n\nУрон - {damage1}");
                            break;
                        case 2: // Настройка второго персонажа
                            Console.Clear();
                            health2 = 100;
                            Console.Write("Выберите, к какой фракции будет принадлежать персонаж (Добрые, Злые, Нейтральные): ");
                            fraction2 = Console.ReadLine();
                            while (fraction2 != "Добрые" && fraction2 != "Злые" && fraction2 != "Нейтральные")
                            {
                                Console.WriteLine("Неверное наименование фракции... Попробуйте еще раз");
                                fraction2 = Console.ReadLine();
                            }
                            Console.Write("\n\nВыберите значение базовой защиты (от 0 до 99): ");
                            inputArmor = Console.ReadLine();
                            while (int.TryParse(inputArmor, out armor2) == false || armor2 < 0 || armor2 > 99)
                            {
                                Console.WriteLine("Неверное значение... Попробуйте ещё раз");
                                inputArmor = Console.ReadLine();
                            }
                            Console.Write("\n\nВыберите значение урона, который будет наносить ваш персонаж (от 1 до 75): ");
                            inputDamage = Console.ReadLine();
                            while (int.TryParse(inputDamage, out damage2) == false || damage2 < 1 || damage2 > 75)
                            {
                                Console.WriteLine("Неверное значение... Попробуйте ещё раз");
                                inputDamage = Console.ReadLine();
                            }
                            Console.Clear();
                            Console.WriteLine("Характеристики персонажа №1: ");
                            Console.Write($"\n\nФракция - {fraction2}\n\nЗдоровье - ");
                            DrawBar(health2 / 10, 10, ConsoleColor.Green, health2);
                            Console.Write($"\n\nЗащита - ");
                            DrawBar(armor2 / 10, 10, ConsoleColor.Blue, armor2);
                            Console.WriteLine($"\n\nУрон - {damage2}");
                            break;
                        case 3: // Бой
                            if (fraction1 == "" || fraction2 == "") // Проверка, заполнены ли данные персонажей
                            {
                                Console.WriteLine("\nСначала настройте обоих персонажей");
                                break;
                            }
                            else
                            {
                                // Проверка, есть ли баф или дебаф на урон
                                float damageBafDebaf = 1f;
                                if (fraction1 == fraction2 && (fraction1 == "Добрые" || fraction1 == "Злые"))
                                {
                                    damageBafDebaf = 0.5f;
                                }
                                else if ((fraction1 == "Добрые" && fraction2 == "Злые") || (fraction1 == "Злые" && fraction2 == "Добрые"))
                                {
                                    damageBafDebaf = 1.5f;
                                }
                                float health1f = Convert.ToSingle(health1);
                                float health2f = Convert.ToSingle(health2);
                                float maxDamage1 = 0, maxDamage2 = 0;
                                Random rand = new Random();
                                while (health1f > 0 && health2f > 0)
                                {
                                    if (health1f < 35) // Берсерк у первого игрока
                                    {
                                        bool berserk1 = Convert.ToBoolean(rand.Next(0, 2));
                                        switch (berserk1) 
                                        {
                                            case true:
                                                if ((armor1 - 80) < 0) armor1 = 0;
                                                else armor1 -= 80;
                                                damage1 *= 2;
                                                break;
                                            case false:
                                                break;
                                        }
                                    }
                                    if (health2f < 35) // Берсерк у второго игрока 
                                    {
                                        bool berserk2 = Convert.ToBoolean(rand.Next(0, 2));
                                        switch (berserk2) 
                                        {
                                            case true:
                                                if ((armor2 - 80) < 0) armor2 = 0;
                                                else armor2 -= 80;
                                                damage2 *= 2;
                                                break;
                                            case false:
                                                break;
                                        }
                                    }
                                    // Процесс боя
                                    maxDamage1 = (Convert.ToSingle(damage1) * damageBafDebaf) * (1.0f - Convert.ToSingle(armor2) / 100);
                                    maxDamage2 = (Convert.ToSingle(damage2) * damageBafDebaf) * (1.0f - Convert.ToSingle(armor1) / 100);
                                    health1f -= maxDamage2;
                                    health2f -= maxDamage1;

                                }
                                // Объявление победителя
                                if (health1f < health2f)
                                    Console.WriteLine($"Победил игрок №2!!! У него осталось {health2f + maxDamage1}HP");
                                else if (health1f == health2f)
                                    Console.WriteLine("Ничья!");
                                else
                                    Console.WriteLine($"Победил игрок №1!!! У него осталось {health1f + maxDamage1}HP");
                            }
                            break;
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
        
        private static void TextColor(string text, ConsoleColor color) // Настройка цвета текста
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = defaultColor;
        }

        private static void DrawBar(int len, int maxLen, ConsoleColor color, int value) // Настройка шкалы 
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < len; i++)
            {
                bar += " ";
            }
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";
            for (int i = len; i < maxLen; i++)
            {
                bar += " ";
            }
            Console.Write($"{bar}] {value}%");


        }

    }
}
