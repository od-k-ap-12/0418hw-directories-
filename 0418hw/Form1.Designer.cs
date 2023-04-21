namespace _0418hw
{
    partial class Form1
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
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxFindByWordOrPhrase = new System.Windows.Forms.TextBox();
            this.comboBoxDisks = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(4, 31);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(155, 20);
            this.textBoxFile.TabIndex = 0;
            // 
            // textBoxFindByWordOrPhrase
            // 
            this.textBoxFindByWordOrPhrase.Enabled = false;
            this.textBoxFindByWordOrPhrase.Location = new System.Drawing.Point(165, 31);
            this.textBoxFindByWordOrPhrase.Name = "textBoxFindByWordOrPhrase";
            this.textBoxFindByWordOrPhrase.Size = new System.Drawing.Size(352, 20);
            this.textBoxFindByWordOrPhrase.TabIndex = 1;
            // 
            // comboBoxDisks
            // 
            this.comboBoxDisks.FormattingEnabled = true;
            this.comboBoxDisks.Location = new System.Drawing.Point(523, 30);
            this.comboBoxDisks.Name = "comboBoxDisks";
            this.comboBoxDisks.Size = new System.Drawing.Size(114, 21);
            this.comboBoxDisks.TabIndex = 2;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(643, 30);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(100, 21);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Слово или фраза в файле";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Диски";
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(4, 87);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(950, 550);
            this.listViewFiles.TabIndex = 9;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Папка";
            this.columnHeader2.Width = 289;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Размер";
            this.columnHeader3.Width = 246;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата модификации";
            this.columnHeader4.Width = 205;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxDisks);
            this.Controls.Add(this.textBoxFindByWordOrPhrase);
            this.Controls.Add(this.textBoxFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxFindByWordOrPhrase;
        private System.Windows.Forms.ComboBox comboBoxDisks;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}

