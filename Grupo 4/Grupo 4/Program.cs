using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entrada = true;

            do
            {
                try
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. somar numeros");
                    Console.WriteLine("2. Converter de metros para milímetros");
                    Console.WriteLine("3. Calcula Aumento ");
                    Console.WriteLine("4. Calcula Desconto ");
                    Console.WriteLine("5. Aluguel Carro");
                    Console.WriteLine("6. Calcular IMC");
                    Console.WriteLine("7. Cantoneira até número fornecido");
                    Console.WriteLine("8. Tabuada de cada número ");
                    Console.WriteLine("9. Múltiplos de 3 entre 0 e 100");
                    Console.WriteLine("10. Fatoriais de 1 até 10");
                    Console.WriteLine("11. Imposto de Renda");
                    Console.WriteLine("12. Adivinhar número");
                    Console.WriteLine("13. Financiamento do veículo");
                    Console.WriteLine("14. Aposentadoria");
                    Console.WriteLine("15. Jogo da velha");
                    Console.WriteLine("0. Sair");
                    Console.Write("Escolha uma opção: ");
                    int escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 8:
                            Console.Write("Digite um número (1 para estatico ou 2 para normal): ");
                            string entradA = Console.ReadLine();
                            int numero;

                            if (int.TryParse(entradA, out numero)) // Verifica se a entrada é um número válido
                            {
                                Console.Write("Digite um número para a tabuada: ");
                                string Entrada = Console.ReadLine();
                                int valor;
                                if (int.TryParse(Entrada, out valor))
                                {
                                    if (numero == 1)
                                    {
                                        Console.WriteLine(TabuadaEstatica.Calcular(valor));
                                    }
                                    else if (numero == 2)
                                    {
                                        Tabuada tabuada = new Tabuada();
                                        string resultado = tabuada.Calcular(valor);
                                        Console.WriteLine(resultado);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Por favor, digite 1 ou 2.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Por favor, digite um número válido.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Por favor, digite um número válido.");
                            }
                            break;
                        case 12:
                            GuessingGame.Play();
                            break;

                        case 0:
                            Console.WriteLine("Saindo do programa...");
                            entrada = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato inválido. Tente novamente.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Número muito grande. Tente novamente.");
                }
            } while (entrada);

        }
    }
}
