using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Classes
{
    public class Cricket : Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Cricket game initialized. Start playing");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Cricket game started ! Enjoy the game");
        }

        public override void EndPlay()
        {
            Console.WriteLine("Cricket game finished. Thanks for playing");
        }
    }
}
