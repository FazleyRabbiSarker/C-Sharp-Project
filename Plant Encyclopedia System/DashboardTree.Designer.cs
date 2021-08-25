
namespace Plant_Encyclopedia_Systemm
{
    partial class DashboardTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardTree));
            this.btnDShowAll = new System.Windows.Forms.Button();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.T_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Kingdom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_FoundYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_FoundAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteDash = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDClear = new System.Windows.Forms.Button();
            this.btnDSave = new System.Windows.Forms.Button();
            this.txtDFoundingAddress = new System.Windows.Forms.TextBox();
            this.txtDClass = new System.Windows.Forms.TextBox();
            this.txtDKingdom = new System.Windows.Forms.TextBox();
            this.txtDScName = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.btnDSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTreeSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnTreeDone = new System.Windows.Forms.Button();
            this.txtDFoundingYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDSpecies = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAutoSearchPlant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDShowAll
            // 
            this.btnDShowAll.Location = new System.Drawing.Point(339, 70);
            this.btnDShowAll.Name = "btnDShowAll";
            this.btnDShowAll.Size = new System.Drawing.Size(115, 23);
            this.btnDShowAll.TabIndex = 1;
            this.btnDShowAll.Text = "Show All Plants";
            this.btnDShowAll.UseVisualStyleBackColor = true;
            this.btnDShowAll.Click += new System.EventHandler(this.btnDShowAll_Click);
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AllowUserToAddRows = false;
            this.dgvDashboard.AllowUserToDeleteRows = false;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T_Name,
            this.T_SName,
            this.T_Kingdom,
            this.T_Class,
            this.T_Species,
            this.T_FoundYear,
            this.T_FoundAddress});
            this.dgvDashboard.Location = new System.Drawing.Point(3, 104);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.ReadOnly = true;
            this.dgvDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashboard.Size = new System.Drawing.Size(779, 341);
            this.dgvDashboard.TabIndex = 0;
            this.dgvDashboard.DoubleClick += new System.EventHandler(this.dgvDashboard_DoubleClick);
            // 
            // T_Name
            // 
            this.T_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T_Name.DataPropertyName = "T_Name";
            this.T_Name.HeaderText = "Plant Name";
            this.T_Name.Name = "T_Name";
            this.T_Name.ReadOnly = true;
            // 
            // T_SName
            // 
            this.T_SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T_SName.DataPropertyName = "T_SName";
            this.T_SName.HeaderText = "Scientific Name";
            this.T_SName.Name = "T_SName";
            this.T_SName.ReadOnly = true;
            // 
            // T_Kingdom
            // 
            this.T_Kingdom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T_Kingdom.DataPropertyName = "T_Kingdom";
            this.T_Kingdom.HeaderText = "Kingdom";
            this.T_Kingdom.Name = "T_Kingdom";
            this.T_Kingdom.ReadOnly = true;
            // 
            // T_Class
            // 
            this.T_Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T_Class.DataPropertyName = "T_Class";
            this.T_Class.HeaderText = "Class";
            this.T_Class.Name = "T_Class";
            this.T_Class.ReadOnly = true;
            // 
            // T_Species
            // 
            this.T_Species.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T_Species.DataPropertyName = "T_Species";
            this.T_Species.HeaderText = "Species";
            this.T_Species.Name = "T_Species";
            this.T_Species.ReadOnly = true;
            // 
            // T_FoundYear
            // 
            this.T_FoundYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T_FoundYear.DataPropertyName = "T_FoundYear";
            this.T_FoundYear.HeaderText = "Founding Year";
            this.T_FoundYear.Name = "T_FoundYear";
            this.T_FoundYear.ReadOnly = true;
            this.T_FoundYear.Visible = false;
            // 
            // T_FoundAddress
            // 
            this.T_FoundAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T_FoundAddress.DataPropertyName = "T_FoundAddress";
            this.T_FoundAddress.HeaderText = "Founding Address";
            this.T_FoundAddress.Name = "T_FoundAddress";
            this.T_FoundAddress.ReadOnly = true;
            // 
            // btnDeleteDash
            // 
            this.btnDeleteDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDash.Location = new System.Drawing.Point(202, 314);
            this.btnDeleteDash.Name = "btnDeleteDash";
            this.btnDeleteDash.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDash.TabIndex = 4;
            this.btnDeleteDash.Text = "Delete";
            this.btnDeleteDash.UseVisualStyleBackColor = true;
            this.btnDeleteDash.Click += new System.EventHandler(this.btnDeleteDash_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "New Plant Information";
            // 
            // btnDClear
            // 
            this.btnDClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDClear.Location = new System.Drawing.Point(108, 314);
            this.btnDClear.Name = "btnDClear";
            this.btnDClear.Size = new System.Drawing.Size(75, 23);
            this.btnDClear.TabIndex = 1;
            this.btnDClear.Text = "Clear";
            this.btnDClear.UseVisualStyleBackColor = true;
            this.btnDClear.Click += new System.EventHandler(this.btnDClear_Click);
            // 
            // btnDSave
            // 
            this.btnDSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSave.Location = new System.Drawing.Point(12, 314);
            this.btnDSave.Name = "btnDSave";
            this.btnDSave.Size = new System.Drawing.Size(75, 23);
            this.btnDSave.TabIndex = 1;
            this.btnDSave.Text = "Save";
            this.btnDSave.UseVisualStyleBackColor = true;
            this.btnDSave.Click += new System.EventHandler(this.btnDSave_Click);
            // 
            // txtDFoundingAddress
            // 
            this.txtDFoundingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDFoundingAddress.Location = new System.Drawing.Point(166, 276);
            this.txtDFoundingAddress.Name = "txtDFoundingAddress";
            this.txtDFoundingAddress.Size = new System.Drawing.Size(100, 21);
            this.txtDFoundingAddress.TabIndex = 1;
            // 
            // txtDClass
            // 
            this.txtDClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDClass.Location = new System.Drawing.Point(166, 170);
            this.txtDClass.Name = "txtDClass";
            this.txtDClass.Size = new System.Drawing.Size(100, 21);
            this.txtDClass.TabIndex = 1;
            // 
            // txtDKingdom
            // 
            this.txtDKingdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDKingdom.Location = new System.Drawing.Point(166, 137);
            this.txtDKingdom.Name = "txtDKingdom";
            this.txtDKingdom.Size = new System.Drawing.Size(100, 21);
            this.txtDKingdom.TabIndex = 1;
            // 
            // txtDScName
            // 
            this.txtDScName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDScName.Location = new System.Drawing.Point(166, 101);
            this.txtDScName.Name = "txtDScName";
            this.txtDScName.Size = new System.Drawing.Size(100, 21);
            this.txtDScName.TabIndex = 1;
            // 
            // txtDName
            // 
            this.txtDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDName.Location = new System.Drawing.Point(166, 65);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(100, 21);
            this.txtDName.TabIndex = 1;
            // 
            // btnDSearch
            // 
            this.btnDSearch.Location = new System.Drawing.Point(246, 70);
            this.btnDSearch.Name = "btnDSearch";
            this.btnDSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDSearch.TabIndex = 1;
            this.btnDSearch.Text = "Search";
            this.btnDSearch.UseVisualStyleBackColor = true;
            this.btnDSearch.Click += new System.EventHandler(this.btnDSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Founding Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kingdom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // txtTreeSearchBox
            // 
            this.txtTreeSearchBox.Location = new System.Drawing.Point(37, 70);
            this.txtTreeSearchBox.Name = "txtTreeSearchBox";
            this.txtTreeSearchBox.Size = new System.Drawing.Size(174, 20);
            this.txtTreeSearchBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(37, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plant Encyclopedia!";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashboard.Controls.Add(this.btnTreeDone);
            this.pnlDashboard.Controls.Add(this.txtDFoundingYear);
            this.pnlDashboard.Controls.Add(this.label8);
            this.pnlDashboard.Controls.Add(this.txtDSpecies);
            this.pnlDashboard.Controls.Add(this.label9);
            this.pnlDashboard.Controls.Add(this.btnDeleteDash);
            this.pnlDashboard.Controls.Add(this.label10);
            this.pnlDashboard.Controls.Add(this.btnDClear);
            this.pnlDashboard.Controls.Add(this.btnDSave);
            this.pnlDashboard.Controls.Add(this.txtDFoundingAddress);
            this.pnlDashboard.Controls.Add(this.txtDClass);
            this.pnlDashboard.Controls.Add(this.txtDKingdom);
            this.pnlDashboard.Controls.Add(this.txtDScName);
            this.pnlDashboard.Controls.Add(this.txtDName);
            this.pnlDashboard.Controls.Add(this.label7);
            this.pnlDashboard.Controls.Add(this.label6);
            this.pnlDashboard.Controls.Add(this.label5);
            this.pnlDashboard.Controls.Add(this.label4);
            this.pnlDashboard.Controls.Add(this.label3);
            this.pnlDashboard.Location = new System.Drawing.Point(834, 43);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(305, 402);
            this.pnlDashboard.TabIndex = 2;
            // 
            // btnTreeDone
            // 
            this.btnTreeDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeDone.Location = new System.Drawing.Point(108, 367);
            this.btnTreeDone.Name = "btnTreeDone";
            this.btnTreeDone.Size = new System.Drawing.Size(75, 23);
            this.btnTreeDone.TabIndex = 9;
            this.btnTreeDone.Text = "Sign Out";
            this.btnTreeDone.UseVisualStyleBackColor = true;
            this.btnTreeDone.Click += new System.EventHandler(this.btnTreeDone_Click_1);
            // 
            // txtDFoundingYear
            // 
            this.txtDFoundingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDFoundingYear.Location = new System.Drawing.Point(166, 241);
            this.txtDFoundingYear.Name = "txtDFoundingYear";
            this.txtDFoundingYear.Size = new System.Drawing.Size(100, 21);
            this.txtDFoundingYear.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Founding Year";
            // 
            // txtDSpecies
            // 
            this.txtDSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSpecies.Location = new System.Drawing.Point(166, 204);
            this.txtDSpecies.Name = "txtDSpecies";
            this.txtDSpecies.Size = new System.Drawing.Size(100, 21);
            this.txtDSpecies.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Scientific Name:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtAutoSearchPlant);
            this.panel1.Controls.Add(this.txtTreeSearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlDashboard);
            this.panel1.Controls.Add(this.btnDShowAll);
            this.panel1.Controls.Add(this.btnDSearch);
            this.panel1.Controls.Add(this.dgvDashboard);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 473);
            this.panel1.TabIndex = 1;
            // 
            // txtAutoSearchPlant
            // 
            this.txtAutoSearchPlant.Location = new System.Drawing.Point(485, 73);
            this.txtAutoSearchPlant.Name = "txtAutoSearchPlant";
            this.txtAutoSearchPlant.Size = new System.Drawing.Size(172, 20);
            this.txtAutoSearchPlant.TabIndex = 5;
            this.txtAutoSearchPlant.TextChanged += new System.EventHandler(this.txtAutoSearchPlant_TextChanged);
            // 
            // DashboardTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 501);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardTree";
            this.Text = "DashboardTree";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDShowAll;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDClear;
        private System.Windows.Forms.Button btnDSave;
        private System.Windows.Forms.TextBox txtDFoundingAddress;
        private System.Windows.Forms.TextBox txtDClass;
        private System.Windows.Forms.TextBox txtDKingdom;
        private System.Windows.Forms.TextBox txtDScName;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Button btnDSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTreeSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Button btnDeleteDash;
        private System.Windows.Forms.TextBox txtDFoundingYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDSpecies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTreeDone;
        private System.Windows.Forms.TextBox txtAutoSearchPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Kingdom;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_FoundYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_FoundAddress;
    }
}