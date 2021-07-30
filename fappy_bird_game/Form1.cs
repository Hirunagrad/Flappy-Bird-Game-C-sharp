using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fappy_bird_game
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 20;
        int gravity = 10;//pixels
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Timerevent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            guna2PictureBox3.Left -= pipeSpeed;
            pipeDown.Left -= pipeSpeed;
           
        }

        private void pipeDown_Click(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {
           
        }


        private void up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)    
            {
                gravity = 10;
            }
        }

        private void down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }
    }
}
