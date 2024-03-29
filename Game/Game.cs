﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
   public class Game
    {
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70), boundaries);
        }

       public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            if (Enemies !=null)
            {
                foreach (Enemy enemy in Enemies)
                    enemy.Move(random);
            }
            
        }

       public void Equip(string weaponName)
       {
           player.Equip(weaponName);
       }
        
       public bool CheckPlayerInventory(string weaponName)
       {
           return player.Weapons.Contains(weaponName);
       }

       public void HitPlayer(int maxDamage, Random random)
       {
           player.Hit(maxDamage, random);
       }

       public void IncreasePlayerHealth(int health, Random random)
       {
           player.IncreasePlayerHealth(health, random);
       }

       private Point GetRandomLocation ( Random random)
       {
           return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
               boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
       }

       public void NewLevel(Random random)
       {
           level++;
           switch (level)
           {
               case 1:
                   Enemies = new List<Enemy>();
                   Enemies.Add(new Bat(this, GetRandomLocation(random), boundaries));
                   WeaponInRoom = new Sword(this, GetRandomLocation(random));
                   break;

               case 2:
                   Enemies.Add(new Ghost(this, GetRandomLocation(random), boundaries));
                   break;

               case 3:
                   Enemies.Add(new Ghoul(this, GetRandomLocation(random), boundaries));

                   break;
               case 4:
                   Enemies.Add(new Bat(this, GetRandomLocation(random), boundaries));
                   Enemies.Add(new Ghost(this, GetRandomLocation(random), boundaries));

                   break;
               case 5:
                   Enemies.Add(new Bat(this, GetRandomLocation(random), boundaries));
                   Enemies.Add(new Ghoul(this, GetRandomLocation(random), boundaries));

                   break;
               case 6:
                   Enemies.Add(new Ghost(this, GetRandomLocation(random), boundaries));
                   Enemies.Add(new Ghoul(this, GetRandomLocation(random), boundaries));

                   break;
               case 7:
                   Enemies.Add(new Bat(this, GetRandomLocation(random), boundaries));
                   Enemies.Add(new Ghost(this, GetRandomLocation(random), boundaries));
                   Enemies.Add(new Ghoul(this, GetRandomLocation(random), boundaries));

                   break;

               default:
                   break;
               
           }
       }



    }
}
