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
    public partial class FormLevel1 : Form
    {

        int left_boxes;
        public FormLevel1()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point;
            point = pictureBox1.Location = new Point(90, 30);
            left_boxes = 6;
            label_box1.Visible = true;
            label_box1.Location = new Point(50, 120);
            label_box2.Visible = true;
            label_box2.Location = new Point(160, 400);
            label_box3.Visible = true;
            label_box3.Location = new Point(340, 240);
            label_box4.Visible = true;
            label_box4.Location = new Point(640, 410);
            label_box5.Visible = true;
            label_box5.Location = new Point(710, 75);
            label_box6.Visible = true;
            label_box6.Location = new Point(905, 180);
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

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void FormLevel1_KeyDown(object sender, KeyEventArgs e)
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

            if ((pictureBox1.Location.X + pictureBox1.Width) >= label_exit.Location.X && pictureBox1.Location.Y <= (label_exit.Location.Y + label_exit.Height)
                && pictureBox1.Location.X <= (label_exit.Location.X + label_exit.Width) && (pictureBox1.Location.Y + pictureBox1.Height) >= label_exit.Location.Y)
            {
                if(left_boxes == 0)
                DialogResult = DialogResult.OK;
            }
        }
    }
}
