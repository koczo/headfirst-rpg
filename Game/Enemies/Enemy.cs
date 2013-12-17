using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Game
{
     public abstract class Enemy:Mover
    {
         private int hitPoints;
         private const int NearPlayerDistance = 25;
         public int HitPoints { get { return hitPoints; } }
         public bool Dead 
         {
             get 
             {
                 if (hitPoints <= 0) return true;
                 else return false;
             }

         }

         public Enemy(Game game, Point location, Rectangle boundaries, int hitPoints)
             : base(game, location)
         {
             this.hitPoints = hitPoints;
         }

         public abstract void Move(Random random);

         protected bool NearPlayer()
         {
             return Nearby(game.PlayerLocation, NearPlayerDistance);
         }

         protected Direction FindPlayerDirection(Point playerLocation)
         {
             Direction directionToMove;

             if (playerLocation.X > location.X + 10)
                 directionToMove = Direction.Right;
             else if (playerLocation.X < location.X - 10)
                 directionToMove = Direction.Left;
             else if (playerLocation.Y < location.Y - 10)
                 directionToMove = Direction.Up;
             else
                 directionToMove = Direction.Down;
             return directionToMove;
         }
        
    }
}
