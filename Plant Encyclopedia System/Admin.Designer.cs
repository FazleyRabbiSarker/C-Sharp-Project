
namespace Plant_Encyclopedia_Systemm
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminClear = new System.Windows.Forms.Button();
            this.txtAdminSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAutoSearchAdmin = new System.Windows.Forms.TextBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnAdminDone = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdminAddress = new System.Windows.Forms.TextBox();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.btnAdminSave = new System.Windows.Forms.Button();
            this.txtAdminPhone = new System.Windows.Forms.TextBox();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowAllAdmin = new System.Windows.Forms.Button();
            this.dgvAdmininfo = new System.Windows.Forms.DataGridView();
            this.A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmininfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search For Admin Here";
            // 
            // btnAdminClear
            // 
            this.btnAdminClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminClear.Location = new System.Drawing.Point(186, 300);
            this.btnAdminClear.Name = "btnAdminClear";
            this.btnAdminClear.Size = new System.Drawing.Size(75, 23);
            this.btnAdminClear.TabIndex = 1;
            this.btnAdminClear.Text = "Clear";
            this.btnAdminClear.UseVisualStyleBackColor = true;
            this.btnAdminClear.Click += new System.EventHandler(this.btnAdminClear_Click);
            // 
            // txtAdminSearch
            // 
            this.txtAdminSearch.Location = new System.Drawing.Point(545, 113);
            this.txtAdminSearch.Name = "txtAdminSearch";
            this.txtAdminSearch.Size = new System.Drawing.Size(174, 20);
            this.txtAdminSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // btnSearchAdmin
            // 
            this.btnSearchAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAdmin.Location = new System.Drawing.Point(726, 104);
            this.btnSearchAdmin.Name = "btnSearchAdmin";
            this.btnSearchAdmin.Size = new System.Drawing.Size(75, 37);
            this.btnSearchAdmin.TabIndex = 1;
            this.btnSearchAdmin.Text = "Search";
            this.btnSearchAdmin.UseVisualStyleBackColor = true;
            this.btnSearchAdmin.Click += new System.EventHandler(this.btnSearchAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAutoSearchAdmin);
            this.panel1.Controls.Add(this.txtAdminSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlDashboard);
            this.panel1.Controls.Add(this.btnShowAllAdmin);
            this.panel1.Controls.Add(this.btnSearchAdmin);
            this.panel1.Controls.Add(this.dgvAdmininfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 487);
            this.panel1.TabIndex = 2;
            // 
            // txtAutoSearchAdmin
            // 
            this.txtAutoSearchAdmin.Location = new System.Drawing.Point(871, 113);
            this.txtAutoSearchAdmin.Name = "txtAutoSearchAdmin";
            this.txtAutoSearchAdmin.Size = new System.Drawing.Size(174, 20);
            this.txtAutoSearchAdmin.TabIndex = 5;
            this.txtAutoSearchAdmin.TextChanged += new System.EventHandler(this.txtAutoSearchAdmin_TextChanged);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashboard.Controls.Add(this.btnAdminDone);
            this.pnlDashboard.Controls.Add(this.label10);
            this.pnlDashboard.Controls.Add(this.txtAdminAddress);
            this.pnlDashboard.Controls.Add(this.btnAdminClear);
            this.pnlDashboard.Controls.Add(this.btnAdminDelete);
            this.pnlDashboard.Controls.Add(this.btnAdminSave);
            this.pnlDashboard.Controls.Add(this.txtAdminPhone);
            this.pnlDashboard.Controls.Add(this.txtAdminEmail);
            this.pnlDashboard.Controls.Add(this.txtAdminPassword);
            this.pnlDashboard.Controls.Add(this.txtAdminName);
            this.pnlDashboard.Controls.Add(this.txtAdminID);
            this.pnlDashboard.Controls.Add(this.label8);
            this.pnlDashboard.Controls.Add(this.label7);
            this.pnlDashboard.Controls.Add(this.label6);
            this.pnlDashboard.Controls.Add(this.label5);
            this.pnlDashboard.Controls.Add(this.label4);
            this.pnlDashboard.Controls.Add(this.label3);
            this.pnlDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDashboard.Location = new System.Drawing.Point(84, 90);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(298, 380);
            this.pnlDashboard.TabIndex = 2;
            // 
            // btnAdminDone
            // 
            this.btnAdminDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDone.Location = new System.Drawing.Point(186, 337);
            this.btnAdminDone.Name = "btnAdminDone";
            this.btnAdminDone.Size = new System.Drawing.Size(75, 23);
            this.btnAdminDone.TabIndex = 4;
            this.btnAdminDone.Text = "Done";
            this.btnAdminDone.UseVisualStyleBackColor = true;
            this.btnAdminDone.Click += new System.EventHandler(this.btnAdminDone_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Admin Registration";
            // 
            // txtAdminAddress
            // 
            this.txtAdminAddress.Location = new System.Drawing.Point(105, 248);
            this.txtAdminAddress.Name = "txtAdminAddress";
            this.txtAdminAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAdminAddress.TabIndex = 1;
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDelete.Location = new System.Drawing.Point(19, 337);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAdminDelete.TabIndex = 1;
            this.btnAdminDelete.Text = "Delete";
            this.btnAdminDelete.UseVisualStyleBackColor = true;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // btnAdminSave
            // 
            this.btnAdminSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSave.Location = new System.Drawing.Point(19, 300);
            this.btnAdminSave.Name = "btnAdminSave";
            this.btnAdminSave.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSave.TabIndex = 1;
            this.btnAdminSave.Text = "Save";
            this.btnAdminSave.UseVisualStyleBackColor = true;
            this.btnAdminSave.Click += new System.EventHandler(this.btnAdminSave_Click_1);
            // 
            // txtAdminPhone
            // 
            this.txtAdminPhone.Location = new System.Drawing.Point(105, 209);
            this.txtAdminPhone.Name = "txtAdminPhone";
            this.txtAdminPhone.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPhone.TabIndex = 1;
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(105, 177);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(100, 20);
            this.txtAdminEmail.TabIndex = 1;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(105, 137);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPassword.TabIndex = 1;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(105, 101);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(100, 20);
            this.txtAdminName.TabIndex = 1;
            // 
            // txtAdminID
            // 
            this.txtAdminID.Location = new System.Drawing.Point(105, 65);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(100, 20);
            this.txtAdminID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // btnShowAllAdmin
            // 
            this.btnShowAllAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAdmin.Location = new System.Drawing.Point(1093, 102);
            this.btnShowAllAdmin.Name = "btnShowAllAdmin";
            this.btnShowAllAdmin.Size = new System.Drawing.Size(115, 37);
            this.btnShowAllAdmin.TabIndex = 1;
            this.btnShowAllAdmin.Text = "Show All";
            this.btnShowAllAdmin.UseVisualStyleBackColor = true;
            this.btnShowAllAdmin.Click += new System.EventHandler(this.btnShowAllAdmin_Click);
            // 
            // dgvAdmininfo
            // 
            this.dgvAdmininfo.AllowUserToAddRows = false;
            this.dgvAdmininfo.AllowUserToDeleteRows = false;
            this.dgvAdmininfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmininfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_ID,
            this.A_Name,
            this.A_Password,
            this.A_Email,
            this.A_Phone,
            this.A_Address});
            this.dgvAdmininfo.Location = new System.Drawing.Point(461, 147);
            this.dgvAdmininfo.Name = "dgvAdmininfo";
            this.dgvAdmininfo.ReadOnly = true;
            this.dgvAdmininfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmininfo.Size = new System.Drawing.Size(747, 325);
            this.dgvAdmininfo.TabIndex = 0;
            this.dgvAdmininfo.DoubleClick += new System.EventHandler(this.dgvAdmininfo_DoubleClick);
            // 
            // A_ID
            // 
            this.A_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_ID.DataPropertyName = "A_ID";
            this.A_ID.HeaderText = "Admin ID";
            this.A_ID.Name = "A_ID";
            this.A_ID.ReadOnly = true;
            // 
            // A_Name
            // 
            this.A_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Name.DataPropertyName = "A_Name";
            this.A_Name.HeaderText = "Admin Name";
            this.A_Name.Name = "A_Name";
            this.A_Name.ReadOnly = true;
            // 
            // A_Password
            // 
            this.A_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Password.DataPropertyName = "A_Password";
            this.A_Password.HeaderText = "Admin Password";
            this.A_Password.Name = "A_Password";
            this.A_Password.ReadOnly = true;
            // 
            // A_Email
            // 
            this.A_Email.DataPropertyName = "A_Email";
            this.A_Email.HeaderText = "Admin Email";
            this.A_Email.Name = "A_Email";
            this.A_Email.ReadOnly = true;
            // 
            // A_Phone
            // 
            this.A_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Phone.DataPropertyName = "A_Phone";
            this.A_Phone.HeaderText = "Admin Phone";
            this.A_Phone.Name = "A_Phone";
            this.A_Phone.ReadOnly = true;
            // 
            // A_Address
            // 
            this.A_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A_Address.DataPropertyName = "A_Address";
            this.A_Address.HeaderText = "Admin Address";
            this.A_Address.Name = "A_Address";
            this.A_Address.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Chartreuse;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(879, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Auto Search ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 500);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmininfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdminClear;
        private System.Windows.Forms.TextBox txtAdminSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdminAddress;
        private System.Windows.Forms.Button btnAdminDelete;
        private System.Windows.Forms.Button btnAdminSave;
        private System.Windows.Forms.TextBox txtAdminPhone;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowAllAdmin;
        private System.Windows.Forms.DataGridView dgvAdmininfo;
        private System.Windows.Forms.Button btnAdminDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_Address;
        private System.Windows.Forms.TextBox txtAutoSearchAdmin;
        private System.Windows.Forms.Label label9;
    }
}