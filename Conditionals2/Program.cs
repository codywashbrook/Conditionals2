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
        static int lives;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals2");
            Console.WriteLine();


            health = 100;
            shield = 100;
            lives = 003;

            ShowHUD();
            TakeDamage(200); //range checking
            ShowHUD();
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

            if (hp > 100)
            {
                health = 100;
                Console.WriteLine("[Player is at Max HP and Cannot Heal Anymore]");
            }
            if (hp < 0)
            {
                health = 100;
                Console.WriteLine("[ERROR: Negative Value]");
                Console.WriteLine();

            }
        }

        static void RegenerateShield(int regen)
        {
            shield = shield + regen;
            Console.WriteLine("Player has picked up a shield: " + regen + " points regenerated...");
            if (shield > 100)
            {
                shield = 100;
                Console.WriteLine("[Player is at Max Shield and Cannot Regenerate Anymore]");
            }
            else
            {
                shield = 0;
                Console.WriteLine("[ERROR: Negative Value]");
                Console.WriteLine();
            }
        }
        static void TakeDamage(int damage) //damage only works w int
        {
            Console.WriteLine("Player is about to take " + damage + " damage..."); // debug: shows what line is playing
            //shield = shield - damage;
            if (shield == 100)
            {
                health = (health + shield) - damage;
                shield = shield - damage;
            }
            else if (shield == 0)
            {
                health = health - damage;
            }

            if (shield < 0)
            {
                shield = 0;
            }

        }

        static void ShowHUD()
        {

            string status;
            status = "";
            Console.WriteLine();
            
            if (shield >= 75)
            {
                status = "Great";
            }

            if ((shield <= 50) && (shield >= 30))
            {
                status = "Good";
            }

            if (health >= 75)
            {
                status = "Fine";
            }

            if ((health <= 50) && (health >= 30)) // && and operator
            {
                status = "HURT";
            }

            Console.WriteLine("Health status: " + status);

            if (health == 0)
            {
                status = "Dead";
                lives = lives - 1;
            }

            Console.WriteLine("Shield: " + shield);

            Console.WriteLine("Lives: 00" + lives);

            Console.WriteLine("Health: " + health);
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
