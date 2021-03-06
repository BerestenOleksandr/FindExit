﻿using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_level1();
        }

        private void checkBox_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sound.Checked)
            {
                Sound.sound_on();
                checkBox_sound.Text = "Грати із звуком";
                Sound.play_key();
            }
            else
            {
                Sound.sound_off();
                checkBox_sound.Text = "Грати без звука";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == DialogResult.OK)
                start_level2();
        }

        private void start_level2()
        {
            Sound.play_youwin();
           
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == DialogResult.OK)
                start_level3();
        }

        private void start_level3()
        {
            FormLevel3 level3 = new FormLevel3();
            DialogResult dr = level3.ShowDialog();
            if (dr == DialogResult.OK)
            {
                start_youwin();
            }
        }

        private void start_rules()
        {
            FormRules rules = new FormRules();
            DialogResult dr = rules.ShowDialog();
        }

        private void start_youwin()
        {
             Sound.play_youwin();
            MessageBox.Show("Ви пройшли всі рівні", "Вітаю");
        }

        private void button_rules_Click(object sender, EventArgs e)
        {
            start_rules();
        }
    }
}
