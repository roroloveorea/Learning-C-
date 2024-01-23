using System;
using TurnBased;

Unit player = new Unit(100, 20, 12, " player");
Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
Random random = new Random();
int rand;
while (player.Hp > 0 && enemy.Hp > 0)
{
    Console.WriteLine($"{player.UnitName} HP = {player.Hp} , {enemy.UnitName} HP = {enemy.Hp}");
    Console.WriteLine("Player turn! what will you do");
    string choice = Console.ReadLine();

    if (choice == "a")
    {
        player.Attack(enemy);
    }
    else player.Heal();
    Console.WriteLine("Enemy turn!");
    rand = random.Next(0, 2);
    if (rand == 0)
    {
        enemy.Attack(player);
    }
    else enemy.Heal();

}

if (player.Hp > 0) Console.WriteLine($"{player.UnitName} Won!");
else Console.WriteLine($"{enemy.UnitName} Won!");

