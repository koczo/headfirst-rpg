using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
       
        public Form1()
        {
            InitializeComponent();
            game = new Game(new Rectangle(78, 57,420,155));
            game.NewLevel(random);
            UpdateCharacters();

        }
        public void UpdateCharacters()
        {
            tableLayoutPanelPlayer.Location = game.PlayerLocation;
            tableLayoutPanelBat.Location = game.Enemies[0].Location;
            //tableLayoutPanelGhost.Location = game.Enemies[1].Location;
            //tableLayoutPanelGhoul.Location = game.Enemies[2].Location;
            pictureBoxSword.Location = game.WeaponInRoom.Location;
            tableLayoutPanelPlayer.Invalidate();
            Thread.Sleep(7);
            Application.DoEvents();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //return Direction.Up;
                game.Move(Direction.Up, random);
                UpdateCharacters();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                //return Direction.Down;
                game.Move(Direction.Down, random);
                UpdateCharacters();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                //return Direction.Left;
                game.Move(Direction.Left, random);
                UpdateCharacters();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                //return Direction.Right;
                game.Move(Direction.Right, random);
                UpdateCharacters();
                e.Handled = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

       
}
