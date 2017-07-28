using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePattern.Classes;

namespace TemplatePattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();

            Console.WriteLine("\n");

            game = new Football();
            game.Play();

            Console.ReadLine();
        }
    }
}
