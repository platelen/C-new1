namespace GuessMelody
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCounter1 = new System.Windows.Forms.Label();
            this.lbCounter2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(12, 304);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(220, 44);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Transparent;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNext.Location = new System.Drawing.Point(37, 186);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(125, 42);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Следующая";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(295, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Игрок 2";
            // 
            // lbCounter1
            // 
            this.lbCounter1.AutoSize = true;
            this.lbCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCounter1.Location = new System.Drawing.Point(120, 97);
            this.lbCounter1.Name = "lbCounter1";
            this.lbCounter1.Size = new System.Drawing.Size(19, 20);
            this.lbCounter1.TabIndex = 4;
            this.lbCounter1.Text = "0";
            this.lbCounter1.Click += new System.EventHandler(this.lbCounter1_Click);
            // 
            // lbCounter2
            // 
            this.lbCounter2.AutoSize = true;
            this.lbCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCounter2.Location = new System.Drawing.Point(326, 97);
            this.lbCounter2.Name = "lbCounter2";
            this.lbCounter2.Size = new System.Drawing.Size(19, 20);
            this.lbCounter2.TabIndex = 5;
            this.lbCounter2.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(196, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Пауза";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(330, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Продолжить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music;
            this.ClientSize = new System.Drawing.Size(477, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCounter2);
            this.Controls.Add(this.lbCounter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGame";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCounter1;
        private System.Windows.Forms.Label lbCounter2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}