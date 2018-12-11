namespace GuessMelody
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.butGame = new System.Windows.Forms.Button();
            this.butSettings = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butGame
            // 
            this.butGame.Location = new System.Drawing.Point(185, 85);
            this.butGame.Name = "butGame";
            this.butGame.Size = new System.Drawing.Size(152, 52);
            this.butGame.TabIndex = 0;
            this.butGame.Text = "Игра";
            this.butGame.UseVisualStyleBackColor = true;
            // 
            // butSettings
            // 
            this.butSettings.Location = new System.Drawing.Point(185, 152);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(152, 52);
            this.butSettings.TabIndex = 1;
            this.butSettings.Text = "Настройки";
            this.butSettings.UseVisualStyleBackColor = true;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(185, 235);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(152, 52);
            this.butExit.TabIndex = 2;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music;
            this.ClientSize = new System.Drawing.Size(532, 405);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butSettings);
            this.Controls.Add(this.butGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Угадай мелодию";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butGame;
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.Button butExit;
    }
}

