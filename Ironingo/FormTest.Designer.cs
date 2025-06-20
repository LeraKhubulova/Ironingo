namespace Ironingo
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.lblOssetianWord = new System.Windows.Forms.Label();
            this.txtUserTranslation = new System.Windows.Forms.TextBox();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pictureBoxProspekt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProspekt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOssetianWord
            // 
            this.lblOssetianWord.AutoSize = true;
            this.lblOssetianWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOssetianWord.Location = new System.Drawing.Point(105, 208);
            this.lblOssetianWord.Name = "lblOssetianWord";
            this.lblOssetianWord.Size = new System.Drawing.Size(0, 61);
            this.lblOssetianWord.TabIndex = 0;
            // 
            // txtUserTranslation
            // 
            this.txtUserTranslation.BackColor = System.Drawing.Color.Red;
            this.txtUserTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserTranslation.Location = new System.Drawing.Point(105, 322);
            this.txtUserTranslation.Name = "txtUserTranslation";
            this.txtUserTranslation.Size = new System.Drawing.Size(340, 67);
            this.txtUserTranslation.TabIndex = 1;
            // 
            // btnNextWord
            // 
            this.btnNextWord.BackColor = System.Drawing.Color.Yellow;
            this.btnNextWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextWord.Location = new System.Drawing.Point(105, 457);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(413, 174);
            this.btnNextWord.TabIndex = 2;
            this.btnNextWord.Text = "Следующее слово";
            this.btnNextWord.UseVisualStyleBackColor = false;
            this.btnNextWord.Click += new System.EventHandler(this.btnNextWord_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgress.Location = new System.Drawing.Point(106, 750);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 55);
            this.lblProgress.TabIndex = 3;
            // 
            // pictureBoxProspekt
            // 
            this.pictureBoxProspekt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProspekt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProspekt.Image")));
            this.pictureBoxProspekt.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProspekt.Name = "pictureBoxProspekt";
            this.pictureBoxProspekt.Size = new System.Drawing.Size(1409, 907);
            this.pictureBoxProspekt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProspekt.TabIndex = 4;
            this.pictureBoxProspekt.TabStop = false;
            this.pictureBoxProspekt.Click += new System.EventHandler(this.pictureBoxProspekt_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 907);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnNextWord);
            this.Controls.Add(this.txtUserTranslation);
            this.Controls.Add(this.lblOssetianWord);
            this.Controls.Add(this.pictureBoxProspekt);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProspekt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOssetianWord;
        private System.Windows.Forms.TextBox txtUserTranslation;
        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.PictureBox pictureBoxProspekt;
    }
}