using System;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Escolha entre PEDRA, PAPEL OU TESOURA:   ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "PEDRA";
                            Console.WriteLine("Computador escolheu PEDRA");
                            if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("Empatou!!\n\n");
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("Você ganhou!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("Computador ganhou!!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPEL";
                            Console.WriteLine("Computador escoulheu PAPEL");
                            if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("Empatour!!\n\n");
                            }
                            else if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("Computador ganhou!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("Você ganhou!!\n\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "TESOURA";
                            Console.WriteLine("Computador escoulheu TESOURA");
                            if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("Empatou!!\n\n");
                            }
                            else if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("Você ganhou!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("Computador ganhou!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Entrada inválida");
                                break;
                    }

                    Console.WriteLine("\n\nPONTOS:\tJogador:\t{0}\tComputador:\t{1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Jogador ganhou!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Computador ganhou!");
                }

                Console.WriteLine("Gostaria de jogar novamente?(s/n)");
                string loop = Console.ReadLine();
                if (loop == "s")
                    playAgain = true;

                else if (loop == "n")
                    playAgain = false;
            }
        }
    }
}
