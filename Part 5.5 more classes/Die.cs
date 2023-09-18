using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5._5_more_classes
{
    public class Die
    {
        private int _roll;
        private Random _generator;
        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }

        public int Roll
        {
            get { return _roll; }
        }
        public override string ToString()
        {
            return _roll + "";
        }
        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;
        }
        public void DrawDie()
        {
            if (_roll == 1)
            {
                Console.WriteLine("________");
                Console.WriteLine("|\\      \\");
                Console.WriteLine("| \\______\\");
                Console.WriteLine("| |       |");
                Console.WriteLine("| |   *   |");
                Console.WriteLine("\\ |       |");
                Console.WriteLine(" \\|_______|");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("________");
                Console.WriteLine("|\\      \\");
                Console.WriteLine("| \\______\\");
                Console.WriteLine("| | *     |");
                Console.WriteLine("| |       |");
                Console.WriteLine("\\ |     * |");
                Console.WriteLine(" \\|_______|");
            }
            else if (_roll == 3)
            {
                Console.WriteLine("________");
                Console.WriteLine("|\\      \\");
                Console.WriteLine("| \\______\\");
                Console.WriteLine("| | *     |");
                Console.WriteLine("| |   *   |");
                Console.WriteLine("\\ |     * |");
                Console.WriteLine(" \\|_______|");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("________");
                Console.WriteLine("|\\      \\");
                Console.WriteLine("| \\______\\");
                Console.WriteLine("| | *   * |");
                Console.WriteLine("| |       |");
                Console.WriteLine("\\ | *   * |");
                Console.WriteLine(" \\|_______|");
            }
            else if (_roll == 5)
            {
                Console.WriteLine(" ________");
                Console.WriteLine("|\\      \\");
                Console.WriteLine("| \\______\\");
                Console.WriteLine("| | *   * |");
                Console.WriteLine("| |   *   |");
                Console.WriteLine("\\ | *   * |");
                Console.WriteLine(" \\|_______|");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("________");
                Console.WriteLine("|\\      \\");
                Console.WriteLine("| \\______\\");
                Console.WriteLine("| | *   * |");
                Console.WriteLine("| | *   * |");
                Console.WriteLine("\\ | *   * |");
                Console.WriteLine(" \\|_______|");
            }
            else
            {
                Console.WriteLine("________");
                Console.WriteLine("|\\      \\");
                Console.WriteLine("| \\______\\");
                Console.WriteLine("| |       |");
                Console.WriteLine("| |   ?   |");
                Console.WriteLine("\\ |       |");
                Console.WriteLine(" \\|_______|");
            }
        }
    }
}
