
namespace Plant_Encyclopedia_Systemm
{
    partial class Member1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member1));
            this.btnMemberDone = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAutoMemberSearch = new System.Windows.Forms.TextBox();
            this.dgvMemberinfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.btnShowAllMember = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMemberDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMemberClear = new System.Windows.Forms.Button();
            this.btnMemberSave = new System.Windows.Forms.Button();
            this.txtMemberPhone = new System.Windows.Forms.TextBox();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.txtMemberPassword = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.M_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberinfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMemberDone
            // 
            this.btnMemberDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberDone.Location = new System.Drawing.Point(24, 323);
            this.btnMemberDone.Name = "btnMemberDone";
            this.btnMemberDone.Size = new System.Drawing.Size(75, 23);
            this.btnMemberDone.TabIndex = 23;
            this.btnMemberDone.Text = "Done";
            this.btnMemberDone.UseVisualStyleBackColor = true;
            this.btnMemberDone.Click += new System.EventHandler(this.btnMemberDone_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(100, 72);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(124, 22);
            this.txtMemberID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtAutoMemberSearch);
            this.panel3.Controls.Add(this.dgvMemberinfo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(295, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 367);
            this.panel3.TabIndex = 0;
            // 
            // txtAutoMemberSearch
            // 
            this.txtAutoMemberSearch.Location = new System.Drawing.Point(275, 15);
            this.txtAutoMemberSearch.Name = "txtAutoMemberSearch";
            this.txtAutoMemberSearch.Size = new System.Drawing.Size(174, 20);
            this.txtAutoMemberSearch.TabIndex = 9;
            this.txtAutoMemberSearch.TextChanged += new System.EventHandler(this.txtAutoMemberSearch_TextChanged);
            // 
            // dgvMemberinfo
            // 
            this.dgvMemberinfo.AllowUserToAddRows = false;
            this.dgvMemberinfo.AllowUserToDeleteRows = false;
            this.dgvMemberinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_ID,
            this.M_Name,
            this.M_Password,
            this.M_Email,
            this.M_Phone});
            this.dgvMemberinfo.Location = new System.Drawing.Point(3, 42);
            this.dgvMemberinfo.Name = "dgvMemberinfo";
            this.dgvMemberinfo.ReadOnly = true;
            this.dgvMemberinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberinfo.Size = new System.Drawing.Size(571, 312);
            this.dgvMemberinfo.TabIndex = 0;
            this.dgvMemberinfo.DoubleClick += new System.EventHandler(this.dgvMemberinfo_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Member Info";
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(209, 18);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(174, 20);
            this.txtMemberSearch.TabIndex = 8;
            // 
            // btnShowAllMember
            // 
            this.btnShowAllMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllMember.Location = new System.Drawing.Point(819, 49);
            this.btnShowAllMember.Name = "btnShowAllMember";
            this.btnShowAllMember.Size = new System.Drawing.Size(60, 50);
            this.btnShowAllMember.TabIndex = 6;
            this.btnShowAllMember.Text = "Show All";
            this.btnShowAllMember.UseVisualStyleBackColor = true;
            this.btnShowAllMember.Click += new System.EventHandler(this.btnShowAllMember_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(389, 16);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMember.TabIndex = 7;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type for Member Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(497, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 39);
            this.label9.TabIndex = 4;
            this.label9.Text = "Member";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Member Registration";
            // 
            // btnMemberDelete
            // 
            this.btnMemberDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberDelete.Location = new System.Drawing.Point(149, 323);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMemberDelete.TabIndex = 16;
            this.btnMemberDelete.Text = "Delete";
            this.btnMemberDelete.UseVisualStyleBackColor = true;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnShowAllMember);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-47, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 480);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txtMemberSearch);
            this.panel4.Controls.Add(this.btnSearchMember);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(295, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 51);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnMemberDone);
            this.panel2.Controls.Add(this.txtMemberID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnMemberDelete);
            this.panel2.Controls.Add(this.btnMemberClear);
            this.panel2.Controls.Add(this.btnMemberSave);
            this.panel2.Controls.Add(this.txtMemberPhone);
            this.panel2.Controls.Add(this.txtMemberEmail);
            this.panel2.Controls.Add(this.txtMemberPassword);
            this.panel2.Controls.Add(this.txtMemberName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(23, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 388);
            this.panel2.TabIndex = 0;
            // 
            // btnMemberClear
            // 
            this.btnMemberClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberClear.Location = new System.Drawing.Point(149, 277);
            this.btnMemberClear.Name = "btnMemberClear";
            this.btnMemberClear.Size = new System.Drawing.Size(75, 23);
            this.btnMemberClear.TabIndex = 17;
            this.btnMemberClear.Text = "Clear";
            this.btnMemberClear.UseVisualStyleBackColor = true;
            this.btnMemberClear.Click += new System.EventHandler(this.btnMemberClear_Click);
            // 
            // btnMemberSave
            // 
            this.btnMemberSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberSave.Location = new System.Drawing.Point(24, 277);
            this.btnMemberSave.Name = "btnMemberSave";
            this.btnMemberSave.Size = new System.Drawing.Size(75, 23);
            this.btnMemberSave.TabIndex = 14;
            this.btnMemberSave.Text = "Save";
            this.btnMemberSave.UseVisualStyleBackColor = true;
            this.btnMemberSave.Click += new System.EventHandler(this.btnMemberSave_Click);
            // 
            // txtMemberPhone
            // 
            this.txtMemberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPhone.Location = new System.Drawing.Point(100, 222);
            this.txtMemberPhone.Name = "txtMemberPhone";
            this.txtMemberPhone.Size = new System.Drawing.Size(124, 22);
            this.txtMemberPhone.TabIndex = 13;
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberEmail.Location = new System.Drawing.Point(100, 190);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(124, 22);
            this.txtMemberEmail.TabIndex = 19;
            // 
            // txtMemberPassword
            // 
            this.txtMemberPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPassword.Location = new System.Drawing.Point(100, 150);
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.Size = new System.Drawing.Size(124, 22);
            this.txtMemberPassword.TabIndex = 12;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(100, 114);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(124, 22);
            this.txtMemberName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // M_ID
            // 
            this.M_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.M_ID.DataPropertyName = "M_ID";
            this.M_ID.HeaderText = "Member ID";
            this.M_ID.Name = "M_ID";
            this.M_ID.ReadOnly = true;
            // 
            // M_Name
            // 
            this.M_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.M_Name.DataPropertyName = "M_Name";
            this.M_Name.HeaderText = "Member Name";
            this.M_Name.Name = "M_Name";
            this.M_Name.ReadOnly = true;
            // 
            // M_Password
            // 
            this.M_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.M_Password.DataPropertyName = "M_Password";
            this.M_Password.HeaderText = "Member Password";
            this.M_Password.Name = "M_Password";
            this.M_Password.ReadOnly = true;
            this.M_Password.Visible = false;
            // 
            // M_Email
            // 
            this.M_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.M_Email.DataPropertyName = "M_Email";
            this.M_Email.HeaderText = "Member Email";
            this.M_Email.Name = "M_Email";
            this.M_Email.ReadOnly = true;
            // 
            // M_Phone
            // 
            this.M_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.M_Phone.DataPropertyName = "M_Phone";
            this.M_Phone.HeaderText = "Member Phone";
            this.M_Phone.Name = "M_Phone";
            this.M_Phone.ReadOnly = true;
            // 
            // Member1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 470);
            this.Controls.Add(this.panel1);
            this.Name = "Member1";
            this.Text = "Member1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberinfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMemberDone;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAutoMemberSearch;
        private System.Windows.Forms.DataGridView dgvMemberinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Button btnShowAllMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMemberDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMemberClear;
        private System.Windows.Forms.Button btnMemberSave;
        private System.Windows.Forms.TextBox txtMemberPhone;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.TextBox txtMemberPassword;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Phone;
    }
}