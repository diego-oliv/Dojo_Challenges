using System;
using System.Collections.Generic;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int startOption = 0;
            int playerChoiceINT = 0;
            string machineChoice = "";
            string playerChoice = "";
            System.Console.WriteLine("==========================");
            System.Console.WriteLine("         Jokenpo");
            System.Console.WriteLine("==========================");
            System.Console.WriteLine("");
            System.Console.WriteLine("(0) Sair");
            System.Console.WriteLine("(1) Dois jogadores");
            System.Console.WriteLine("(2) Contra a máquina");
            System.Console.Write("    Escolha uma opção: ");

            startOption = int.Parse(Console.ReadLine());
            if (startOption != 0)
            {
                switch (startOption)
                {
                    case (1):
                    Console.Clear();
                    Console.WriteLine("Em construção!");
                    break;

                    case (2):
                    bool playerContinue = true;
                    while(playerContinue)
                    {
                        Console.Clear();
                        ShowOptions();
                        System.Console.Write("Sua escolha é: ");
                        playerChoiceINT = int.Parse(Console.ReadLine());
                        playerChoice = PlayerChoice(playerChoiceINT);
                        Random random = new Random();
                        int machineChoiceINT = random.Next(1,99);
                        machineChoice = MachineChoice();
                        bool comparison = machineChoice.Equals(playerChoice);
                        if (comparison)
                        {
                            System.Console.WriteLine($"Sua escolha foi {playerChoice}, a máquina escolhe {machineChoice}");
                            System.Console.WriteLine("Empate :D");
                        } if (!comparison && ((machineChoice == "Pedra") && (playerChoice == "Tesoura")))
                        {
                            System.Console.WriteLine($"Sua escolha foi {playerChoice}, a máquina escolhe {machineChoice}");
                            PlayerLose();
                        } if (!comparison && ((machineChoice == "Pedra") && (playerChoice == "Papel")))
                        {
                            System.Console.WriteLine($"Sua escolha foi {playerChoice}, a máquina escolhe {machineChoice}");
                            PlayerWin();
                        } if (!comparison && ((machineChoice == "Papel") && (playerChoice == "Pedra")))
                        {
                            System.Console.WriteLine($"Sua escolha foi {playerChoice}, a máquina escolhe {machineChoice}");
                            PlayerLose();
                        } if (!comparison && ((machineChoice == "Papel") && (playerChoice == "Tesoura")))
                        {
                            System.Console.WriteLine($"Sua escolha foi {playerChoice}, a máquina escolhe {machineChoice}");
                            PlayerWin();
                        } if (!comparison && ((machineChoice == "Tesoura") && (playerChoice == "Papel")))
                        {
                            System.Console.WriteLine($"Sua escolha foi {playerChoice}, a máquina escolhe {machineChoice}");
                            PlayerLose();
                        } if (!comparison && ((machineChoice == "Tesoura") && (playerChoice == "Pedra")))
                        {
                            System.Console.WriteLine($"Sua escolha foi {playerChoice}, a máquina escolhe {machineChoice}");
                            PlayerWin();
                        }
                        string continueOption = "";
                        System.Console.WriteLine("===================================");
                        System.Console.WriteLine("        Deseja continuar?");
                        System.Console.WriteLine("===================================");
                        System.Console.WriteLine("(S) Continuar");
                        System.Console.WriteLine("(N) Sair do jogo");
                        continueOption = Console.ReadLine().ToLower();
                        if (continueOption == "s")
                        {
                            playerContinue = true;
                        } if (continueOption == "n")
                        {
                            playerContinue = false;
                        }
                    }
                    break;
                }
            } else {
                Console.Clear();
                System.Console.WriteLine("Até um outro dia, amigo! :D");
            }
        }
        private static string MachineChoice()
        {
            string machineChoice = "";
            Random random = new Random();
            int machineChoiceINT = random.Next(1,99);
            if((machineChoiceINT >= 1) && (machineChoiceINT < 34))
            {
                machineChoice = "Pedra";
            } if((machineChoiceINT >= 34) && (machineChoiceINT < 67))
            {
                machineChoice = "Papel";
            } if ((machineChoiceINT >= 67) && (machineChoiceINT < 100))
            {
                machineChoice = "Tesoura";
            }
            return machineChoice;
        }
        private static string PlayerChoice(int playerChoiceINT)
        {
            string playerChoice = "";
            if (playerChoiceINT == 1)
            {
                playerChoice = "Pedra";
            } if (playerChoiceINT == 2)
            {
                playerChoice = "Papel";
            } if (playerChoiceINT == 3)
            {
                playerChoice = "Tesoura";
            }
            return playerChoice;
        }
        private static void ShowOptions()
        {
            System.Console.WriteLine("=========================");
            System.Console.WriteLine("     (1) para PEDRA");
            System.Console.WriteLine("     (2) para PAPEL");
            System.Console.WriteLine("    (3) para TESOURA");
            System.Console.WriteLine("=========================");
        }
        private static void PlayerLose()
        {
            System.Console.WriteLine("Você perdeu para a máquina!");
            System.Console.WriteLine("Mais sorte da próxima vez :D");
            System.Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        private static void PlayerWin()
        {
            System.Console.WriteLine("Você venceu!!");
            System.Console.WriteLine("Agora a máquina está enfurecida.");
            System.Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
