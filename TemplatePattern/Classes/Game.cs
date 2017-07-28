using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Classes
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        // Template method
        public void Play()
        {
            // Initialize the game
            Initialize();

            // Start game
            StartPlay();

            // End game
            EndPlay();
        }
    }
}
