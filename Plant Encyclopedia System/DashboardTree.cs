using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plant_Encyclopedia_Systemm
{
    public partial class DashboardTree : Form
    {

        private DataAccess dsh1 { get; set; }
        public DashboardTree()
        {
            InitializeComponent();
            this.dsh1 = new DataAccess();
            this.PopulateGridView();
        }
        void PopulateGridView(string sql="select * from DashboardTree")
        {
            try
            {
                DataSet ds = this.dsh1.ExecuteQuery(sql);
                this.dgvDashboard.AutoGenerateColumns = false;
                this.dgvDashboard.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }
        /*private void btnDSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtDName.Text) || String.IsNullOrEmpty(this.txtDScName.Text) ||
                    String.IsNullOrEmpty(this.txtDKingdom.Text) || String.IsNullOrEmpty(this.txtDClass.Text) ||
                    String.IsNullOrEmpty(this.txtDSpecies.Text) || String.IsNullOrEmpty(this.txtDFoundingYear.Text) ||
                   String.IsNullOrEmpty(this.txtDFoundingAddress.Text))
                {
                    MessageBox.Show("Please Fill All Information!! ");
                    return;
                }
                var sql = "insert into DashboardTree values('" + this.txtDName.Text + "','" + this.txtDScName.Text + "'," +
                    this.txtDKingdom.Text + "'," + this.txtDClass.Text + "'," + this.txtDSpecies.Text + "'," + this.txtDFoundingYear + ","
                    + this.txtDFoundingAddress.Text + "')";
                int count = this.dsh1.ExecuteDML(sql);
                if (count == 1)
                {
                    MessageBox.Show("Data inserted");


                }
                else
                {
                    MessageBox.Show("Data Inserted Failed!!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!!");
            }


        }*/


        private void btnDClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void ClearContent()
        {
            this.txtDName.Text = "";
            this.txtDScName.Text = "";
            this.txtDKingdom.Text = "";
            this.txtDClass.Text = "";
            this.txtDSpecies.Text = "";
            this.txtDFoundingYear.Text = "";
            this.txtDFoundingAddress.Text = "";
            this.txtDName.ReadOnly = false;
            this.txtTreeSearchBox.Clear();
            this.txtAutoSearchPlant.Clear();
        }

        /*private void btnDeleteDash_Click(object sender, EventArgs e)
        {

            try
            {
                var Name = this.dgvDashboard.CurrentRow.Cells[0].Value.ToString();
                string sql = "delete from DashboardTree where T_Name='" + txtDName + "';";
                int count = this.dsh1.ExecuteDML(sql);
                if (count == 1)
                {
                    MessageBox.Show("Plant Encyclopedia:" + txtDName + "has been deleted");
                }
                else
                {
                    MessageBox.Show("Delete Failed!");
                }
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error:" + exc.Message);

            }
        }*/





        private void btnTreeDone_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Signing Out! ");
            Home h1 = new Home();
            h1.Visible = true;
        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {

                string sql = "select * from DashboardTree where T_Name ='" + this.txtTreeSearchBox.Text + "'; ";
               this.PopulateGridView(sql);
    
        }

        private void btnDShowAll_Click(object sender, EventArgs e)
        {

              
                this.PopulateGridView();
        }

        private void txtAutoSearchPlant_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from DashboardTree where T_Name like '" + this.txtAutoSearchPlant.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnDSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if (String.IsNullOrEmpty(this.txtDName.Text) || String.IsNullOrEmpty(this.txtDScName.Text) ||
                  String.IsNullOrEmpty(this.txtDKingdom.Text) || String.IsNullOrEmpty(this.txtDClass.Text) ||
                  String.IsNullOrEmpty(this.txtDSpecies.Text) || String.IsNullOrEmpty(this.txtDFoundingYear.Text) ||
                   String.IsNullOrEmpty(this.txtDFoundingAddress.Text))
                {
                    MessageBox.Show("Please Fill All Information!! ");
                    return;
                }

                var query = "select * from DashboardTree where T_Name='" + this.txtDName.Text + "';";
                DataTable dt = this.dsh1.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    string sql = "update DashboardTree set T_SName = '" + this.txtDScName.Text + "',T_Kingdom = '" + this.txtDKingdom.Text + "',T_Class = '" + this.txtDClass.Text + "',T_Species = '" + this.txtDSpecies.Text + "',T_FoundYear = '" + this.txtDFoundingYear.Text + "',T_FoundAddress = '" + this.txtDFoundingAddress.Text + "' where T_Name = '" + this.txtDName.Text + "'; ";
                    int count = this.dsh1.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Updated !");
                    }
                    else
                    {
                        MessageBox.Show("Data Upgradation failed !");
                    }    
                }

                else 
                {
                    string sql = "insert into DashboardTree values('" + this.txtDName.Text + "','" + this.txtDScName.Text + "','" +
                        this.txtDKingdom.Text + "','" + this.txtDClass.Text + "','" + this.txtDSpecies.Text + "','" + this.txtDFoundingYear + "','"
                        + this.txtDFoundingAddress.Text + "');";
                    int count = this.dsh1.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Inserted !");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed !");
                    }
                    
                }
                this.PopulateGridView();
                this.ClearContent();


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }

        }

        private void btnDeleteDash_Click(object sender, EventArgs e)
        {
            try
            {
                string TName = this.dgvDashboard.CurrentRow.Cells["T_Name"].Value.ToString();    //Dictionary implemented!
                string TSName = this.dgvDashboard.CurrentRow.Cells["T_SName"].Value.ToString();

                string sql = "delete from DashboardTree where T_Name = '" + TName + "';";

                int count = this.dsh1.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Plant "+TName+" Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Plant deletion failed !");
                }
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc.Message);
            }
        }

        private void dgvDashboard_DoubleClick(object sender, EventArgs e)
        {
            this.txtDName.Text = this.dgvDashboard.CurrentRow.Cells[0].Value.ToString();
            this.txtDScName.Text = this.dgvDashboard.CurrentRow.Cells[1].Value.ToString();
            this.txtDKingdom.Text = this.dgvDashboard.CurrentRow.Cells[2].Value.ToString();
            this.txtDClass.Text = this.dgvDashboard.CurrentRow.Cells[3].Value.ToString();
            this.txtDSpecies.Text = this.dgvDashboard.CurrentRow.Cells[4].Value.ToString();
            this.txtDFoundingYear.Text = this.dgvDashboard.CurrentRow.Cells[5].Value.ToString();
            this.txtDFoundingAddress.Text = this.dgvDashboard.CurrentRow.Cells[6].Value.ToString();
            this.txtDName.ReadOnly = true;
        }
    }
}


