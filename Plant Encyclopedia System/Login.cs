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


    public partial class Login : Form
    {

        private DataAccess da1 = new DataAccess();
        private DataSet ds1 { get; set; }
        private string SQLQuery1 { get; set; }
        DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

 



        private void btnNewMember_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Welcome New Member! Please Register now to get Access!");
            Member1 m1 = new Member1();
            m1.Visible = true;
        }

        private void btnNewAdmin_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome new Admin! Please register now!");
            Admin a1 = new Admin();
            a1.Visible = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.cmbUser.Text = "";
            this.txtUserID.Text = "";
            this.txtPassword.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (cmbUser.Text == "Admin")
                {


                    this.SQLQuery1 = @"select * from Admin where A_ID='" + this.txtUserID.Text + "' and A_Password ='" + this.txtPassword.Text + "';";

                    ds1 = this.da1.ExecuteQuery(SQLQuery1);

                    if (ds1.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("Login Successful");
                        DashboardTree an1 = new DashboardTree();
                        an1.Visible = true;
                    }

                }
                else if (cmbUser.Text == "Member")
                {
                    this.SQLQuery1 = @"select * from Member where M_ID='" + this.txtUserID.Text + "' and M_Password ='" + this.txtPassword.Text + "';";

                    ds1 = this.da1.ExecuteQuery(SQLQuery1);

                    if (ds1.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("Login Successful");
                        DashboardTree mn1 = new DashboardTree();
                        mn1.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong User");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }
    }
    
}
