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
    public partial class TopBoardForm : Form
    {
        public TopBoardForm()
        {
            InitializeComponent();
            FillTop();
            dataGridViewLider.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewLider.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewLider.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Автоматически подстраиваем размер колонок
            dataGridViewLider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLider.Columns[0].HeaderText = "Никнейм"; 
            dataGridViewLider.Columns[1].HeaderText = "Счет";
        }
        private void FillTop()
        {
            Db db = new Db();
            SqlConnection connection = db.getConnection();
            string query = "SELECT Users.Username, UserProgress.LastReviewed " +
                           "FROM Users " +
                           "INNER JOIN UserProgress ON Users.UserID = UserProgress.UserID";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewLider.DataSource = dataTable;
            }
        }
        private void TopBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
