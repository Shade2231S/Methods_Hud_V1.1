using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Hud_V1._1
{
    internal class Program
    {
        static float Health = 100f;
        static float CurrentHealth;
        static float Shield = 50f;
        static float CurrentShield;
        static int Lives = 2;
        static int CurrentLives;
        static int CurrentScore;
        static ConsoleColor Originalcolor;
        static ConsoleColor HUDColor = ConsoleColor.DarkGreen;
        static ConsoleColor DamageColor = ConsoleColor.DarkRed;
        static ConsoleColor TextColor = ConsoleColor.DarkMagenta;
        static ConsoleColor ScoreColor = ConsoleColor.DarkBlue;
        static void Main(string[] args)
        {
            CurrentHealth = Health;
            CurrentShield = Shield;
            CurrentLives = Lives;
            Console.ForegroundColor = TextColor;
            ShowHUD();
            Console.ReadKey(true);
            Console.Clear();
            TakeDamage(50);
            Console.ReadKey(true);
            Console.Clear();
            AddScore(3);
            ShowHUD();
            Console.ForegroundColor = Originalcolor;
        }
        static public void ShowHUD()
        {
            Console.ForegroundColor = HUDColor;
            Console.WriteLine("Health - " + CurrentHealth);
            Console.WriteLine("Shield - " + CurrentShield);
            Console.WriteLine("Lives - " + CurrentLives);
            Console.ForegroundColor = TextColor;
        }
        static public void TakeDamage(float IncomingDamage)
        {
            Console.ForegroundColor = DamageColor;        
            if (CurrentShield > 0)
            {
                CurrentShield -= IncomingDamage;
            }
            else if (Shield < 0) 
            {
                CurrentHealth -= IncomingDamage;
            }
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Player Took Damage!" + IncomingDamage);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!");
            Console.ForegroundColor = TextColor;
        }
        static public void AddScore(int ScoreAdded)
        {
            Console.ForegroundColor = ScoreColor;
            Console.WriteLine("===================");
            Console.WriteLine("Your Score Was Increased! - " + CurrentScore);
            Console.WriteLine("===================");
            Console.ForegroundColor = TextColor;
        }
    }
}
