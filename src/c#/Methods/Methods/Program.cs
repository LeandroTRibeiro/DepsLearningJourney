namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;

            // Chamada do método Sum, que retorna a soma de n1 e n2
            int startCount = Sum(n1, n2);

            // Chamada do método Countdown para realizar a contagem regressiva a partir de startCount
            Countdown(startCount);
            
            // Chamada do método ShowFactorial para calcular e exibir o fatorial de startCount
            Console.WriteLine(ShowFactorial(startCount));
        }

        // Método que soma dois números e retorna o resultado
        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        // Método que realiza uma contagem regressiva recursiva no console e nao retorna nada
        static void Countdown(int num)
        {
            Console.WriteLine(num);

            // Caso Base
            if (num <= 1)
            {
                return;
            }
            else // Caso Recursivo
            {
                // Chama o método Countdown novamente com num - 1
                Countdown(num - 1);
            }
        }

        // Método que calcula o fatorial de um número usando recursão e retorna o valor
        static int Fat(int num)
        {
            if (num == 1) // Caso Base
            {
                return 1;
            }
            else // Caso Recursivo
            {
                return num * Fat(num - 1);
            }
        }

        // Método que retorna o resultado do fatorial em uma string formatada
        static string ShowFactorial(int num)
        {
            // Chama o método Fat para calcular o fatorial e retorna o resultado formatado
            return $"O fatorial de {num} é {Fat(num)}!";
        }
    }
}