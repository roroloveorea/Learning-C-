using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TurnBased
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp= 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;
            Random random = new Random();
            Console.WriteLine("Enter player name");
            string Player = Console.ReadLine();

            while (playerHp > 0 && enemyHp> 0)
            {
                //player turn
                Console.WriteLine($"-- {Player} turn --");
                Console.WriteLine($"{Player} Hp - {playerHp} . Enemy Hp - {enemyHp} ");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine($"{Player} attack enemy and deals  {playerAttack} damage!");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine($"{Player} restores {healAmount} health points!");
                }

                if (enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy turn --");
                    int enemyChoice = random.Next(0, 2);
                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine($"Enemy attacks and deals {enemyAttack} damage!");

                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine($"Enemy restores {healAmount} health points!");
                    }

                }


            }

            if(playerHp > 0)
            {
                Console.WriteLine("Congrats, you WON!");
            }
            else
            {
                Console.WriteLine("Boo, you LOST!");
            }

        }
    }
}
