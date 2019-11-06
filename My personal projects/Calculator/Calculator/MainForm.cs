using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Main_form : Form
    {
        int i;
        double a;
        double b;
        char current_operation;
        char[] operators;
        public Main_form()
        {
            InitializeComponent();
            i = 0;
            a = 0;
            b = 0;
            current_operation = ' ';
            operators = new char[] { '+', '-', '/', '*' };
        }
        #region Add_numbers
        private void number_1_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_1.Tag.ToString());
            i++;
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_2.Tag.ToString());
            i++;
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_3.Tag.ToString());
            i++;
        }

        private void number_4_Click(object sender, EventArgs e)
        {
 
            Label_result.Text = Label_result.Text.Insert(i, number_4.Tag.ToString());
            i++;
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_5.Tag.ToString());
            i++;
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_6.Tag.ToString());
            i++;
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_7.Tag.ToString());
            i++;
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_8.Tag.ToString());
            i++;
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_9.Tag.ToString());
            i++;
        }

        private void number_0_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_0.Tag.ToString());
            i++;
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, button_sign.Tag.ToString());
            i++;
        }
        private void number_00_Click(object sender, EventArgs e)
        {
            Label_result.Text = Label_result.Text.Insert(i, number_00.Tag.ToString());
            i += 2;
        }
        #endregion
        #region Inteface settings
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа написана Лаутеншлегером Даниилом.","Справка о создателе программы");
        }
        #endregion
        #region Operations
        private void button_plus_Click(object sender, EventArgs e)
        {
            if (Label_result.Text == "") return;
            a = double.Parse(Label_result.Text);
            Label_result.Text = Label_result.Text.Insert(i, " " + button_plus.Tag.ToString() + " ");
            i += 3;
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            
            foreach (char k in Label_result.Text)
                foreach (char z in operators)
                    if (k == z)
                    {
                        current_operation = z;
                        
                        b = double.Parse(Label_result.Text.Substring(Label_result.Text.IndexOf(k) + 1));
                    }
            if (current_operation == '+') {
                Label_result.Text = (a + b).ToString();
            }
            else if (current_operation == '-') {
                Label_result.Text = (a - b).ToString();
            }
            else if (current_operation == '*') {
                Label_result.Text = (a * b).ToString();
            }
            else if (current_operation == '/') {
                Label_result.Text = (a / b).ToString();
            }
            
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (Label_result.Text == "") return;
            a = double.Parse(Label_result.Text);
            Label_result.Text = Label_result.Text.Insert(i, " " + button_minus.Tag.ToString() + " ");
            i += 3;
        }

        private void button_mupltiply_Click(object sender, EventArgs e)
        {
            if (Label_result.Text == "") return;
            a = double.Parse(Label_result.Text);
            Label_result.Text = Label_result.Text.Insert(i, " " + button_mupltiply.Tag.ToString() + " ");
            i += 3;
        }

        private void button_share_Click(object sender, EventArgs e)
        {
            if (Label_result.Text == "") return;
            a = double.Parse(Label_result.Text);
            Label_result.Text = Label_result.Text.Insert(i, " " + button_share.Tag.ToString() + " ");
            i += 3;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Label_result.Text = "";
            i = 0;
        }
        #endregion



    }

}
