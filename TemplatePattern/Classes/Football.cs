using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Classes
{
    public class Football : Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Football game initialized. Start playing");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Football game started ! Enjoy the game");
        }

        public override void EndPlay()
        {
            Console.WriteLine("Football game finished. Thanks for playing");
        }
    }
}
