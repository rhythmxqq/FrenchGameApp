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
    public partial class ListWordForm : Form
    {
        public ListWordForm()
        {
          
            InitializeComponent();
            FillDataGridView();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Слово";
            dataGridView1.Columns[1].HeaderText = "Перевод";
        }

        private void ListWordForm_Load(object sender, EventArgs e)
        {

        }
        private void FillDataGridView()
        {
            Db db = new Db();
            SqlConnection connection = db.getConnection();
            string query = "SELECT Word, Translation FROM Words WHERE IsCorrect = 1";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
