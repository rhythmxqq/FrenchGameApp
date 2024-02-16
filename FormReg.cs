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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
           Boolean regAuth =  RegisterUser(textBoxLogin.Text, textBoxPassword.Text, "french", textBoxMail.Text, textBoxName.Text);
            if (regAuth)
            {
                MessageBox.Show("Регистрация прошла успешна");

            }
            else
            {
                MessageBox.Show("чета не так");
            }

        }
        public bool RegisterUser(string username, string password,string learn, string mail, string name) 
        {
            Db db = new Db();
            try
            {
                db.openConnection();
                string query = "INSERT INTO Users (Username, Password, LanguageLearning, Mail, UserFirstName) VALUES (@Username, @Password, @Mail, @Name, @learn)";
                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@learn", learn);
                cmd.Parameters.AddWithValue("@Mail", mail);
                cmd.Parameters.AddWithValue("@Name", name);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true; // Успешно зарегистрирован
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
            return false; // Ошибка при регистрации
        }
    }
}
