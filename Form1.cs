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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean auth = AuthenticateUser(logTextBox.Text, passwordTextBox.Text);
            if (auth)
            {
                Db db = new Db();
                SqlConnection connection = db.getConnection();
                using (connection)
                {
                    connection.Open();
                    string quare = "SELECT UserID FROM Users WHERE Username = @log";
                    SqlCommand command = new SqlCommand(quare, connection);
                    command.Parameters.AddWithValue("@log",logTextBox.Text);
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    FormMain formM = new FormMain(id);
                    formM.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("чета не так");
            }
        }
        public bool AuthenticateUser(string username, string password)
        {
            Db db = new Db();
            bool isAuthenticated = false;
            try
            {
                db.openConnection();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    isAuthenticated = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                db.closedConnection();
            }
            return isAuthenticated;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            FormReg form1 = new FormReg();
            form1.ShowDialog();
        }
    }
}
