using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5._5_more_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Console.WriteLine($"You rolled a {die1}.");
            die1.DrawDie();
            die1.RollDie();
            Console.WriteLine($"You rolled a {die1}.");
            die1.DrawDie();
            Console.ReadLine();
        }
    }
}
