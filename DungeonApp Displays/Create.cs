using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonApp_ClassLibrary;

namespace DungeonApp_MethodLibrary
{
    public class Create
    {
        public static Player Player()
        {
            bool validInput = false;
            Races race = 0;
            string name = "";
            Weapon weapon = null;

            Displays.RequestName();
            name = Console.ReadLine();
            Console.Clear();

            do
            {
                Displays.RaceSelection(name);
                char userInput = Console.ReadKey().KeyChar;
                Console.Clear();
                if (Int32.TryParse(userInput.ToString(), out int selection))
                {
                    race = (Races)selection;
                    validInput = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input not recognized please try again. . . ");
                    Console.ResetColor();
                }
            } while (!validInput);

            Console.Clear();
            validInput = false;
            do
            {
                Displays.SelectWeapon(name);
                char userInput = Console.ReadKey().KeyChar;
                Console.Clear();
                if (Int32.TryParse(userInput.ToString(), out int selection) && (selection >0 && selection <5))
                {
                    weapon = Weapon.WeaponList(selection);
                    validInput = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input not recognized please try again. . . ");
                    Console.ResetColor();
                }
            } while (!validInput);

            return new Player(name, (Races)race, weapon);
        }

    }
}
