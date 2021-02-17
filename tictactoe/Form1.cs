using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        bool turn = true;

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pic_click(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;

            if (turn)
            {
                b.Image = Properties.Resources.x;
             

            } else
            {
                b.Image = Properties.Resources.o;
            };

            turn = !turn;

        }
    }
}
