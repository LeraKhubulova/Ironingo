namespace Ironingo
{
    partial class FormWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWord));
            this.txtOssetian = new System.Windows.Forms.TextBox();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelWordPrint = new System.Windows.Forms.Label();
            this.labelTranslatePrint = new System.Windows.Forms.Label();
            this.pictureBoxPirog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPirog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOssetian
            // 
            this.txtOssetian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOssetian.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOssetian.Location = new System.Drawing.Point(89, 276);
            this.txtOssetian.Name = "txtOssetian";
            this.txtOssetian.Size = new System.Drawing.Size(333, 67);
            this.txtOssetian.TabIndex = 0;
            // 
            // txtTranslation
            // 
            this.txtTranslation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTranslation.Location = new System.Drawing.Point(957, 276);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(352, 67);
            this.txtTranslation.TabIndex = 1;
            this.txtTranslation.TextChanged += new System.EventHandler(this.txtTranslation_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Red;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(89, 503);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(333, 143);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(89, 693);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(333, 143);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelWordPrint
            // 
            this.labelWordPrint.AutoSize = true;
            this.labelWordPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelWordPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWordPrint.Location = new System.Drawing.Point(107, 157);
            this.labelWordPrint.Name = "labelWordPrint";
            this.labelWordPrint.Size = new System.Drawing.Size(292, 79);
            this.labelWordPrint.TabIndex = 4;
            this.labelWordPrint.Text = "СЛОВО";
            // 
            // labelTranslatePrint
            // 
            this.labelTranslatePrint.AutoSize = true;
            this.labelTranslatePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTranslatePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTranslatePrint.Location = new System.Drawing.Point(943, 157);
            this.labelTranslatePrint.Name = "labelTranslatePrint";
            this.labelTranslatePrint.Size = new System.Drawing.Size(382, 79);
            this.labelTranslatePrint.TabIndex = 5;
            this.labelTranslatePrint.Text = "ПЕРЕВОД";
            this.labelTranslatePrint.Click += new System.EventHandler(this.labelTranslatePrint_Click);
            // 
            // pictureBoxPirog
            // 
            this.pictureBoxPirog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPirog.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPirog.Image")));
            this.pictureBoxPirog.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPirog.Name = "pictureBoxPirog";
            this.pictureBoxPirog.Size = new System.Drawing.Size(1366, 931);
            this.pictureBoxPirog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPirog.TabIndex = 6;
            this.pictureBoxPirog.TabStop = false;
            // 
            // FormWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 931);
            this.Controls.Add(this.labelTranslatePrint);
            this.Controls.Add(this.labelWordPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.txtOssetian);
            this.Controls.Add(this.pictureBoxPirog);
            this.Name = "FormWord";
            this.Text = "FormWord";
            this.Load += new System.EventHandler(this.FormWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPirog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOssetian;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelWordPrint;
        private System.Windows.Forms.Label labelTranslatePrint;
        private System.Windows.Forms.PictureBox pictureBoxPirog;
    }
}