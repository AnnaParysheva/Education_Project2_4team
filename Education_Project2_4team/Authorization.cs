using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Education_Project2_4team;

namespace Education_Project2_4team
{
    public partial class Authorization : Form
    {
        ApplicationContext db;
        public event Action<User> UserSaved;
        public Authorization()
        {
            InitializeComponent();
            db = new ApplicationContext();
            this.txtBoxPassword.AutoSize = false;
            this.txtBoxPassword.Size = new Size(this.txtBoxPassword.Size.Width, 50);

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogInAsACustomer_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }
    }
}
