using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForOOOElyferiev
{
    public partial class Form_start : Form
    {
        Main_program f1;
        public Form_start()
        {
            InitializeComponent();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
