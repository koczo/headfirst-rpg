using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Game
{
    class Sword:Weapon
    {

        public Sword(Game game, Point location)
            :base(game,location)
        {

        }

        public override string Name
        {
            get { return "Sword"; }
        }

        public override void Atack(Direction direction, Random random)
        {
          
        }
    }
}
