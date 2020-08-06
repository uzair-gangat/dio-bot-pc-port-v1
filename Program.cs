using System;
using System.Reflection.Metadata;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            enemies();
        }
        public static void enemies()
        {
            Random enemy = new Random();
            string battleaccept;
            int enemyhealth = 0;
            int health = 0;
            Random enemyattack = new Random();


            int enemys = enemy.Next(1, 4);
            switch (enemys)
            {
                case 1:
                    Console.WriteLine("Dio approaches! Do you accept battle? P [yes] O [no]");
                    battleaccept = Console.ReadLine();
                    if (battleaccept == "p")
                    {


                        battle(10, enemyattack.Next(1, 4));
                    }
                    else
                    {

                        Console.WriteLine("Dio stopped time and stopped you from fleeing");
                        battle(10, enemyattack.Next(1, 4));

                    }
                    break;

                case 2:
                    Console.WriteLine("Yoshikage kira is seen in the corner of your eye! Do you accept battle? P [yes] O [no]");
                    battleaccept = Console.ReadLine();
                    if (battleaccept == "p")
                    {

                        battle(9, enemyattack.Next(1, 5));
                    }
                    else
                    {

                        Console.WriteLine(" killer queen has already touched the only door handle and stopped you from fleeing");
                        battle(9, enemyattack.Next(1, 5));

                    }
                    break;
                default:
                    Console.WriteLine("you moved two steps without even remebering it, and Diavolo appears infront of you! Do you accept battle? P [yes] O [no]");
                    battleaccept = Console.ReadLine();
                    if (battleaccept == "p")
                    {

                        battle(15, enemyattack.Next(1, 4));
                    }
                    else
                    {

                        Console.WriteLine(" king crimson skipped time and caught up with you, you cant run!");
                        battle(15, enemyattack.Next(1, 4));

                    }
                    break;


            }
        }
        public static void battle(int health,int reattack ) 
        {
            Random enemyattack = new Random();
            Random jotaroattack = new Random();
            Random defence = new Random();
            int enemyhealth;
            int jotarohealth = 10;
            int meter = 0;
            string attack;


            for (enemyhealth = health; enemyhealth >= 1;)
            {
                Console.WriteLine("jotaro HP: " + jotarohealth + " Enemy HP: " + enemyhealth);
                Console.WriteLine();
                Console.WriteLine("press P to do a basic attack and I to defend");
                int jotaroattacks = jotaroattack.Next(1, 4);
                attack = Console.ReadLine();
                if (attack == "p")
                {
                    enemyhealth = enemyhealth - jotaroattacks;
                    meter++;
                    Console.WriteLine();
                    Console.WriteLine("you attacked and delt " + jotaroattacks + " damage");
                }

                int enemyattacks = reattack;
                if (attack == "i")
                {
                    Console.WriteLine();
                    Console.WriteLine("you defended and took 1 less damage");
                    enemyattacks--;
                }


                while (meter == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("your meter is full, Press O for a stand pummel!");
                    attack = Console.ReadLine();
                    meter++;
                    while (meter == 6)
                    {
                        if (attack == "o")
                        {
                            Console.WriteLine("ORA ORA ORA ORA ORA!");
                            enemyhealth = enemyhealth - 3;
                            meter++;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Enemy attacks!");
                jotarohealth = jotarohealth - enemyattacks;
                Console.WriteLine("Enemy delt " + enemyattacks + " damage");
                Console.WriteLine();
                if (jotarohealth == 0)
                {
                    Console.WriteLine("You lose");
                    enemyhealth = -1;
                }
                if (enemyhealth <= 0)
                {
                    Console.WriteLine("You Win!");

                }
            }
            Console.WriteLine("the battle has ended press any key to exit");
            Console.ReadKey();
        }
        
    }
}
