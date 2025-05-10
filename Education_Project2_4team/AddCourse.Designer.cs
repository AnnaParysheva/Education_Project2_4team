using System.Windows.Forms;

namespace Education_Project2_4team
{
    partial class AddCourse
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
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtTitle;
        private Label label7;
        private TextBox txtDescription;
        private Label label10;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.comboBoxLevelOfPreparation = new System.Windows.Forms.ComboBox();
            this.comboBoxEducationForm = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnSaveNewCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(58, 92);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(290, 31);
            this.txtTitle.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(230, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 44);
            this.label7.TabIndex = 13;
            this.label7.Text = "Информация о курсе";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(58, 161);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(290, 147);
            this.txtDescription.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(55, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Описание:";
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
            this.comboBoxDuration.Location = new System.Drawing.Point(379, 92);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(234, 24);
            this.comboBoxDuration.TabIndex = 24;
            this.comboBoxDuration.Text = "Продолжительность курса";
            // 
            // comboBoxLevelOfPreparation
            // 
            this.comboBoxLevelOfPreparation.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxLevelOfPreparation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLevelOfPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLevelOfPreparation.FormattingEnabled = true;
            this.comboBoxLevelOfPreparation.IntegralHeight = false;
            this.comboBoxLevelOfPreparation.Items.AddRange(new object[] {
            "Начальный",
            "Средний",
            "Продвинутый"});
            this.comboBoxLevelOfPreparation.Location = new System.Drawing.Point(58, 341);
            this.comboBoxLevelOfPreparation.Name = "comboBoxLevelOfPreparation";
            this.comboBoxLevelOfPreparation.Size = new System.Drawing.Size(234, 24);
            this.comboBoxLevelOfPreparation.TabIndex = 25;
            this.comboBoxLevelOfPreparation.Text = "Уровень подготовки";
            // 
            // comboBoxEducationForm
            // 
            this.comboBoxEducationForm.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxEducationForm.DropDownWidth = 121;
            this.comboBoxEducationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEducationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEducationForm.FormattingEnabled = true;
            this.comboBoxEducationForm.IntegralHeight = false;
            this.comboBoxEducationForm.ItemHeight = 16;
            this.comboBoxEducationForm.Items.AddRange(new object[] {
            "Очная",
            "Онлайн",
            "Смешанная"});
            this.comboBoxEducationForm.Location = new System.Drawing.Point(379, 212);
            this.comboBoxEducationForm.Name = "comboBoxEducationForm";
            this.comboBoxEducationForm.Size = new System.Drawing.Size(234, 24);
            this.comboBoxEducationForm.TabIndex = 26;
            this.comboBoxEducationForm.Text = "Форма обучения";
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
            this.comboBoxCategory.Location = new System.Drawing.Point(379, 341);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(234, 24);
            this.comboBoxCategory.TabIndex = 27;
            this.comboBoxCategory.Text = "Категория";
            // 
            // btnSaveNewCourse
            // 
            this.btnSaveNewCourse.BackColor = System.Drawing.Color.Orange;
            this.btnSaveNewCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveNewCourse.Location = new System.Drawing.Point(671, 453);
            this.btnSaveNewCourse.Name = "btnSaveNewCourse";
            this.btnSaveNewCourse.Size = new System.Drawing.Size(162, 38);
            this.btnSaveNewCourse.TabIndex = 28;
            this.btnSaveNewCourse.Text = "Сохранить";
            this.btnSaveNewCourse.UseVisualStyleBackColor = false;
            this.btnSaveNewCourse.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.btnSaveNewCourse);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxEducationForm);
            this.Controls.Add(this.comboBoxLevelOfPreparation);
            this.Controls.Add(this.comboBoxDuration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        #endregion
        private ComboBox comboBoxDuration;
        private ComboBox comboBoxLevelOfPreparation;
        private ComboBox comboBoxEducationForm;
        private ComboBox comboBoxCategory;
        private Button btnSaveNewCourse;
    }
}
