using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Project2_4team
{
    public partial class questionnare : Form
    {
        public questionnare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var questionnaireForm = new Courses();
            this.Hide();
            questionnaireForm.ShowDialog();
            this.Close();
        }
    }
}
