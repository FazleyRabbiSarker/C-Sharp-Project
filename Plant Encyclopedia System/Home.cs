using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plant_Encyclopedia_Systemm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

      
        private void btnSignup_Click(object sender, EventArgs e)
        {
            {
                Login l1 = new Login();
                l1.Visible = true;
            }
        }
    }
}
