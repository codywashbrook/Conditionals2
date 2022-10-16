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
        static int shield;
        static int weapons;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals2");
            Console.WriteLine();


            health = 100;
            shield = 100;

            ShowHUD();
            TakeDamage(150); //range checking
            ShowHUD();
            Heal(25);
            ShowHUD();
            ChangeWeapon(1);
            ChangeWeapon(2);
            ChangeWeapon(3);


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
          //shield = shield - damage;
            if (shield >= health)
            {
                shield = shield - damage;

            }
            else
            {
                health = health - damage;
            }
            if (health < 0) //range checking code
            {
                health = 0;
            }
            if (shield < 0)
            {
                shield = 0;
            }
        }

        static void ShowHUD()
        {
            Console.WriteLine("Shield: " + shield);
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

        static void ChangeWeapon(int weaponPickedUp)
        {
            weapons = weapons + weaponPickedUp;
            if (weapons == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Player changed weapon to: Pistol ");
                Console.WriteLine();
            }
            weapons = weapons + weaponPickedUp;
            if (weapons == 2)
            {
                Console.WriteLine("Player changed weapon to: Shotgun ");
                Console.WriteLine();
            }
            weapons = weapons + weaponPickedUp;
            if (weapons == 3)
            {
                Console.WriteLine("Player changed weapon to: AR15 ");
            }
        }
    }
}
