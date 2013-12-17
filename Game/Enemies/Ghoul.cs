using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Ghoul:Enemy
    {
        public Ghoul(Game game, Point location, Rectangle boundaries)
            :base(game,location,boundaries,10)
        {

        }

        public override void Move(Random random)
        {
            if (random.Next(0, 3) <=1)
            {
                base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
        }
    }
}
