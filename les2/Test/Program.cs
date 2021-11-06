using System;

namespace les2
{



   
    
    class Program
    {
        static void Main(string[] args)
        {
            Enemy healthy = new Enemy();
            healthy.Attack(23);
        }


        public class Enemy
        {
            int Health = 25;

           
            public void Attack(int damage) {
                Console.WriteLine("The Enemy's health is " + damage);
                Console.WriteLine("Would you like to attack? press A");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.KeyChar == 'a')
                {
                    Console.Clear();
                    Console.WriteLine("You Attacked and did "+ damage +" damage");
                    Health -= damage;
                    Console.WriteLine("The enemy's health is " + Health);
                }


            }
            
            
                

           

        }

       
    }
}
