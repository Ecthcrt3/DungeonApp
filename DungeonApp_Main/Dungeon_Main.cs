using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonApp_MethodLibrary;
using DungeonApp_ClassLibrary;

namespace DungeonApp_Main
{
    public class Dungeon_Main
    {
        static void Main(string[] args)
        {
            Console.Title = "Dungeon App";
            bool isRunning = true;
            char userInput;

            #region Load Screen

            Displays.LoadScreen();
            Thread.Sleep(3000);
            Console.Clear();
            #endregion

            do
            {
                Displays.StartScreen();
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine(userInput);
                Console.Clear();
                switch (userInput)
                {
                    case '1':
                    case 'S':
                    case 's':
                        Player player = Create.Player();
                        Displays.Welcome(player);
                        Thread.Sleep(2000);
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            Displays.PrintFloor(player);
                            if (player.IsSafe)
                            {
                                Functionality.Shopping(player);
                            }
                            else if (player.InCombat)
                            {
                                Functionality.Combat(player);
                            }
                            else
                            {
                                Functionality.Idle(player);
                            }
                        } while (player.IsAlive && !player.IsExiting);
                        if (player.IsExiting) { isRunning = false; }
                        break;

                    case '2':
                    case 'E':
                    case 'e':
                        isRunning = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input not recognized please try again. . . ");
                        Console.ResetColor();
                        break;
                }
            }while(isRunning);
            Console.WriteLine("Thank you for playing!");
        }
    }
}
