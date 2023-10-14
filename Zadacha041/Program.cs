// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
 
class Program
{
    static void Main(string[] args)
    {
        int count = 0;
 
        while(true)
        {
            Console.Write("Введите число (для выхода введите 'exit'): ");
            string input = Console.ReadLine();
 
            if(input.ToLower() == "exit")
            {
                break;
            }
 
            int number;
            if(int.TryParse(input, out number)&& number > 0)
            {
                count++;
            }
        }
        
        Console.WriteLine("Количество введенных чисел больше 0: " + count);
        
}
}
