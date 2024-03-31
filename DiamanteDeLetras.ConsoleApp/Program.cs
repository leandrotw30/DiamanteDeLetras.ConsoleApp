using System.Text;

namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra para desenhar o diamante:");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());

            int tamanhoDoDiamante = letra - 'A' + 1;

            for (int linha = 0; linha < tamanhoDoDiamante; linha++)
            {
                for (int coluna = 0; coluna < tamanhoDoDiamante - linha - 1; coluna++)
                {
                    Console.Write(" ");
                }

                Console.Write(Convert.ToChar('A' + linha));

                for (int coluna = 0; coluna < 2 * linha - 1; coluna++)
                {
                    Console.Write(" ");
                }

                if (linha != 0)
                {
                    Console.Write(Convert.ToChar('A' + linha));
                }

                Console.WriteLine();
                Console.WriteLine(); 
            }

            for (int linha = tamanhoDoDiamante - 2; linha >= 0; linha--)
            {
                for (int coluna = 0; coluna < tamanhoDoDiamante - linha - 1; coluna++)
                {
                    Console.Write(" ");
                }

                Console.Write(Convert.ToChar('A' + linha));

                for (int coluna = 0; coluna < 2 * linha - 1; coluna++)
                {
                    Console.Write(" ");
                }

                if (linha != 0)
                {
                    Console.Write(Convert.ToChar('A' + linha));
                }

                Console.WriteLine();
                Console.WriteLine(); 
            }
        }
    }
}

