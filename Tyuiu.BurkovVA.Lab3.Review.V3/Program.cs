using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveMathFirstExpression.Lib;
using SolveMathSecondExpression.Lib;
using SolveTabMathFunction.Lib;
using SolveCalculate.Lib;
using SolveArray.Lib;

namespace Tyuiu.BurkovVA.Lab3.Review.V3
{
    class Program
    {
        public static int indexItem;

        static void UpArrow()
        {
            indexItem--;
            if (indexItem < 1)
            {
                indexItem = 5;
            }

            drawMainMenu();
        }

        static void DownArrow()
        {
            indexItem++;
            if (indexItem > 5)
            {
                indexItem = 1;
            }

            drawMainMenu();
        }

        static void selectItem()
        {
            switch (indexItem)
            {
                case 1:
                    Option1();
                    break;

                case 2:
                    Option2();
                    break;

                case 3:
                    Option3();
                    break;

                case 4:
                    Option4();
                    break;

                case 5:
                    Option5();
                    break;


            }
        }

        static void Option1()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("РАССЧИТАТЬ ПЕРВОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.SetCursorPosition(0, 3);
            Console.WriteLine(" УСЛОВИЕ: ");
            Console.WriteLine(" Написать программу, которая вычисляет значение математического " +
                "\n выражения по исходным данным, вводимых пользователем.");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine(" Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("* РЕЗУЛЬТАТ: ");
            MathFirstExpression cl = new MathFirstExpression();
            Console.WriteLine(cl.CalculateFirstExpression(a, x, y));
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в гланое меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }

            else
            {
                Option1();
            }
        }   
        static void Option2()
            {
                Console.Clear();

                Console.ResetColor();
                Console.WriteLine(" РАССЧИТАТЬ ВТОРОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ");
                Console.WriteLine("-------------------------------------------------------------------");

                Console.SetCursorPosition(1, 3);
                Console.WriteLine("УСЛОВИЕ: ");
                Console.WriteLine(" Написать программу, которая вычисляет значение математического " +
                    "\n выражения по исходным данным, вводимых пользователем.");
                Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ: ");
                Console.WriteLine(" Введите значение X:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Введите значение Y:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Введите значение A:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine(" РЕЗУЛЬТАТ: ");
                MathSecondExpression cl = new MathSecondExpression();
                Console.WriteLine(" " + cl.CalculateMathSecondExpression(a, x, y));
                Console.SetCursorPosition(0, 22);
                Console.WriteLine("-------------------------------------------------------------------");

                Console.SetCursorPosition(0, 24);
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("[ESC]");
                Console.ResetColor();
                Console.Write(" - Вернуться в гланое меню");
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Red;
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    drawMainMenu();
                }

                else
                {
                    Option2();
                }
        }

        static void Option3()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("ПРОТАБУЛИРОВАТЬ ФУНКЦИЮ НА ЗАДАННОМ ДИАПАЗОНЕ");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" УСЛОВИЕ:                                                          ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" Написать программу, которая вычисляет математическое выражение по ");
            Console.WriteLine(" исходным значениям, находящимся в массиве                         ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                  ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" Массив значений                                                   ");
            Console.WriteLine(" Math.Pow(i, 2) - Math.Pow(i, 3)) - ((Math.Pow(Math.Cos(i), 3) + 7 ");
            Console.WriteLine(" Math.Pow(i, 2))/((Math.Pow(i, 3)-15*i)))/(Math.Pow(Math.Cos(i),2))");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Введите начальное значение: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение: ");
            int stop = Convert.ToInt32(Console.ReadLine());
            string s = "";
            TabMathFunction cl = new TabMathFunction();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                        ");
            Console.WriteLine("-------------------------------------------------------------------");

            double[] res = cl.CalculateFirstExpression(start, stop);
            Console.WriteLine("+------------+------------+");
            Console.WriteLine("     X       |      f(x)   ");
            Console.WriteLine("+------------+------------+");
            int count = start;
            for (int i = 0; i < stop - start + 1; i++)
            {

                Console.WriteLine("    " + count + "        |    " + res[i] +"     ");
                count++;


            }
            Console.WriteLine("+------------+------------+");
            Console.WriteLine(s);

            Console.WriteLine("-------------------------------------------------------------------");


            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в гланое меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.Clear();
                drawMainMenu();
            }

            else
            {
                Option3();
            }
        }

        static void OptionF5()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("СПРАВКА");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine(" Справочные сведения по работе с программой");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine(" РАЗДЕЛ МЕНЮ ");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine(" ОПИСАНИЕ ");
            Console.SetCursorPosition(64, 6);
            Console.WriteLine(" ПАРАМЕТР КОМ. СТРОКИ ");
            Console.SetCursorPosition(1, 8);
            Console.WriteLine(" 1. РАССЧИТАТЬ ПЕРВОЕ МАТ. ВЫРАЖЕНИЕ ");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine(" Вычисляет матем. выражение  3 * x - (3 * x + a - 4 * a) / " +
                "\n (3 * a + 2 * x + 6 * y) + ((a * x) / y + a / 2) / (3 * a / x) + 2 * x");
            Console.SetCursorPosition(64, 8);
            Console.WriteLine(" /1 ");
            Console.SetCursorPosition(1, 10);
            Console.WriteLine(" 2. РАССЧИТАТЬ ВТОРОЕ МАТ. ВЫРАЖЕНИЕ ");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine(" Вычисляет матем. выражение 4 * x + ((2 + y + x - 3 * a) / (x - 7 * y)) - " +
                "\n (a / y / 3 * a / x) ");
            Console.SetCursorPosition(64, 10);
            Console.WriteLine(" /2 ");
            Console.SetCursorPosition(1, 12);
            Console.WriteLine(" 3. ПРОТАБУЛИРОВАТЬ ФУНКЦИЮ ");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine(" Табулирует функцию  ");
            Console.SetCursorPosition(64, 12);
            Console.WriteLine(" /3 ");
            Console.SetCursorPosition(1, 14);
            Console.WriteLine(" 4. КАЛЬКУЛЯТОР ");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine(" Выполняет расчет +, -, *, / ");
            Console.SetCursorPosition(64, 14);
            Console.WriteLine(" /4 ");
            Console.SetCursorPosition(1, 16);
            Console.WriteLine(" 5. ОБРАБОТКА ОДНОМЕРНОГО МАССИВА ");
            Console.SetCursorPosition(64, 16);
            Console.WriteLine(" /5 ");
            Console.SetCursorPosition(1, 21);
            Console.WriteLine(" Программу разработал БУРКОВ ВИТАЛИЙ АНДРЕЕВИЧ | МКМб-22-1 | ТИУ 2024 ");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }

            else
            {
                OptionF5();
            }
        }

        static void Option4()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("  КАЛЬКУЛЯТОР ");
            Console.WriteLine(" -------------------------------------------------------------------");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" УСЛОВИЕ:                                                          ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" Запрограммировать калькулятор                                     ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" Введите первое число:                                             ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите второе число:                                             ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите одно из действий (+, -, *,)                               ");
            string c = Console.ReadLine();
            Calculate zn = new Calculate();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" РЕЗУЛЬТАТ: ");
            switch (c)
            {
                case "+":
                    Console.WriteLine(a + " + " + b + " = ");
                    Console.WriteLine(zn.CalculateSumma(a, b));
                    
                    break;

                case "-":
                    Console.WriteLine(a + " - " + b + " = ");
                    Console.WriteLine(zn.CalculateDifference(a, b));
                    break;

                case "*":
                    Console.WriteLine(a + " * " + b + " = ");
                    Console.WriteLine(zn.CalculateMultiplication(a, b));
                    break;

                case "/":
                    Console.WriteLine(a + " / " + b + " = ");
                    Console.WriteLine(zn.CalculateQutient(a, b));
                    break;

                default:
                    Console.Clear();
                    drawMainMenu();
                    break;
            }
            Console.WriteLine("-------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option4();
            }
        }

        static void Option5()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine(" ОБРАБОТКА ОДНОМЕРНОГО МАССИВА ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" УСЛОВИЕ:                                                          ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" Написать программу, находящую минимум, максимум, среднее, медиану," +
                " количество четных и нечетных чисел, количество чисел делящихся на 2, 3, 5, 10   " +
                " среди значений массива                                                          ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" Введите длину массива:                                            ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите первое число диапазона значений:                          ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите второе число диапазона значений:                          ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите желаемое действие (max, min, avr, med, even, odd, div2,   " +
                "div3, div5, div10)                                                               ");
            string str = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" РЕЗУЛЬТАТ: ");
            MyArray ar = new MyArray();
            switch (str)
            {
                case "max":
                    Console.WriteLine(ar.CalculateMaximum(a, X1, X2));
                    break;

                case "min":
                    Console.WriteLine(ar.CalculateMinimum(a, X1, X2));
                    break;

                case "avr":
                    Console.WriteLine(ar.CalculateAverage(a, X1, X2));
                    break;

                case "med":
                    Console.WriteLine(ar.CalculateMedian(a, X1, X2));
                    break;

                case "even":
                    ar.CalculateNumberOfEven(a, X1, X2);
                    break;

                case "odd":
                    ar.CalculateNumberOfOdd(a, X1, X2);
                    break;

                case "div2":
                    ar.SignsOfDivisibilityByTwo(a, X1, X2);
                    break;

                case "div3":
                    ar.SignsOfDivisibilityByThree(a, X1, X2);
                    break;

                case "div5":
                    ar.SignsOfDivisibilityByFive(a, X1, X2);
                    break;

                case "div10":
                    ar.SignsOfDivisibilityByTen(a, X1, X2);
                    break;

                default:
                    Console.Clear();
                    drawMainMenu();
                    break;
            }

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option5();
            }
        }

        static void OptionExit()
        {
            Environment.Exit(0);
        }

        static void drawMainMenu()
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.ResetColor();
            Console.Write("||=======================================================================||");
            Console.SetCursorPosition(0, 1);
            Console.Write("||                     Лабораторная работа №3                            ||");
            Console.SetCursorPosition(0, 2);
            Console.Write("||                 Создание консольного интерфейса                       ||");
            Console.SetCursorPosition(0, 3);
            Console.Write("||                Выполнил Бурков Виталий Андреевич                      ||");
            Console.SetCursorPosition(0, 4);
            Console.Write("||                    ТИУ 2024, группа МКМб-22-1                         ||");
            Console.SetCursorPosition(0, 5);
            Console.Write("||=======================================================================||");
            Console.WriteLine("  ");
            switch (indexItem)
            {
                case 0:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выражение ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выражение ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 4. ");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива ");
                    break;

                case 1:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выражение ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выражение ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 4. ");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива ");
                    break;

                case 2:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выражение ");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выражение ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 4. ");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива ");
                    break;

                case 3:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выражение ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выражение ");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 4. ");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива ");
                    break;

                case 4:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выражение ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выражение ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне ");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write(" 4. ");
                    Console.WriteLine(" Калькулятор ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива ");
                    break;

                case 5:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 1. ");
                    Console.WriteLine(" Рассчитать первое математическое выражение ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 2. ");
                    Console.WriteLine(" Рассчитать второе математическое выражение ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 3. ");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write(" 4. ");
                    Console.WriteLine(" Калькулятор ");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write(" 5. ");
                    Console.WriteLine(" Обработка одномерного массива ");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine(" Выберите пункт меню стрелками или укажите номер пункта [ ] ");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("[F1]");
            Console.ResetColor();
            Console.Write(" - Справка | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("[F10]");
            Console.ResetColor();
            Console.Write(" - Выход  Перемещение: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write(" [СТРЕЛКА ВНИЗ] ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write(" [СТРЕЛКА ВВЕРХ ");
            Console.ResetColor();

            Console.SetCursorPosition(57, 15);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                    Option1();
                    break;

                case ConsoleKey.NumPad2:
                    Option2();
                    break;

                case ConsoleKey.NumPad3:
                    Option3();
                    break;

                case ConsoleKey.NumPad4:
                    Option4();
                    break;

                case ConsoleKey.NumPad5:
                    Option5();
                    break;

                case ConsoleKey.F1:
                    OptionF5();
                    break;

                case ConsoleKey.F10:
                    OptionExit();
                    break;

                default:
                    drawMainMenu();
                    break;

                case ConsoleKey.UpArrow:
                    UpArrow();
                    break;

                case ConsoleKey.DownArrow:
                    DownArrow();
                    break;

                case ConsoleKey.Enter:
                    selectItem();
                    break;

            }

        }
    static void Main(string[] args)
        {
            Console.SetWindowSize(90, 25);
            Console.SetBufferSize(90, 25);

            foreach(string arg in args)
            {
                if (arg == "\\1")
                {
                    Option1();
                }
                if (arg == "\\2")
                {
                    Option2();
                }
                if (arg == "\\3")
                {
                    Option3();
                }
                if (arg == "\\4")
                {
                    Option4();
                }
                if (arg == "\\5")
                {
                    Option5();
                }
            }

            drawMainMenu();
            Console.ReadKey();
        }
    }
}
