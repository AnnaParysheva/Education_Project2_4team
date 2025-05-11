namespace Education_Project2_4team
{
    partial class FavouritesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRemoveFromFavourites = new System.Windows.Forms.Button();
            this.dataGridViewFavouritesCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavouritesCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(282, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 34);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Избранное";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemoveFromFavourites
            // 
            this.btnRemoveFromFavourites.AutoSize = true;
            this.btnRemoveFromFavourites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnRemoveFromFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveFromFavourites.Location = new System.Drawing.Point(837, 447);
            this.btnRemoveFromFavourites.Name = "btnRemoveFromFavourites";
            this.btnRemoveFromFavourites.Size = new System.Drawing.Size(195, 35);
            this.btnRemoveFromFavourites.TabIndex = 7;
            this.btnRemoveFromFavourites.Text = "Удалить из избранного";
            this.btnRemoveFromFavourites.UseVisualStyleBackColor = false;
            this.btnRemoveFromFavourites.Click += new System.EventHandler(this.btnRemoveFromFavourites_Click);
            // 
            // dataGridViewFavouritesCourses
            // 
            this.dataGridViewFavouritesCourses.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewFavouritesCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFavouritesCourses.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFavouritesCourses.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridViewFavouritesCourses.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewFavouritesCourses.Name = "dataGridViewFavouritesCourses";
            this.dataGridViewFavouritesCourses.RowHeadersVisible = false;
            this.dataGridViewFavouritesCourses.RowHeadersWidth = 51;
            this.dataGridViewFavouritesCourses.RowTemplate.Height = 24;
            this.dataGridViewFavouritesCourses.Size = new System.Drawing.Size(1033, 320);
            this.dataGridViewFavouritesCourses.TabIndex = 8;
            // 
            // FavouritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(1057, 507);
            this.Controls.Add(this.dataGridViewFavouritesCourses);
            this.Controls.Add(this.btnRemoveFromFavourites);
            this.Controls.Add(this.textBox1);
            this.Name = "FavouritesForm";
            this.Text = "FavouritesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavouritesCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRemoveFromFavourites;
        private System.Windows.Forms.DataGridView dataGridViewFavouritesCourses;
    }
}