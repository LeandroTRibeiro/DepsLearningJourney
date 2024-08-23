using System;

namespace ConditionalStatementsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
                Console.WriteLine("!(2 < 1");
            }

            if (2 < 1)
            {
                Console.WriteLine("2 < 1");
            } else if (2 < 1)
            {
                Console.WriteLine("2 < 1");
            }
            else
            {
                Console.WriteLine("!(2 < 1)");
            }

            // switch
            
            int dayOfWeek = (int)DateTime.Today.DayOfWeek;
            
            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("Monday");
                    break;
                case 1:
                    Console.WriteLine("Tuesday");
                    break;
                case 2:
                    Console.WriteLine("Wednesday");
                    break;
                case 3:
                    Console.WriteLine("Thursday");
                    break;
                case 4:
                    Console.WriteLine("Friday");
                    break;
                case 5:
                    Console.WriteLine("Saturday");
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }

            
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
            
            // Operadores Lógicos
            // && || !
            if (1 < 2 && 2 > 1)
            {
                Console.WriteLine("1 < 2 && 2 > 1");
            }
            
            if (1 < 2 || 2 > 1)
            {
                Console.WriteLine("1 < 2 || 2 < 1");
            }

            if (!(1 > 2))
            {
                Console.WriteLine("!(1 > 2)");
            }
            
            //Operadores Aritméticos
            
            
            
            // Condicionais ternárias
            // ? : ;
            Console.WriteLine(true ? "true" : "false");
            
            Console.WriteLine(false ? "true" : "false");
            
        }
    }
}