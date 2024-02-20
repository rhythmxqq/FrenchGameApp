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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appFrench
{
    public partial class FormSecondGame : Form
    {
        int id = 0;
        int count = 0;
        int liveHearts = 3;
        public FormSecondGame(int id_us)
        {
            id = id_us;
            InitializeComponent();
            wordCreate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTranslation();
        }
        private void SearchTranslation()
        {
            // Получаем слово из Label
            string wordToTranslate = labelForWord.Text;

            Db db = new Db();
            SqlConnection connection = db.getConnection();

            string query = "SELECT Translation FROM Words WHERE Word = @Word AND IsCorrect = 1";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Word", wordToTranslate);

                connection.Open();
                object translation = command.ExecuteScalar();
                connection.Close();

                if (translation.ToString().Equals(textBox1.Text)) 
                {
                    count++;
                    labelCount.Text = count.ToString();
                    textBox1.Clear();
                    wordCreate();
                }
                else
                {
                    liveHearts--;
                    if (liveHearts > 0)
                    {
                        textBox1.Clear();
                        wordCreate();
                    }
                    else
                    {
                        saveRecord(count);
                        MessageBox.Show($"Игра окончена. Правильных ответов: {count}.", "Конец игры", MessageBoxButtons.OK);
                        count = 0;
                        liveHearts = 3; labelCount.Text = count.ToString();
                        textBox1.Clear();
                        wordCreate();
                    }
                }
                }
            }
        void saveRecord(int correctAnswer)
        {
            Db db = new Db();
            SqlConnection connection = db.getConnection();
            using (connection)
            {
                connection.Open();
                string quare = "UPDATE Games SET Score = @record, PlayedOn = @date WHERE UserID = @id AND @record > Score AND GameType = 2";
                SqlCommand command = new SqlCommand(quare, connection);
                command.Parameters.AddWithValue("@record", correctAnswer);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                int rowsAffected = command.ExecuteNonQuery();
            }

        }
        void wordCreate()
        {
            Db db = new Db();
            using (var connection = db.getConnection())
            {
                connection.Open();

                // Получаем случайное слово на французском
                var command = new SqlCommand("SELECT TOP 1 WordID, Word FROM Words WHERE LanguagePair = 'FR-RU' ORDER BY NEWID();", connection);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("No words found");
                    }
                    labelForWord.Text = reader["Word"].ToString();
                }

            }
        }
    }
}
