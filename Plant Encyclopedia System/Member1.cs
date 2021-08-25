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
    public partial class Member1 : Form
    {
        private DataAccess Da2 { get; set; }
        public Member1()
        {
            InitializeComponent();
            this.Da2 = new DataAccess();
            this.PopulateGridView();
        }

        void PopulateGridView(string sql = "select * from Member")
        {
            try
            {
                DataSet ds = this.Da2.ExecuteQuery(sql);
                this.dgvMemberinfo.AutoGenerateColumns = false;
                this.dgvMemberinfo.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }

        private void btnMemberSave_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (String.IsNullOrEmpty(this.txtMemberID.Text) || String.IsNullOrEmpty(this.txtMemberName.Text) ||
                    String.IsNullOrEmpty(this.txtMemberPassword.Text) || String.IsNullOrEmpty(this.txtMemberEmail.Text) ||
                    String.IsNullOrEmpty(this.txtMemberPhone.Text))
                    {
                        MessageBox.Show("Please Fill All Information");
                        return;
                    }
                    var query = "select * from Member where M_ID = '" + this.txtMemberID.Text + "';";
                    DataTable dt = this.Da2.ExecuteQueryTable(query);
                    if (dt.Rows.Count == 1)
                    {
                        string sql = @"update Member set M_Name='" + this.txtMemberName.Text + "',M_Password='" + this.txtMemberPassword.Text + "'," +
                            " M_Email='" + this.txtMemberEmail.Text + "',M_Phone='" + this.txtMemberPhone.Text + "'" +
                            " where M_ID = " + this.txtMemberID.Text + "; ";

                        int count = this.Da2.ExecuteDML(sql);
                        if (count == 1)
                        {
                            MessageBox.Show("Member Data Updated Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Member Data Upgradation Failed!");
                        }
                    }

                    else
                    {
                        string sql = @"insert into Member values(" + this.txtMemberID.Text + "," +
                            "'" + this.txtMemberName.Text + "','" + this.txtMemberPassword.Text + "','"
                            + this.txtMemberEmail.Text + "','" + this.txtMemberPhone.Text + "');";
                        int count = this.Da2.ExecuteDML(sql);

                        if (count == 1)
                        {
                            MessageBox.Show("Member Data Inserted Succesfully!");
                        }
                        else
                        {
                            MessageBox.Show("Member Data Insertion Failed!");
                        }

                    }
                    this.PopulateGridView();




                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error:" + exc.Message);


                }
            
        }

        private void btnMemberDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome new member!");
            DashboardTree x1 = new DashboardTree();
            x1.Visible = true;
        }

        private void txtAutoMemberSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Member where M_Name like '" + this.txtAutoMemberSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnShowAllMember_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string sql = "select*from Member where M_ID='" + this.txtMemberSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnMemberClear_Click(object sender, EventArgs e)
        {

            this.ClearContent();
        }

        private void ClearContent()
        {
            this.txtMemberID.Text = "";
            this.txtMemberName.Text = "";
            this.txtMemberPassword.Text = "";
            this.txtMemberEmail.Text = "";
            this.txtMemberPhone.Text = "";
            this.txtMemberID.ReadOnly = false;
            this.txtAutoMemberSearch.Clear();
            this.txtMemberSearch.Clear();
        }

        private void dgvMemberinfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtMemberID.Text = this.dgvMemberinfo.CurrentRow.Cells[0].Value.ToString();
            this.txtMemberName.Text = this.dgvMemberinfo.CurrentRow.Cells[1].Value.ToString();
            this.txtMemberPassword.Text = this.dgvMemberinfo.CurrentRow.Cells[2].Value.ToString();
            this.txtMemberEmail.Text = this.dgvMemberinfo.CurrentRow.Cells[3].Value.ToString();
            this.txtMemberPhone.Text = this.dgvMemberinfo.CurrentRow.Cells[4].Value.ToString();
            this.txtMemberID.ReadOnly = true;

        }

        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MName = this.dgvMemberinfo.CurrentRow.Cells["M_Name"].Value.ToString();
                string sql = "delete from Member where M_Name='" + MName + "';";

                int count = this.Da2.ExecuteDML(sql);
                if (count == 1)
                {
                    MessageBox.Show("Member " + MName + " Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Member deletion failed !");
                }
                this.PopulateGridView();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }
    }
}
