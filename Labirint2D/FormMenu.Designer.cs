namespace Labirint2D
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.button_start = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.checkBox_sound = new System.Windows.Forms.CheckBox();
            this.button_rules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.Control;
            this.button_start.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(56, 104);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(91, 45);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Почати гру";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(576, 349);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(91, 45);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Вихід";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // checkBox_sound
            // 
            this.checkBox_sound.AutoSize = true;
            this.checkBox_sound.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_sound.Checked = true;
            this.checkBox_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sound.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_sound.ForeColor = System.Drawing.Color.White;
            this.checkBox_sound.Location = new System.Drawing.Point(127, 393);
            this.checkBox_sound.Name = "checkBox_sound";
            this.checkBox_sound.Size = new System.Drawing.Size(171, 28);
            this.checkBox_sound.TabIndex = 2;
            this.checkBox_sound.Text = "Грати із звуком";
            this.checkBox_sound.UseVisualStyleBackColor = false;
            this.checkBox_sound.CheckedChanged += new System.EventHandler(this.checkBox_sound_CheckedChanged);
            // 
            // button_rules
            // 
            this.button_rules.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rules.Location = new System.Drawing.Point(571, 104);
            this.button_rules.Name = "button_rules";
            this.button_rules.Size = new System.Drawing.Size(96, 45);
            this.button_rules.TabIndex = 3;
            this.button_rules.Text = "Правила";
            this.button_rules.UseVisualStyleBackColor = true;
            this.button_rules.Click += new System.EventHandler(this.button_rules_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirint2D.Properties.Resources.longleat_hedge_maze_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(725, 481);
            this.Controls.Add(this.button_rules);
            this.Controls.Add(this.checkBox_sound);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirint2D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.CheckBox checkBox_sound;
        private System.Windows.Forms.Button button_rules;
    }
}

