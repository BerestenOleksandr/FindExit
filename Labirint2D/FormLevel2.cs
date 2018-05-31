using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point;
            point = pictureBox1.Location = new Point(540, 25);
            label_key.Visible = true;
            label_key.Location = new Point(55, 420);
            label_key1.Visible = true;
            label_key1.Location = new Point(690, 25);
            label_door.Visible = true;
            label_door.Location = new Point(830, 170);
            label_door1.Visible = true;
            label_door1.Location = new Point(15, 350);
            Sound.play_welcome();
        }

        private void finish_game()
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show(
                "Ви програли, ще раз спробуєте?",
                "Повідомлення",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                start_game();
            else
                DialogResult = DialogResult.Abort;
        } 

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void FormLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: pictureBox1.Left -= 10; break;
                case Keys.Right: pictureBox1.Left += 10; break;
                case Keys.Up: pictureBox1.Top -= 10; break;
                case Keys.Down: pictureBox1.Top += 10; break;
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label5.Location.X && pictureBox1.Location.Y <= (label5.Location.Y + label5.Height)
                && pictureBox1.Location.X <= (label5.Location.X + label5.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label5.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label1.Location.X && pictureBox1.Location.Y <= (label1.Location.Y + label1.Height)
                && pictureBox1.Location.X <= (label1.Location.X + label1.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label1.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label2.Location.X && pictureBox1.Location.Y <= (label2.Location.Y + label2.Height)
                && pictureBox1.Location.X <= (label2.Location.X + label2.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label2.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label2.Location.X && pictureBox1.Location.Y <= (label2.Location.Y + label2.Height)
                && pictureBox1.Location.X <= (label2.Location.X + label2.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label2.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label3.Location.X && pictureBox1.Location.Y <= (label3.Location.Y + label3.Height)
                && pictureBox1.Location.X <= (label3.Location.X + label3.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label3.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label4.Location.X && pictureBox1.Location.Y <= (label4.Location.Y + label4.Height)
                && pictureBox1.Location.X <= (label4.Location.X + label4.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label4.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label6.Location.X && pictureBox1.Location.Y <= (label6.Location.Y + label6.Height)
               && pictureBox1.Location.X <= (label6.Location.X + label6.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label6.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label7.Location.X && pictureBox1.Location.Y <= (label7.Location.Y + label7.Height)
               && pictureBox1.Location.X <= (label7.Location.X + label7.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label7.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label8.Location.X && pictureBox1.Location.Y <= (label8.Location.Y + label8.Height)
               && pictureBox1.Location.X <= (label8.Location.X + label8.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label8.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label9.Location.X && pictureBox1.Location.Y <= (label9.Location.Y + label9.Height)
               && pictureBox1.Location.X <= (label9.Location.X + label9.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label9.Location.Y)
                finish_game();

            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_key.Location.X && pictureBox1.Location.Y <= (label_key.Location.Y + label_key.Height)
                && pictureBox1.Location.X <= (label_key.Location.X + label_key.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_key.Location.Y)
            {
                Sound.play_key();
                label_key.Visible = false;
                label_key.Location = new Point(6000, 6000);
                label_door.Visible = false;
                label_door.Location = new Point(10000, 10000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_key1.Location.X && pictureBox1.Location.Y <= (label_key1.Location.Y + label_key1.Height)
                && pictureBox1.Location.X <= (label_key1.Location.X + label_key1.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_key1.Location.Y)
            {
                Sound.play_key();
                label_key1.Visible = false;
                label_key1.Location = new Point(5000, 5000);
                label_door1.Visible = false;
                label_door1.Location = new Point(11000, 11000);
            }

            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_door.Location.X && pictureBox1.Location.Y <= (label_door.Location.Y + label_door.Height)
                && pictureBox1.Location.X <= (label_door.Location.X + label_door.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_door.Location.Y)
                finish_game();

            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_door1.Location.X && pictureBox1.Location.Y <= (label_door1.Location.Y + label_door1.Height)
            && pictureBox1.Location.X <= (label_door1.Location.X + label_door1.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_door1.Location.Y)
                finish_game();

            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_exit.Location.X && pictureBox1.Location.Y <= (label_exit.Location.Y + label_exit.Height)
                && pictureBox1.Location.X <= (label_exit.Location.X + label_exit.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_exit.Location.Y)
                DialogResult = DialogResult.OK;
        }
    }
}
