namespace DiamanteDeLetra.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letraEscolhida = 'E';

            int quantidadeDeEspacos = -1;

            DesenharParteSuperior(letraEscolhida, ref quantidadeDeEspacos);

            quantidadeDeEspacos -= 4;
            letraEscolhida--;

            DesenharParteInferior(letraEscolhida, ref quantidadeDeEspacos);

            Console.ReadLine();
        }

        private static void DesenharParteInferior(char letraEscolhida, ref int quantidadeDeEspacos)
        {
            char primeiraLetra = 'A';
            int tamanhoMargem = 1;

            for (char letra = letraEscolhida; letra >= primeiraLetra; letra--)
            {
                //escrever a margem
                for (int i = 0; i < tamanhoMargem; i++)
                {
                    Console.Write(" ");
                }

                tamanhoMargem++;

                //escrevar a letra da esquerda do diamante
                Console.Write(letra);

                //escrevendo os espacos entre as letras
                for (int i = 0; i < quantidadeDeEspacos; i++)
                {
                    Console.Write(" ");
                }

                quantidadeDeEspacos -= 2;

                //escrevar a letra da direita do diamante
                if (letra == 'A')
                    Console.WriteLine();
                else
                    Console.WriteLine(letra);
            }
        }

        private static void DesenharParteSuperior(char letraEscolhida, ref int quantidadeDeEspacos)
        {
            char primeiraLetra = 'A';

            quantidadeDeEspacos = -1;

            int tamanhoMargem = letraEscolhida - primeiraLetra;

            // (char)(letraEscolhida - 1) -> CAST -> conversão explícita
            for (char letra = 'A'; letra <= letraEscolhida; letra++)
            {
                //escrever a margem
                for (int i = 0; i < tamanhoMargem; i++)
                {
                    Console.Write(" ");
                }

                tamanhoMargem--;

                //escrevar a letra da esquerda do diamante
                Console.Write(letra);

                //escrevendo os espacos entre as letras
                for (int i = 0; i < quantidadeDeEspacos; i++)
                {
                    Console.Write(" ");
                }

                quantidadeDeEspacos += 2;

                //escrevar a letra da direita do diamante
                if (letra == 'A')
                    Console.WriteLine();
                else
                    Console.WriteLine(letra);
            }
        }
    }
}