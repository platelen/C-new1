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
            this.btPlay = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(202, 78);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(166, 50);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "Начать новую игру";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(202, 135);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(166, 50);
            this.btSettings.TabIndex = 1;
            this.btSettings.Text = "Настройки";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(202, 191);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(166, 50);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music;
            this.ClientSize = new System.Drawing.Size(571, 324);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Угадай мелодию";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btExit;
    }
}

