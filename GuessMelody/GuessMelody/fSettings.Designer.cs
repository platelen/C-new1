﻿namespace GuessMelody
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
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
            this.btOK.Location = new System.Drawing.Point(106, 313);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 35);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(241, 313);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 35);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cbMusicDuration);
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(106, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки игры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "120",
            "90",
            "60",
            "40",
            "20",
            "15",
            "10",
            "5"});
            this.cbGameDuration.Location = new System.Drawing.Point(152, 19);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(35, 21);
            this.cbGameDuration.TabIndex = 2;
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "40",
            "20",
            "15",
            "10",
            "5"});
            this.cbMusicDuration.Location = new System.Drawing.Point(152, 48);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(35, 21);
            this.cbMusicDuration.TabIndex = 3;
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(9, 76);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(183, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Начинать со случайного места";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music;
            this.ClientSize = new System.Drawing.Size(447, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbAllDirectoty);
            this.Controls.Add(this.btClearList);
            this.Controls.Add(this.btSelectFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRandomStart;
    }
}