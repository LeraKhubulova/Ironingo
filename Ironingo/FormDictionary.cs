using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ironingo
{
    public partial class FormDictionary : Form
    {
        private DictionaryManager dictManager;
        public FormDictionary()
        {
            InitializeComponent();
            this.Size = new Size(820, 600);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            dictManager = new DictionaryManager("dictionary.txt");
        }

        private void FormDictionary_Load(object sender, EventArgs e)
        {
            dictManager.Load();
            UpdateListBoxSorted();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            using (FormWord formWord = new FormWord())
            {
                if (formWord.ShowDialog() == DialogResult.OK)
                {
                    Word newWord = new Word
                    {
                        Ossetian = formWord.Ossetian,
                        Translation = formWord.Translation
                    };

                    if (!dictManager.AddWord(newWord))
                    {
                        MessageBox.Show($"Слово '{newWord.Ossetian}' уже есть в словаре.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        UpdateListBoxSorted();
                    }
                }
            }
        }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            int index = listBoxWords.SelectedIndex;
            if (index >= 0)
            {
                var wordToRemove = dictManager.Words[index];
                dictManager.RemoveWord(wordToRemove);
                UpdateListBoxSorted();
            }
            else
            {
                MessageBox.Show("Выберите слово для удаления.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dictManager.Save();
            MessageBox.Show("Данные сохранены.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dictManager.Load();
            UpdateListBoxSorted();
            MessageBox.Show("Данные загружены.");
        }
        private void UpdateListBoxSorted()
        {
            var sortedWords = dictManager.Words.OrderBy(w => w.Ossetian, StringComparer.OrdinalIgnoreCase).ToList();

            listBoxWords.Items.Clear();
            foreach (var word in sortedWords)
            {
                listBoxWords.Items.Add(word.ToString());
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (!dictManager.Words.Any())
            {
                MessageBox.Show("Словарь пуст. Добавьте слова перед началом теста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormTest formTest = new FormTest(dictManager.Words))
            {
                formTest.ShowDialog();
            }
        }
    }
}
