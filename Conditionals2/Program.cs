using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    internal class Program
    {
        static int health;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals2");
            Console.WriteLine();

            health = 100;
            ShowHUD();
            TakeDamage(50); //range checking
            ShowHUD();
            Heal(25);
            ShowHUD();
            Console.WriteLine();


            Console.ReadKey(true);
        }
        static void Heal (int hp)
        {
            health = health + hp;
            Console.WriteLine("Player has healed by: " + hp + " points...");
        }
        static void TakeDamage(int damage) //damage only works w int
        {
            Console.WriteLine("Player is about to take " + damage + " damage..."); // debug: shows what line is playing
            health = health - damage;

            if (health < 0) //range checking code
            {
                health = 0;
            }
        }

        static void ShowHUD()
        {
            Console.WriteLine("Health: " + health);
            string status;
            status = "";

            if (health >= 75)
            {
                status = "Fine";
            }

            if ((health <= 50) && (health >= 30)) // && and operator
            {
                status = "HURT";
            }

            Console.WriteLine("Health status: " + status);
        }
    }
}
