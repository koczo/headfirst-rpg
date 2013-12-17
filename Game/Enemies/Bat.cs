using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Game
{
    class Bat:Enemy
    {
        public Bat(Game game, Point location, Rectangle boundaries)
            :base(game,location,boundaries,6)
        {

        }
        public override void Move(Random random)
        {
            if (random.Next(0, 2) > 0) 
            {
                base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else
                base.location = Move(RandomDirection(random), game.Boundaries);

        }
        private Direction RandomDirection(Random random)
        {
            Direction randomDirection = (Direction)random.Next(1, 5);
            if (FindPlayerDirection(game.PlayerLocation) != randomDirection)
            {
                return randomDirection;
            }
            else if ((int)randomDirection > 3)
                return randomDirection - 1;
            else
                return randomDirection + 1;
        }
    }
}
