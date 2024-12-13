using Tyuiu.SavchenkoEI.Lab1.Review.V9.Lib;

namespace Tyuiu.SavchenkoEI.Lab1.TaskReview.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Лабораторная работа #1 | Выполнил: Савченко Е.И. | НТм-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #1                                                  *");
            Console.WriteLine("* Тема: Базовые навыки создания консольных приложений по методологии TDD. *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Савченко Егор Игоревич  | НТм-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("* Ответ округлить до трех знаков после запятой.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значение X:                                                     *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите значение Y:                                                     *");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calc(x, y));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
