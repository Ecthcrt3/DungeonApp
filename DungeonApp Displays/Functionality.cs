using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonApp_ClassLibrary;
using DungeonApp_Interfaces;


namespace DungeonApp_MethodLibrary
{
    public static class Functionality
    {
        
        public static void Idle(Player player)
        {
            char userInput = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (userInput)
            {
                case '1':
                    NextFloor(player);
                    break;
                case '2':
                    Displays.Retreat(player);
                    userInput = Console.ReadKey().KeyChar;
                    switch (userInput)
                    {
                        case 'Y':
                        case 'y':
                            player.currentFloor.Number = player.currentFloor.LastSafeFloor;
                            player.currentFloor.Description1 = $"Floor {player.currentFloor.Number}: This is a safe floor to purchase items and heal";
                            player.currentFloor.Description2 = " ";
                            player.IsSafe = true;
                            break;
                    }
                    break;
                case '3':
                    player.IsExiting = true;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input not recognized please try again. . . ");
                    Console.ResetColor();
                    break;
            }
        }
        public static void Shopping(Player player) 
        {
            char userInput = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (userInput)
            {
                case '1':
                    NextFloor(player);
                    break;
                case '2':
                    //shop
                    break;
                case '3':
                    Displays.HealInfo(player);
                    userInput = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (userInput)
                    {
                        case 'y':
                        case 'Y':
                            Displays.Heal(player);
                            break;
                    }
                    break;
                case '4':
                    player.IsExiting = true;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input not recognized please try again. . . ");
                    Console.ResetColor();
                    break;
            }
        }

        public static void Combat(Player player)
        {
            Enemy enemy = player.currentFloor.Enemy;
            do
            {
                bool validInput = false;
                char userInput = Console.ReadKey().KeyChar;
                Console.Clear();
                do
                {
                    switch (userInput)
                    {
                        case '1':
                            if (CombatManager.CalculateHit(player, enemy))
                            {
                                enemy.TakeDamage(player.GetDamage());
                            }
                            break;
                        case '2':
                            if(CombatManager.CalculateRun(player, enemy))
                            {
                                player.currentFloor.Number = player.currentFloor.LastSafeFloor;
                                player.currentFloor.Description1 = $"Floor {player.currentFloor.Number}: This is a safe floor to purchase items and heal";
                                player.currentFloor.Description2 = " ";
                                player.IsSafe = true;
                                player.InCombat = false;
                            }
                            break;
                        case '3':
                            player.IsExiting = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Input not recognized please try again. . . ");
                            Console.ResetColor();
                            break;
                    }
                } while (!validInput);
            } while (player.IsAlive && enemy.IsAlive);
            if (!enemy.IsAlive)
            {
                player.Money += 1;
                player.InCombat = false;
            }
        }

        public static void NextFloor(Player player)
        {
            player.currentFloor.Number++;
            if (player.currentFloor.Number % 5 == 0)
            {
                player.currentFloor.Description1 = $"Floor {player.currentFloor.Number}: This is a safe floor to purchase items and heal";
                player.currentFloor.Description2 = " ";
                player.currentFloor.LastSafeFloor = player.currentFloor.Number;
                player.currentFloor.Enemy = null;
            }
            else
            {
                Random rand = new Random();
                string[] colors = { "red", "green", "blue", "orange", "yellow", "purple" };
                string[] decorations = { "bones", "blood", "broken weapons", "corpses", "bugs" };
                player.currentFloor.Description1 = $"Floor {player.currentFloor.Number}: This is a {rand.Next(10, 50)}ft.x{rand.Next(10, 50)}ft. room with {rand.Next(10, 20)}ft. tall ceilings";
                player.currentFloor.Description2 = $" The walls are painted {colors[rand.Next(0, 6)]} and there are {decorations[rand.Next(0, 5)]} all over the floor";
                player.IsSafe = false;
                player.currentFloor.Enemy = Enemy.RandomEnemy();
                player.InCombat = true;
            }
        }

    }
}
