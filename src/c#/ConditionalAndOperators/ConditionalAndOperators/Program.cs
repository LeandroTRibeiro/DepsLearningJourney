using System;

namespace ConditionalStatementsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instruções de Seleção

            // Instruções de Seleção
            // if - if else - if else if  
            if (1 < 2)
            {
                Console.WriteLine("1 < 2");
            }
            
            if (2 < 1)
            {
                Console.WriteLine("2 < 1");
            }
            else
            {
                Console.WriteLine("!(2 < 1)");
            }

            if (2 < 1)
            {
                Console.WriteLine("2 < 1");
            } 
            else if (2 < 1)
            {
                Console.WriteLine("2 < 1");
            }
            else
            {
                Console.WriteLine("!(2 < 1)");
            }

            #endregion

            #region switch

            // switch
            int dayOfWeek = (int)DateTime.Today.DayOfWeek;
            
            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }

            #endregion

            #region Operadores de Comparação

            // Operadores de Comparação
            // > >= < <= == !=
            if (1 == 1)
            {
                Console.WriteLine("1 == 1");
            }
            
            if (1 != 2)
            {
                Console.WriteLine("1 != 2");
            }

            if (1 < 2)
            {
                Console.WriteLine("1 < 2");
            }

            if (2 > 1)
            {
                Console.WriteLine("2 > 1");
            }
            
            if (2 >= 2)
            {
                Console.WriteLine("2 >= 2");
            }
            
            if (1 <= 1)
            {
                Console.WriteLine("1 <= 1");
            }

            #endregion

            #region Operadores Lógicos

            // Operadores Lógicos
            // && || !
            if (1 < 2 && 2 > 1)
            {
                Console.WriteLine("1 < 2 && 2 > 1");
            }
            
            if (1 < 2 || 2 < 1)
            {
                Console.WriteLine("1 < 2 || 2 < 1");
            }

            if (!(1 > 2))
            {
                Console.WriteLine("!(1 > 2)");
            }

            #endregion

            #region Operadores Aritméticos

            // Operadores Aritméticos
            // + - * / % ++ --
            int a = 10;
            int b = 5;

            int addition = a + b;
            Console.WriteLine($"{a} + {b} = {addition}");

            int subtraction = a - b;
            Console.WriteLine($"{a} - {b} = {subtraction}");

            int multiplication = a * b;
            Console.WriteLine($"{a} * {b} = {multiplication}");

            int division = a / b;
            Console.WriteLine($"{a} / {b} = {division}");

            int modulo = a % b;
            Console.WriteLine($"{a} % {b} = {modulo}");

            int increment = a;
            increment++;
            Console.WriteLine($"Incremento de {a} é {increment}");

            int decrement = b;
            decrement--;
            Console.WriteLine($"Decremento de {b} é {decrement}");

            #endregion

            #region Condicionais ternárias

            // Condicionais ternárias
            // ? : ;
            Console.WriteLine(true ? "true" : "false");
            
            Console.WriteLine(false ? "true" : "false");

            #endregion
        }
    }
}
