namespace GuessMelody
{
    partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.btClearList = new System.Windows.Forms.Button();
            this.cbAllDirectoty = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.BackColor = System.Drawing.Color.Black;
            this.btSelectFolder.ForeColor = System.Drawing.Color.Gold;
            this.btSelectFolder.Location = new System.Drawing.Point(106, 127);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(75, 39);
            this.btSelectFolder.TabIndex = 0;
            this.btSelectFolder.Text = "Выбрать папку";
            this.btSelectFolder.UseVisualStyleBackColor = false;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // btClearList
            // 
            this.btClearList.BackColor = System.Drawing.Color.Black;
            this.btClearList.ForeColor = System.Drawing.Color.Gold;
            this.btClearList.Location = new System.Drawing.Point(241, 127);
            this.btClearList.Name = "btClearList";
            this.btClearList.Size = new System.Drawing.Size(75, 39);
            this.btClearList.TabIndex = 1;
            this.btClearList.Text = "Очистить список";
            this.btClearList.UseVisualStyleBackColor = false;
            // 
            // cbAllDirectoty
            // 
            this.cbAllDirectoty.AutoSize = true;
            this.cbAllDirectoty.BackColor = System.Drawing.Color.Transparent;
            this.cbAllDirectoty.ForeColor = System.Drawing.Color.Gold;
            this.cbAllDirectoty.Location = new System.Drawing.Point(155, 172);
            this.cbAllDirectoty.Name = "cbAllDirectoty";
            this.cbAllDirectoty.Size = new System.Drawing.Size(118, 17);
            this.cbAllDirectoty.TabIndex = 2;
            this.cbAllDirectoty.Text = "Вложенные папки";
            this.cbAllDirectoty.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 108);
            this.listBox1.TabIndex = 3;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(106, 251);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(241, 251);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music;
            this.ClientSize = new System.Drawing.Size(433, 286);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbAllDirectoty);
            this.Controls.Add(this.btClearList);
            this.Controls.Add(this.btSelectFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettings";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.Button btClearList;
        private System.Windows.Forms.CheckBox cbAllDirectoty;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}