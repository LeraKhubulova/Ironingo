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
    public partial class FormWord : Form
    {
        public FormWord()
        {
            InitializeComponent();
            this.Size = new Size(720, 500);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        public string Ossetian => txtOssetian.Text;
        public string Translation => txtTranslation.Text;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOssetian.Text) || string.IsNullOrWhiteSpace(txtTranslation.Text))
            {
                MessageBox.Show("Пожалуйста, заполните оба поля: слово и перевод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // не закрываем форму, ждем корректного ввода
            }
            this.DialogResult = DialogResult.OK; // сигнализируем, что форма закрывается с результатом OK
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // форма закрывается без сохранения
            this.Close();
        }


        private void FormWord_Load(object sender, EventArgs e)
        {

        }
    }
}
