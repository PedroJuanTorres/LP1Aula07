using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEnemies;
            Enemy[] enemies;
            

            Console.Write("Enemy count? ");
            numEnemies = int.Parse(Console.ReadLine());

            enemies = new Enemy[numEnemies];

            for(int i = 0; i < numEnemies; i++)
            {
                string name;

                Console.Write($"Name of enemy {i}: ");
                name = Console.ReadLine();
                enemies[i] = new Enemy(name);
            }

            foreach (Enemy e in enemies)
            {
                Console.WriteLine(e.GetName());
            }

            
        }
    }
}
