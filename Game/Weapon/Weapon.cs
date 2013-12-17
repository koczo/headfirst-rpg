using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace Game
{
    public abstract class Weapon : Mover
    {

        
        private bool pickUp;

        public bool PickUP
        {
            get { return pickUp; }
        }

        //private Point location;

        //public Point Location
        //{
        //    get { return location; }
        //}
        
        

        public Weapon(Game game, Point location):base(game, location) 
        {
            pickUp = false;
        }

        public abstract string Name { get; }

        public abstract void Atack(Direction direction, Random random);

        protected bool DemageEnemy(Direction direction, int radius, int demage, Random random)
        {
            return false;
        }
    }
}
