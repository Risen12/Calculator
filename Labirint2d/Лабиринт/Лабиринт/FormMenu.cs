using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Лабиринт
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoxSound_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BoxSound.Checked)
            {
                BoxSound.Text = "Звук есть";
                Sound.sound_on();
            }
            else
            {
                Sound.sound_off();
                BoxSound.Text = "Звука нет";
            }
            Sound.play_key();
            }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            Sound.play_start();
        }


    }
}
