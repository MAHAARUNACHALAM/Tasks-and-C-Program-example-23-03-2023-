//Common Programs

//GAME HERO AND VILLIAN ,HERO SHOOT ONE REDUCE BUT VILLION SHOOT THREE REDUCE


using System.Runtime.Serialization.Formatters;

namespace console1
{
    class ShootGame
    {

        static void Main(String[] args)
        {
            int heroHealth = 100;
            int villianHealth = 100;
            int state = 1;
            int a;
            while (state != 0)
            {
                if (heroHealth > 0 && villianHealth > 0)
                {
                    Console.WriteLine(" Type Villan(1) or Hero(2) or 0 to end");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 2)
                    {
                        heroHealth--;
                        Console.WriteLine("Hero bullet number" + (100 - heroHealth));

                    }
                    else if (a == 1)
                    {

                        villianHealth -= 3;
                        Console.WriteLine("Villian bullet number" + (100 - villianHealth) + " " + (100 - villianHealth - 1) + " " + (100 - villianHealth - 2));
                    }
                    else
                    {
                        state = 0;
                    }
                }
                else
                {
                    state = 0;
                    if (heroHealth > 0)
                    {
                        Console.WriteLine("Villian out of bullet Hero Wins!!!!!");
                    }
                    else
                    {
                        Console.WriteLine("Hero Out of Bullet Villian Wins-----");
                    }
                }

            }
            Console.WriteLine("Hero Shot" + (100 - heroHealth));
            Console.WriteLine("Villian Shot" + (100 - villianHealth));
        }

    }
}