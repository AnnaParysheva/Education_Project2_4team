namespace Education_Project2_4team
{
    partial class questionnare
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
            this.labelQuestionnare = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.btnChooseCourses = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestionnare
            // 
            this.labelQuestionnare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestionnare.AutoSize = true;
            this.labelQuestionnare.BackColor = System.Drawing.SystemColors.Info;
            this.labelQuestionnare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestionnare.Location = new System.Drawing.Point(372, 18);
            this.labelQuestionnare.MinimumSize = new System.Drawing.Size(200, 40);
            this.labelQuestionnare.Name = "labelQuestionnare";
            this.labelQuestionnare.Size = new System.Drawing.Size(200, 40);
            this.labelQuestionnare.TabIndex = 0;
            this.labelQuestionnare.Text = "Анкетирование";
            this.labelQuestionnare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxCategory.DropDownWidth = 185;
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.IntegralHeight = false;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Технические науки",
            "Гуманитарные науки",
            "Естественные науки",
            "Творчество"});
            this.comboBoxCategory.Location = new System.Drawing.Point(437, 103);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(234, 24);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.Text = "Категория";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.IntegralHeight = false;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Начальный",
            "Средний",
            "Продвинутый"});
            this.comboBoxLevel.Location = new System.Drawing.Point(437, 273);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(234, 24);
            this.comboBoxLevel.TabIndex = 2;
            this.comboBoxLevel.Text = "Уровень подготовки";
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxForm.DropDownWidth = 121;
            this.comboBoxForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.IntegralHeight = false;
            this.comboBoxForm.ItemHeight = 16;
            this.comboBoxForm.Items.AddRange(new object[] {
            "Очная",
            "Онлайн",
            "Смешанная"});
            this.comboBoxForm.Location = new System.Drawing.Point(717, 103);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(234, 24);
            this.comboBoxForm.TabIndex = 3;
            this.comboBoxForm.Text = "Форма обучения";
            // 
            // btnChooseCourses
            // 
            this.btnChooseCourses.AutoSize = true;
            this.btnChooseCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnChooseCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseCourses.Location = new System.Drawing.Point(811, 486);
            this.btnChooseCourses.Name = "btnChooseCourses";
            this.btnChooseCourses.Size = new System.Drawing.Size(148, 35);
            this.btnChooseCourses.TabIndex = 4;
            this.btnChooseCourses.Text = "Подобрать курсы";
            this.btnChooseCourses.UseVisualStyleBackColor = false;
            this.btnChooseCourses.Click += new System.EventHandler(this.btnChooseCourses_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Education_Project2_4team.Properties.Resources.e7d55c34a7b4cbcefe5b4d8f9ac20a4d;
            this.pictureBox1.Location = new System.Drawing.Point(26, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxDuration.DropDownWidth = 121;
            this.comboBoxDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.IntegralHeight = false;
            this.comboBoxDuration.ItemHeight = 16;
            this.comboBoxDuration.Items.AddRange(new object[] {
            "1 месяц",
            "3 месяца",
            "6 месяцев",
            "1 год"});
            this.comboBoxDuration.Location = new System.Drawing.Point(717, 273);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(234, 24);
            this.comboBoxDuration.TabIndex = 6;
            this.comboBoxDuration.Text = "Продолжительность курса";
            // 
            // questionnare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(983, 547);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChooseCourses);
            this.Controls.Add(this.comboBoxForm);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelQuestionnare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "questionnare";
            this.Text = "questionnare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestionnare;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.ComboBox comboBoxForm;
        private System.Windows.Forms.Button btnChooseCourses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxDuration;
    }
}