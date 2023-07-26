using DungeonApp_ClassLibrary;
using DungeonApp_Interfaces;

namespace DungeonApp_MethodLibrary
{
    public static class Displays
    {
        public static void printDisplay(string display)
        {
            foreach (char c in display)
            {
                if(c != ' ') 
                { Thread.Sleep(60); }
                Console.Write(c);
            }
        }
        public static void LoadScreen()
        {
            string displayString1 = "WELCOME TO MY DUNGEON APP!";
            string displayString2 = "Created By: Gene Cathcart";
            string displayString3 = "Curtosy of Centriq Training";
            string display =
($@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}


");

            printDisplay(display);
        }

        public static void StartScreen()
        {
            string line1 = "Battle Tower";
            string line2 = "Make a Selection: ";
            string line3 = "1) Start";
            string line4 = "2) Exit";
            string display = @$"


{line1.PadLeft((Console.WindowWidth / 2) + (line1.Length / 2))}





{line2.PadLeft((Console.WindowWidth / 2) + (line2.Length / 2))}

{line3.PadLeft((Console.WindowWidth / 2) + (line3.Length / 2))}

{line4.PadLeft((Console.WindowWidth / 2) + (line4.Length / 2))}
";

            printDisplay(display);
        }

        public static void RaceSelection(string name)
        {
            string displayString1 = "Please Choose a Race:";
            string displayString2 = "1) Human";
            string displayString3 = "2) Elf";
            string displayString4 = "3) Dwarf";
            string displayString5 = "4) Halfling";
            string displayString6 = "5) Teifling";
            string display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}


{displayString4.PadLeft((Console.WindowWidth / 2) + (displayString4.Length / 2))}


{displayString5.PadLeft((Console.WindowWidth / 2) + (displayString5.Length / 2))}


{displayString6.PadLeft((Console.WindowWidth / 2) + (displayString6.Length / 2))}

";
            printDisplay(display);
        }

        public static void RequestName()
        {
            string displayString1 = "Please Enter Your Name:";
            string display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}
";

            printDisplay(display);
        }

        public static void SelectWeapon(string name)
        {
            string displayString0 = $"Please select your starting Weapon";
            string displayString1 = "This will determine your attack speed and damage:";
            string displayString2 = "1) Dagger";
            string displayString3 = "2) Sword";
            string displayString4 = "3) Axe";
            string displayString5 = "4) Club";

            string display = $@"


{displayString0.PadLeft((Console.WindowWidth / 2) + (displayString0.Length / 2))}


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}


{displayString4.PadLeft((Console.WindowWidth / 2) + (displayString4.Length / 2))}


{displayString5.PadLeft((Console.WindowWidth / 2) + (displayString5.Length / 2))}
";
            printDisplay(display);
        }

        public static void Welcome(Player player)
        {
            string displayString0 = $"Hello {player.Name}, Welcome To the Battle Tower";
            string displayString1 = "This tower is a never ending challenge with each floor holding new obsticales";

            string display = $@"

{displayString0.PadLeft((Console.WindowWidth / 2) + (displayString0.Length / 2))}


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}
";

            printDisplay(display);

        }

        public static void PrintFloor(Player player)
        {
            if (player.IsSafe)
            {
                string displayString1 = player.currentFloor.Description1;
                string displayString2 = player.currentFloor.Description2;
                string displayString3 = "What would you like to do?";
                string displayString4 = "1) Climb to the next floor";
                //string displayString5 = "2) Check stats and inventory";
                string displayString6 = "2) Shop for items";
                string displayString7 = "3) Heal up";
                string displayString8 = "4) Chicken out and leave";

                string display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}
{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}


{displayString4.PadLeft((Console.WindowWidth / 2) + (displayString4.Length / 2))}


{displayString6.PadLeft((Console.WindowWidth / 2) + (displayString6.Length / 2))}


{displayString7.PadLeft((Console.WindowWidth / 2) + (displayString7.Length / 2))}


{displayString8.PadLeft((Console.WindowWidth / 2) + (displayString8.Length / 2))}


";

                printDisplay(display);
            }
            else if (player.InCombat)
            {
                string displayString1 = $"{player.currentFloor.Description1}";
                string displayString2 = $"{player.currentFloor.Description2}";
                string displayString3 = $"In the center of the room stands a {player.currentFloor.Enemy.Name}";
                string display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}
";
                printDisplay(display);
                Thread.Sleep(2000);
            }
            else
            {
                string displayString1 = $"Floor {player.currentFloor.Number}: This floor has been cleared of monsters!";
                string displayString2 = "What would you like to do now?";
                string displayString3 = "1) Climb to the next floor";
                string displayString4 = "2) Retreat to last Safe Floor";
                string displayString5 = "3) Chicken out and quit";

                string display = $@"

{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}


{displayString4.PadLeft((Console.WindowWidth / 2) + (displayString4.Length / 2))}


{displayString5.PadLeft((Console.WindowWidth / 2) + (displayString5.Length / 2))}
";

                printDisplay(display);
            }
        }


        public static void HealInfo(Player player)
        {
            string displayString1 = $"This will heal you to full life for {player.currentFloor.Number} gold";
            string displayString2 = "Would you like to Heal?";
            string displayString3 = "Press Y to heal or any other key to return";
            string display = ($@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}




");
            Displays.printDisplay(display);
        }

        public static void Heal(Player player)
        {
            string displayString1, display;
            if (player.Money >= player.currentFloor.Number)
            {
                player.Health = player.MaxHealth;
                displayString1 = "You are now full life";
                display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}
";
                Console.ForegroundColor = ConsoleColor.Green;
                Displays.printDisplay(display);
                Console.ResetColor();
                Thread.Sleep(1000);
            }
            else
            {
                displayString1 = $"You Cannot Afford This";
                Console.ForegroundColor = ConsoleColor.Red;
                display = ($@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}
");
                Displays.printDisplay(display);
                Console.ResetColor();
                Thread.Sleep(1000);
            }
        }

        public static void Retreat(Player player)
        {
            string displayString1 = $"This will take you all the way back to Floor {player.currentFloor.LastSafeFloor}.";
            string displayString2 = "Press Y to Retreat or any key to stay on this floor.";
            string display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


";
            printDisplay(display);
        }

        public static void MonsterRoom(Player player, Enemy enemy, bool playerTurn)
        {

            string displayString1 = $"{enemy.Name}: {enemy.Health}/{enemy.MaxHealth}";
            string displayString2 = $"{CombatManager.combatStatus}";
            string displayString3 = $"{player.Name}: {player.Health}/{player.MaxHealth}";
            string displayString4 = "What would you like to do?";
            string displayString5 = "1) Attack";
            string displayString6 = "2) Run to a safe floor";
            string displayString7 = "3) Exit the game";
            string display = $@"



{displayString1.PadLeft((Console.WindowWidth) - (displayString1.Length / 2))}

{displayString3.PadLeft(15)}";
            Console.WriteLine(display);
            display = $@"

{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}";
            printDisplay(display);

            if (playerTurn)
            {
                display = $@"



{displayString4.PadLeft((Console.WindowWidth / 2) + (displayString4.Length / 2))}


{displayString5.PadLeft((Console.WindowWidth / 2) + (displayString5.Length / 2))}


{displayString6.PadLeft((Console.WindowWidth / 2) + (displayString6.Length / 2))}


{displayString7.PadLeft((Console.WindowWidth / 2) + (displayString7.Length / 2))}
";
                Console.WriteLine(display);
            }
        }

        public static void CombatSuccess(Player player, Enemy enemy)
        {
            string displayString1 = $"You have killed the {enemy.Name}!";
            string displayString2 = $"You have gained {enemy.Reward_XP} experience points!";
            string displayString3 = $"You found {enemy.Reward_Money} gold on the corpse";
            string display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}

";
            printDisplay(display);
        }

        public static void CombatFail(Player player, Enemy enemy)
        {
            string displayString1 = $"You were killed on {player.currentFloor}!";
            string displayString2 = $"You were slain by a {enemy.Name}";
            string displayString3 = $"Better Luck Next Time!";
            string display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}

";
            printDisplay(display);
        }
        public static void Shop(Player player, Weapon inventory)
        {
            string displayString1 = $"Welcome to the shop!";
            string displayString2 = $"This shop is selling a: ";
            string displayString3 = $"{inventory}";
            string displayString4 = "Press Y to purchase it or any other key to exit";
            string display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}


{displayString2.PadLeft((Console.WindowWidth / 2) + (displayString2.Length / 2))}


{displayString3.PadLeft((Console.WindowWidth / 2) + (displayString3.Length / 2))}


{displayString4.PadLeft((Console.WindowWidth / 2) + (displayString4.Length / 2))}
";
            printDisplay(display);
            char userInput = Console.ReadKey().KeyChar;
            if(userInput == 'y' || userInput == 'Y')
            {
                if(player.Money >= inventory.Price)
                {
                    player.Money -= inventory.Price;
                    player.MainWeapon = inventory;
                    Console.ForegroundColor = ConsoleColor.Green;
                    displayString1 = $"You have succesfully purchased the {inventory.Name}";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    displayString1 = $"You cannot affor the {inventory.Name}";
                }
                Console.Clear();
                display = $@"


{displayString1.PadLeft((Console.WindowWidth / 2) + (displayString1.Length / 2))}
";
                printDisplay(display);
                Thread.Sleep(1000);
                Console.ResetColor();
            }
        }
    }


}