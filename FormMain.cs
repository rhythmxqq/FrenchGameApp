using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFrench
{
    public partial class FormMain : Form
    {


        public FormMain()
        {
            InitializeComponent();
        }
       

        private void buttonLearnSlowed_Click(object sender, EventArgs e)
        {
            FormGame form = new FormGame();
            form.ShowDialog();
        }

        private void buttonLearnSpeed_Click(object sender, EventArgs e)
        {

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {

        }

        private void buttonTopArray_Click(object sender, EventArgs e)
        {

        }
    }
}
