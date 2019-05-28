using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSnakeGame
{
    public partial class Form1 : Form
    {
        int currentLeft = 0;

        int currentTop = 0;

        public Form1()
        {
            InitializeComponent();

            btnSnake.Left = currentLeft;

            btnSnake.Top = currentTop;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currentTop<0)
            {
                currentTop = this.Height;
            }

            currentTop -= 20;

            btnSnake.Top = currentTop;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (currentTop>this.Height)
            {
                currentTop = 0;
            }

            currentTop += 20;

            btnSnake.Top = currentTop;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currentLeft<0)
            {
                currentLeft = this.Width;
            }

            currentLeft -= 20;

            btnSnake.Left = currentLeft;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (currentLeft>this.Width)
            {
                currentLeft = 0;
            }

            currentLeft += 20;

            btnSnake.Left = currentLeft;
        }

        private void btnSnake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                if (currentTop > this.Height)
                {
                    currentTop = 0;
                }

                currentTop += 20;

                btnSnake.Top = currentTop;
            }
        }
    }
}
