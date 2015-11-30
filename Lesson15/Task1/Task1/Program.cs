﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                string rez = null;

                Console.WriteLine("Введите значение 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значенте 2");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Выберете действие: ");
                Console.WriteLine(" 1: Сложить\n 2: Вычесть \n 3: Умножить\n 4: Разделить \n");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        rez = calculator.Add(num1, num2);
                        break;
                    case 2:
                        rez = calculator.Sub(num1, num2);
                        break;
                    case 3:
                        rez = calculator.Mul(num1, num2);
                        break;
                    case 4:
                        rez = calculator.Div(num1, num2);
                        break;
                }
                Console.WriteLine("Результат: {0} ", rez);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            catch (Exception ex)
            {
                Console.WriteLine("При выполнении произошла ошибка {0} ",ex);
            }


            Console.ReadLine();
        }
    }
}