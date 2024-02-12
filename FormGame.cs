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
    public partial class FormGame : Form
    {
        private int correctAnswers = 0;
        private int wrongAnswers = 0;

        public FormGame()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            correctAnswers = 0;
            wrongAnswers = 0;
            LoadNextWord();
        }
        private void LoadNextWord()
        {
            ResetOptionsState();
            var wordAndOptions = Db.GetWordAndOptions();
            labelWord.Text = wordAndOptions.Word;

            // Убедитесь, что список опций содержит кортежи с Option и IsCorrect
            buttonOption1.Text = wordAndOptions.Options[0].Option;
            buttonOption1.Tag = wordAndOptions.Options[0].IsCorrect;

            buttonOption2.Text = wordAndOptions.Options[1].Option;
            buttonOption2.Tag = wordAndOptions.Options[1].IsCorrect;

            buttonOption3.Text = wordAndOptions.Options[2].Option;
            buttonOption3.Tag = wordAndOptions.Options[2].IsCorrect;

            // Сделать кнопки видимыми и активными
            buttonOption1.Visible = buttonOption2.Visible = buttonOption3.Visible = true;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void buttonOption1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var option = button.Text;
            var isCorrect = (bool)button.Tag; // Предполагаем, что мы сохраняем правильность ответа в Tag кнопки

            if (isCorrect)
            {
                correctAnswers++;
                button.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                wrongAnswers++;
                button.BackColor = System.Drawing.Color.Red;
                if (wrongAnswers >= 3)
                {
                    MessageBox.Show($"Игра окончена. Правильных ответов: {correctAnswers}.", "Конец игры", MessageBoxButtons.OK);
                    StartNewGame();
                }
            }

            // Отключаем кнопки после выбора ответа, пока не будет нажата кнопка "Следующий уровень"
            buttonOption1.Enabled = buttonOption2.Enabled = buttonOption3.Enabled = false;
            buttonNextLevel.Visible = true;
        }

        private void buttonNextLevel_Click(object sender, EventArgs e)
        {
            LoadNextWord();
        }
        private void ResetOptionsState()
        {
            buttonOption1.BackColor = buttonOption2.BackColor = buttonOption3.BackColor = System.Drawing.SystemColors.Control;
            buttonOption1.Enabled = buttonOption2.Enabled = buttonOption3.Enabled = true;
            buttonNextLevel.Visible = false;
        }

        private void buttonSkipLevel_Click(object sender, EventArgs e)
        {

        }
    }
}
