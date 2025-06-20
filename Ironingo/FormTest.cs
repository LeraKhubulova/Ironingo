using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ironingo
{
    public partial class FormTest : Form
    {
        private TestManager testManager;
        private Word currentWord;
        public FormTest(IReadOnlyList<Word> words)
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(920, 700);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            testManager = new TestManager(words);
            ShowNextWord();
        }

        private void ShowNextWord()
        {
            currentWord = testManager.GetNextWord();
            if (currentWord == null)
            {
                MessageBox.Show($"Тест завершён!\nПравильных ответов: {testManager.CorrectAnswers} из {testManager.TotalWords}", "Результаты теста", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            lblOssetianWord.Text = currentWord.Ossetian;
            txtUserTranslation.Clear();
            txtUserTranslation.Focus();
            lblProgress.Text = $"Слово {testManager.CurrentIndex} из {testManager.TotalWords}";
        }

        private void btnNextWord_Click(object sender, EventArgs e)
        {
            testManager.CheckAnswer(txtUserTranslation.Text);
            ShowNextWord();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxProspekt_Click(object sender, EventArgs e)
        {

        }
    }
}
