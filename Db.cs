using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFrench
{
    internal class Db
    {
            SqlConnection connection = new SqlConnection("Server =REVISION-PC\\SQLEXPRESS; Database=franchLangBase;Trusted_Connection=True;");
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }

            public void closedConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            public SqlConnection getConnection()
            {
                return connection;
            }
        public static (string Word, List<(string Option, bool IsCorrect)> Options, string CorrectOption) GetWordAndOptions()
        {
            Db db = new Db();
            string correctWord = "";
            string correctOption = "";
            var options = new List<(string Option, bool IsCorrect)>();

            using (var connection = db.getConnection())
            {
                connection.Open();

                // Получаем случайное слово на французском
                var command = new SqlCommand("SELECT TOP 1 WordID, Word FROM Words WHERE LanguagePair = 'FR-RU' ORDER BY NEWID();", connection);
                int wordId;
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("No words found");
                    }
                    correctWord = reader["Word"].ToString();
                    wordId = (int)reader["WordID"];
                }

                // Получаем правильный перевод для слова
                command = new SqlCommand("SELECT Translation FROM Words WHERE WordID = @WordID AND IsCorrect = 1;", connection);
                command.Parameters.AddWithValue("@WordID", wordId);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("No correct translation found");
                    }
                    correctOption = reader["Translation"].ToString();
                    // Добавляем правильный перевод с меткой корректности
                    options.Add((correctOption, true));
                }

                // Получаем два неправильных перевода
                command = new SqlCommand("SELECT TOP 2 Translation FROM Words WHERE WordID != @WordID AND IsCorrect = 0 AND LanguagePair = 'RU-FR' ORDER BY NEWID();", connection);
                command.Parameters.AddWithValue("@WordID", wordId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        options.Add((reader["Translation"].ToString(), false));
                    }
                }

                // Перемешиваем варианты ответа
                Shuffle(options);
            }

            return (correctWord, options, correctOption);
        }
        private static void Shuffle(List<(string Option, bool IsCorrect)> options)
        {
            var rng = new Random();
            int n = options.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = options[k];
                options[k] = options[n];
                options[n] = value;
            }
        }
        private static List<(string Option, bool IsCorrect)> GetOptionsForWord(int wordId)
        {
            Db db = new Db();
            var options = new List<(string, bool)>();
            // Убедитесь, что соединение открыто
            var connection = db.getConnection();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            var query = @"SELECT Translation, IsCorrect FROM Words WHERE WordID = @WordID OR (WordID != @WordID AND LanguagePair = 'RU-FR') ORDER BY NEWID()";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@WordID", wordId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var option = reader["Translation"].ToString();
                        var isCorrect = (bool)reader["IsCorrect"];
                        options.Add((option, isCorrect));
                    }
                }
            }
 
            connection.Close();

            return options;
        }
       
        public static string GetCorrectAnswer(string word)
        {
            Db db = new Db();
            string correctAnswer = "";
            using (var connection = db.getConnection())
            {
                // Предполагаем, что у нас есть поле IsCorrect в таблице Words
                var query = @"SELECT Translation FROM Words WHERE Word = @Word AND IsCorrect = 1";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Word", word);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        correctAnswer = result.ToString();
                    }
                }
                db.closedConnection();
            }
            return correctAnswer;
        }

    }
}
