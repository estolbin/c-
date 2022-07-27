using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catchButton
{

    public partial class Form1 : Form
    {
        private int countGame = 0;
        private int success = 0;
        private const int Games = 10;
        private const int pbHeight = 30;

        public Form1()
        {
            InitializeComponent();



        }

        private void GameLogic(object sender, EventArgs e)
        {
            if (sender.ToString() == "New game")
            {
                countGame = success = 0;
                this.gameProgress.Value = 0;
                this.buttonCatch.Enabled = true;
            }
            else if (sender.ToString() == "Exit")
            {
                this.Close();
            }
        }

        private void Form_OnMouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {e.X}, Y: {e.Y}. Button location: X {this.buttonCatch.Location.X}, Y {this.buttonCatch.Location.Y}";
        }

        private void buttonCatch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gotcha!");
            success++;
        }

        private void buttonCatch_MouseHover(object sender, EventArgs e)
        {
            var rand = new Random();
            var new_X = rand.Next(0, this.Size.Width - (this.buttonCatch.Width * 2));
            var new_Y = rand.Next(0 + pbHeight + this.ms.Size.Height, this.Size.Height - (this.buttonCatch.Height * 2 + this.ms.Size.Height));
            this.buttonCatch.Location = new Point(new_X, new_Y);
            //this.labelInfo.Text = $"Form width {this.Size.Width}, height {this.Size.Height}";

            countGame++;
            this.gameProgress.Value += 10;
            if (countGame == Games)
            {
                MessageBox.Show($"Game over. You catch button {success} times");
                this.buttonCatch.Enabled = false;
            }
        }
    }
}