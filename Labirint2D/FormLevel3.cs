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
    public partial class FormLevel3 : Form
    {
        int left_boxes;
        public FormLevel3()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point;
            point = pictureBox1.Location = new Point(35, 25);
            left_boxes = 6;
            label_box1.Visible = true;
            label_box1.Location = new Point(400, 40);
            label_box2.Visible = true;
            label_box2.Location = new Point(260, 270);
            label_box3.Visible = true;
            label_box3.Location = new Point(75, 125);
            label_box4.Visible = true;
            label_box4.Location = new Point(810, 430);
            label_box5.Visible = true;
            label_box5.Location = new Point(940, 430);
            label_box6.Visible = true;
            label_box6.Location = new Point(910, 90);
            label_key.Visible = true;
            label_key.Location = new Point(790, 360);
            label_key1.Visible = true;
            label_key1.Location = new Point(265, 135);
            label_key2.Visible = true;
            label_key2.Location = new Point(660, 75);
            label_door.Visible = true;
            label_door.Location = new Point(850, 125);
            label_door1.Visible = true;
            label_door1.Location = new Point(715, 275);
            label_door2.Visible = true;
            label_door2.Location = new Point(140, 380);
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

        private void FormLevel3_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void FormLevel3_KeyDown(object sender, KeyEventArgs e)
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
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label10.Location.X && pictureBox1.Location.Y <= (label10.Location.Y + label10.Height)
               && pictureBox1.Location.X <= (label10.Location.X + label10.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label10.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label8.Location.X && pictureBox1.Location.Y <= (label8.Location.Y + label8.Height)
               && pictureBox1.Location.X <= (label8.Location.X + label8.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label8.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label9.Location.X && pictureBox1.Location.Y <= (label9.Location.Y + label9.Height)
               && pictureBox1.Location.X <= (label9.Location.X + label9.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label9.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label11.Location.X && pictureBox1.Location.Y <= (label11.Location.Y + label11.Height)
               && pictureBox1.Location.X <= (label11.Location.X + label11.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label11.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label13.Location.X && pictureBox1.Location.Y <= (label13.Location.Y + label13.Height)
               && pictureBox1.Location.X <= (label13.Location.X + label13.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label13.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label15.Location.X && pictureBox1.Location.Y <= (label15.Location.Y + label15.Height)
               && pictureBox1.Location.X <= (label15.Location.X + label15.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label15.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label16.Location.X && pictureBox1.Location.Y <= (label16.Location.Y + label16.Height)
               && pictureBox1.Location.X <= (label16.Location.X + label16.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label16.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label27.Location.X && pictureBox1.Location.Y <= (label27.Location.Y + label27.Height)
               && pictureBox1.Location.X <= (label27.Location.X + label27.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label27.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_box1.Location.X && pictureBox1.Location.Y <= (label_box1.Location.Y + label_box1.Height)
       && pictureBox1.Location.X <= (label_box1.Location.X + label_box1.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_box1.Location.Y)
            {
                Sound.play_key();
                label_box1.Visible = false;
                left_boxes--;
                label_box1.Location = new Point(11000, 11000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_box2.Location.X && pictureBox1.Location.Y <= (label_box2.Location.Y + label_box2.Height)
                && pictureBox1.Location.X <= (label_box2.Location.X + label_box2.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_box2.Location.Y)
            {
                Sound.play_key();
                label_box2.Visible = false;
                left_boxes--;
                label_box2.Location = new Point(11000, 11000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_box3.Location.X && pictureBox1.Location.Y <= (label_box3.Location.Y + label_box3.Height)
                && pictureBox1.Location.X <= (label_box3.Location.X + label_box3.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_box3.Location.Y)
            {
                Sound.play_key();
                label_box3.Visible = false;
                left_boxes--;
                label_box3.Location = new Point(11000, 11000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_box4.Location.X && pictureBox1.Location.Y <= (label_box4.Location.Y + label_box4.Height)
                && pictureBox1.Location.X <= (label_box4.Location.X + label_box4.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_box4.Location.Y)
            {
                Sound.play_key();
                label_box4.Visible = false;
                left_boxes--;
                label_box4.Location = new Point(11000, 11000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_box5.Location.X && pictureBox1.Location.Y <= (label_box5.Location.Y + label_box5.Height)
                && pictureBox1.Location.X <= (label_box5.Location.X + label_box5.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_box5.Location.Y)
            {
                Sound.play_key();
                label_box5.Visible = false;
                left_boxes--;
                label_box5.Location = new Point(11000, 11000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_box6.Location.X && pictureBox1.Location.Y <= (label_box6.Location.Y + label_box6.Height)
                && pictureBox1.Location.X <= (label_box6.Location.X + label_box6.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_box6.Location.Y)
            {
                Sound.play_key();
                label_box6.Visible = false;
                left_boxes--;
                label_box6.Location = new Point(11000, 11000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_key.Location.X && pictureBox1.Location.Y <= (label_key.Location.Y + label_key.Height)
                && pictureBox1.Location.X <= (label_key.Location.X + label_key.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_key.Location.Y)
            {
                Sound.play_key();
                label_key.Visible = false;
                label_key.Location = new Point(12000, 12000);
                label_door.Visible = false;
                label_door.Location = new Point(10000, 10000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_key1.Location.X && pictureBox1.Location.Y <= (label_key1.Location.Y + label_key1.Height)
                && pictureBox1.Location.X <= (label_key1.Location.X + label_key1.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_key1.Location.Y)
            {
                Sound.play_key();
                label_key1.Visible = false;
                label_key1.Location = new Point(13000, 13000);
                label_door1.Visible = false;
                label_door1.Location = new Point(11000, 11000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_key2.Location.X && pictureBox1.Location.Y <= (label_key2.Location.Y + label_key2.Height)
                && pictureBox1.Location.X <= (label_key2.Location.X + label_key2.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_key2.Location.Y)
            {
                Sound.play_key();
                label_key2.Visible = false;
                label_key2.Location = new Point(14000, 14000);
                label_door2.Visible = false;
                label_door2.Location = new Point(12000, 12000);
            }
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_door.Location.X && pictureBox1.Location.Y <= (label_door.Location.Y + label_door.Height)
    && pictureBox1.Location.X <= (label_door.Location.X + label_door.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_door.Location.Y)
                finish_game();

            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_door1.Location.X && pictureBox1.Location.Y <= (label_door1.Location.Y + label_door1.Height)
            && pictureBox1.Location.X <= (label_door1.Location.X + label_door1.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_door1.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_door2.Location.X && pictureBox1.Location.Y <= (label_door2.Location.Y + label_door2.Height)
           && pictureBox1.Location.X <= (label_door2.Location.X + label_door2.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_door2.Location.Y)
                finish_game();
            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_exit.Location.X && pictureBox1.Location.Y <= (label_exit.Location.Y + label_exit.Height)
                && pictureBox1.Location.X <= (label_exit.Location.X + label_exit.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_exit.Location.Y)
            {
                if (left_boxes == 0)
                    DialogResult = DialogResult.OK;
            }
        }
    }
}
