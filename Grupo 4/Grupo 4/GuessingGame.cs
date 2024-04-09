public static class GuessingGame
{
    public static void Play()
    {
        Console.WriteLine("Vou pensar em um número entre 1 e 100. Tente adivinhar!");
        Console.WriteLine("Digite 0 para sair:");

        Random random = new Random(); // Cria um objeto para gerar números aleatórios
        int numeroSecreto = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
        int tentativas = 0; // Contador de tentativas
        bool acertou = false; // Variável para verificar se o jogador acertou

        while (tentativas < 3 && !acertou) // Loop até o jogador acertar ou até 3 tentativas
        {
            Console.Write("Digite um número: ");
            string Entrada = Console.ReadLine();
            int palpite;

            if (int.TryParse(Entrada, out palpite)) // Verifica se a entrada é um número válido
            {
                if (palpite == 0)
                {
                    Console.WriteLine("Você saiu do jogo.");
                    break; // Sai do loop se o jogador digitar 0
                }

                tentativas++;
                if (palpite == numeroSecreto)
                {
                    acertou = true;
                    Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
                    break;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Muito alto. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }

        if (!acertou)
        {
            Console.WriteLine($"Você não conseguiu adivinhar o número secreto {numeroSecreto} em 3 tentativas.");         
        }
    }
}
