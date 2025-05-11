namespace Education_Project2_4team
{
    partial class CoursesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddToFavourites = new System.Windows.Forms.Button();
            this.btnOpenFavourites = new System.Windows.Forms.Button();
            this.btnRedact = new System.Windows.Forms.Button();
            this.dataGridViewInformation = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToFavourites
            // 
            this.btnAddToFavourites.AutoSize = true;
            this.btnAddToFavourites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAddToFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToFavourites.Location = new System.Drawing.Point(708, 448);
            this.btnAddToFavourites.Name = "btnAddToFavourites";
            this.btnAddToFavourites.Size = new System.Drawing.Size(188, 47);
            this.btnAddToFavourites.TabIndex = 2;
            this.btnAddToFavourites.Text = "Добавить в избранное";
            this.btnAddToFavourites.UseVisualStyleBackColor = false;
            this.btnAddToFavourites.Click += new System.EventHandler(this.btnAddToFavourites_Click);
            // 
            // btnOpenFavourites
            // 
            this.btnOpenFavourites.AutoSize = true;
            this.btnOpenFavourites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnOpenFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFavourites.Location = new System.Drawing.Point(912, 448);
            this.btnOpenFavourites.Name = "btnOpenFavourites";
            this.btnOpenFavourites.Size = new System.Drawing.Size(181, 47);
            this.btnOpenFavourites.TabIndex = 3;
            this.btnOpenFavourites.Text = "Перейти в избранное";
            this.btnOpenFavourites.UseVisualStyleBackColor = false;
            this.btnOpenFavourites.Click += new System.EventHandler(this.btnOpenFavourites_Click);
            // 
            // btnRedact
            // 
            this.btnRedact.AutoSize = true;
            this.btnRedact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnRedact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRedact.Location = new System.Drawing.Point(35, 448);
            this.btnRedact.Name = "btnRedact";
            this.btnRedact.Size = new System.Drawing.Size(171, 47);
            this.btnRedact.TabIndex = 4;
            this.btnRedact.Text = "Редактировать курс";
            this.btnRedact.UseVisualStyleBackColor = false;
            this.btnRedact.Click += new System.EventHandler(this.btnRedact_Click);
            // 
            // dataGridViewInformation
            // 
            this.dataGridViewInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInformation.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInformation.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInformation.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridViewInformation.Location = new System.Drawing.Point(35, 68);
            this.dataGridViewInformation.Name = "dataGridViewInformation";
            this.dataGridViewInformation.RowHeadersVisible = false;
            this.dataGridViewInformation.RowHeadersWidth = 51;
            this.dataGridViewInformation.RowTemplate.Height = 24;
            this.dataGridViewInformation.Size = new System.Drawing.Size(1085, 335);
            this.dataGridViewInformation.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(256, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Подбор курсов";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.AutoSize = true;
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCourse.Location = new System.Drawing.Point(229, 448);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(171, 47);
            this.btnAddCourse.TabIndex = 8;
            this.btnAddCourse.Text = "Добавить курс";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.AutoSize = true;
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCourse.Location = new System.Drawing.Point(426, 448);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(171, 47);
            this.btnDeleteCourse.TabIndex = 9;
            this.btnDeleteCourse.Text = "Удалить курс";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(159)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1148, 517);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewInformation);
            this.Controls.Add(this.btnRedact);
            this.Controls.Add(this.btnOpenFavourites);
            this.Controls.Add(this.btnAddToFavourites);
            this.Name = "CoursesForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddToFavourites;
        private System.Windows.Forms.Button btnOpenFavourites;
        private System.Windows.Forms.Button btnRedact;
        private System.Windows.Forms.DataGridView dataGridViewInformation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
    }
}

