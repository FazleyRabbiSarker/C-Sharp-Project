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
    public partial class Admin : Form
    {
        private DataAccess Da1 { get; set; }
        public Admin()
        {
            InitializeComponent();
            this.Da1 = new DataAccess();
            this.PopulateGridView();
        }
        void PopulateGridView(string sql="select * from Admin")
        {
            try
            {
                DataSet ds = this.Da1.ExecuteQuery(sql);
                this.dgvAdmininfo.AutoGenerateColumns = false;
                this.dgvAdmininfo.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }





        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string AName = this.dgvAdmininfo.CurrentRow.Cells["A_Name"].Value.ToString();

                string sql = "delete from Admin where A_Name = '" + AName + "';";

                int count = this.Da1.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Admin " + AName + " Deleted Successfully.");
                }
                else 
                {
                    MessageBox.Show("Admin cannot be Deleted!");
                }
                this.PopulateGridView();

            }
            catch (Exception exc)            
            {
                MessageBox.Show("Error:" + exc.Message);
                    
            }
        }

        private void btnAdminDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Encyclopedia");
            DashboardTree t1 = new DashboardTree();
            t1.Visible = true;
        }

        private void btnAdminClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void ClearContent()
        {
            this.txtAdminID.Text = "";
            this.txtAdminName.Text = "";
            this.txtAdminPassword.Text = "";
            this.txtAdminEmail.Text = "";
            this.txtAdminPhone.Text = "";
            this.txtAdminAddress.Text = "";
            this.txtAdminID.ReadOnly = false;
            this.txtAdminSearch.Clear();
            this.txtAutoSearchAdmin.Clear();
        }

        private void btnShowAllAdmin_Click(object sender, EventArgs e)
        {
            string sql = "select*from Admin;";
            this.PopulateGridView(sql);

        }

        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            string sql = "select*from Admin where A_ID ='" + this.txtAdminSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearchAdmin_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Admin where A_Name like '" + this.txtAutoSearchAdmin.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnAdminSave_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.txtAdminID.Text) || String.IsNullOrEmpty(this.txtAdminName.Text) ||
                         String.IsNullOrEmpty(this.txtAdminPassword.Text) || String.IsNullOrEmpty(this.txtAdminEmail.Text) ||
                         String.IsNullOrEmpty(this.txtAdminPhone.Text) || String.IsNullOrEmpty(this.txtAdminAddress.Text))
                {
                    MessageBox.Show("Please Fill All Legal Information!!");
                    return;
                }

                var query = "select* from Admin where A_Name='" + this.txtAdminName.Text + "';";
                DataTable dt = this.Da1.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    string sql = @"update Admin set A_Name ='" +this.txtAdminName.Text + "',A_Password='" + this.txtAdminPassword.Text +
                        "',A_Email='" + this.txtAdminEmail.Text + "',A_Phone='" + this.txtAdminPhone.Text + "',A_Address='" + this.txtAdminAddress.Text +
                        "' where A_ID='" + this.txtAdminID.Text + "';";
                    int count = this.Da1.ExecuteDML(sql);

                    if (count == 1)

                    {
                        MessageBox.Show("Admin Data Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin Data Upgradation Failed!!");

                    }
                }
                else 
                {
                    string sql = @"insert into admin values('" + this.txtAdminID.Text + "','" + this.txtAdminName.Text + "','"
                        + this.txtAdminPassword.Text + "','" + this.txtAdminEmail.Text + "','" + this.txtAdminPhone.Text + "','" 
                        + this.txtAdminAddress.Text + "');";
                    int count = this.Da1.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Admin Data Inserted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Admin Data Insertion Failed!!");

                    }

                }
                this.PopulateGridView();
                this.ClearContent();

            }

            catch (Exception exc)
            {
                MessageBox.Show("Error"+ exc.Message);
            }

        }

        private void dgvAdmininfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtAdminID.Text = this.dgvAdmininfo.CurrentRow.Cells[0].Value.ToString();
            this.txtAdminName.Text = this.dgvAdmininfo.CurrentRow.Cells[1].Value.ToString();
            this.txtAdminPassword.Text = this.dgvAdmininfo.CurrentRow.Cells[2].Value.ToString();
            this.txtAdminEmail.Text = this.dgvAdmininfo.CurrentRow.Cells[3].Value.ToString();
            this.txtAdminPhone.Text = this.dgvAdmininfo.CurrentRow.Cells[4].Value.ToString();
            this.txtAdminAddress.Text = this.dgvAdmininfo.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
