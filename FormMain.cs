using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFrench
{
    public partial class FormMain : Form
    {

        int id = 0;
        public FormMain(int idUs)
        {
            id = idUs;
            InitializeComponent();
        }
       

        private void buttonLearnSlowed_Click(object sender, EventArgs e)
        {
            FormGame form = new FormGame(id);
            form.ShowDialog();
        }

        private void buttonLearnSpeed_Click(object sender, EventArgs e)
        {
            FormSecondGame form = new FormSecondGame(id);
            form.ShowDialog();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            ProfileForm formx = new ProfileForm(id);
            formx.ShowDialog();
        }

        private void buttonTopArray_Click(object sender, EventArgs e)
        {
            TopBoardForm form2  = new TopBoardForm();
            form2.ShowDialog();
        }

        private void buttonListWord_Click(object sender, EventArgs e)
        {
            ListWordForm form = new ListWordForm();
            form.ShowDialog();
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            FormTranslate formq = new FormTranslate();
            formq.ShowDialog();
        }
    }
}
