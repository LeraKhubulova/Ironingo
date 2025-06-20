namespace Ironingo
{
    partial class FormDictionary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDictionary));
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.pictureBoxIroningo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIroningo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWords
            // 
            this.listBoxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.ItemHeight = 37;
            this.listBoxWords.Location = new System.Drawing.Point(28, 48);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(363, 411);
            this.listBoxWords.TabIndex = 0;
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.Red;
            this.btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddWord.Location = new System.Drawing.Point(28, 533);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(363, 123);
            this.btnAddWord.TabIndex = 1;
            this.btnAddWord.Text = "Добавить слово";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteWord.Location = new System.Drawing.Point(28, 707);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(363, 168);
            this.btnDeleteWord.TabIndex = 2;
            this.btnDeleteWord.Text = "Удалить выделенное слово";
            this.btnDeleteWord.UseVisualStyleBackColor = false;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Red;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(1291, 216);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(260, 123);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(1291, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 123);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.Color.Yellow;
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTest.Location = new System.Drawing.Point(1291, 707);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(260, 123);
            this.btnStartTest.TabIndex = 5;
            this.btnStartTest.Text = "Начать тест";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // pictureBoxIroningo
            // 
            this.pictureBoxIroningo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxIroningo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIroningo.Image")));
            this.pictureBoxIroningo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIroningo.Name = "pictureBoxIroningo";
            this.pictureBoxIroningo.Size = new System.Drawing.Size(1589, 1024);
            this.pictureBoxIroningo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIroningo.TabIndex = 6;
            this.pictureBoxIroningo.TabStop = false;
            // 
            // FormDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 1024);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.pictureBoxIroningo);
            this.Name = "FormDictionary";
            this.Text = "FormIroningo";
            this.Load += new System.EventHandler(this.FormDictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIroningo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.PictureBox pictureBoxIroningo;
    }
}

