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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemoveFromFavourites = new System.Windows.Forms.Button();
            this.dataGridViewFavouritesCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavouritesCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveFromFavourites
            // 
            this.btnRemoveFromFavourites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridViewFavouritesCourses.AllowUserToAddRows = false;
            this.dataGridViewFavouritesCourses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewFavouritesCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFavouritesCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFavouritesCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFavouritesCourses.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewFavouritesCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFavouritesCourses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFavouritesCourses.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridViewFavouritesCourses.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewFavouritesCourses.Name = "dataGridViewFavouritesCourses";
            this.dataGridViewFavouritesCourses.ReadOnly = true;
            this.dataGridViewFavouritesCourses.RowHeadersVisible = false;
            this.dataGridViewFavouritesCourses.RowHeadersWidth = 51;
            this.dataGridViewFavouritesCourses.RowTemplate.Height = 24;
            this.dataGridViewFavouritesCourses.Size = new System.Drawing.Size(1033, 320);
            this.dataGridViewFavouritesCourses.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Избранное";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FavouritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(1057, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFavouritesCourses);
            this.Controls.Add(this.btnRemoveFromFavourites);
            this.Name = "FavouritesForm";
            this.Text = "FavouritesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavouritesCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveFromFavourites;
        private System.Windows.Forms.DataGridView dataGridViewFavouritesCourses;
        private System.Windows.Forms.Label label1;
    }
}