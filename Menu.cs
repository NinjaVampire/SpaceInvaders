using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceAIDS
{
    public partial class Menu : Form
    {
        System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Properties.Resources.mainMusic);
        public Menu()
        {
            InitializeComponent();
            sound.PlayLooping();
        }
        
        private void bttn_Play_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }

        private void bttn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
