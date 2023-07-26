using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonApp_ClassLibrary;

namespace DungeonApp_Main
{
    internal class test
    {
        static void Main(string[] args)
        {
            Enemy e = Enemy.RandomEnemy();

            Console.WriteLine(e.Health);
        }
    }
}
