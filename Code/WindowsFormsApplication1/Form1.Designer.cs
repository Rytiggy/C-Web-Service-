namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Instructions = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.cmbOrgType = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.table = new System.Windows.Forms.DataGridView();
            this.OrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.County = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Instructions.SuspendLayout();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.Controls.Add(this.label7);
            this.Instructions.Controls.Add(this.label1);
            this.Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.Location = new System.Drawing.Point(801, 194);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(283, 130);
            this.Instructions.TabIndex = 0;
            this.Instructions.TabStop = false;
            this.Instructions.Text = "Instructions";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Location = new System.Drawing.Point(10, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 70);
            this.label7.TabIndex = 1;
            this.label7.Text = "Select as many parameters to the left as desired, then click search";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox.Controls.Add(this.label6);
            this.SearchBox.Controls.Add(this.label5);
            this.SearchBox.Controls.Add(this.label4);
            this.SearchBox.Controls.Add(this.label3);
            this.SearchBox.Controls.Add(this.cmbCity);
            this.SearchBox.Controls.Add(this.label2);
            this.SearchBox.Controls.Add(this.Search);
            this.SearchBox.Controls.Add(this.cmbCounty);
            this.SearchBox.Controls.Add(this.cmbState);
            this.SearchBox.Controls.Add(this.txbName);
            this.SearchBox.Controls.Add(this.cmbOrgType);
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(178, 154);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(521, 209);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "County: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "State: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "City: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name: ";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(343, 104);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(160, 28);
            this.cmbCity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Org. Type: ";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Snow;
            this.Search.Location = new System.Drawing.Point(343, 153);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(160, 30);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(101, 150);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(160, 28);
            this.cmbCounty.TabIndex = 4;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cmbState.Location = new System.Drawing.Point(101, 101);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(160, 28);
            this.cmbState.TabIndex = 3;
            this.cmbState.Text = "NY";
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(343, 52);
            this.txbName.Name = "txbName";
            this.txbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbName.Size = new System.Drawing.Size(160, 26);
            this.txbName.TabIndex = 1;
            // 
            // cmbOrgType
            // 
            this.cmbOrgType.FormattingEnabled = true;
            this.cmbOrgType.Location = new System.Drawing.Point(101, 52);
            this.cmbOrgType.Name = "cmbOrgType";
            this.cmbOrgType.Size = new System.Drawing.Size(160, 28);
            this.cmbOrgType.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrgID,
            this.Type,
            this.Place,
            this.Email,
            this.City,
            this.Zip,
            this.County,
            this.State});
            this.table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.table.Location = new System.Drawing.Point(12, 420);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1121, 255);
            this.table.TabIndex = 2;
            this.table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellDoubleClick);
            // 
            // OrgID
            // 
            this.OrgID.HeaderText = "OrgID";
            this.OrgID.Name = "OrgID";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "Place";
            this.Place.Name = "Place";
            this.Place.Width = 379;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Zip
            // 
            this.Zip.DataPropertyName = "City";
            this.Zip.HeaderText = "Zip";
            this.Zip.Name = "Zip";
            // 
            // County
            // 
            this.County.DataPropertyName = "County";
            this.County.HeaderText = "County";
            this.County.Name = "County";
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.Width = 98;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1033, 681);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 13);
            this.progressBar.TabIndex = 3;
            this.progressBar.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.logo;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(31, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1090, 90);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 696);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.table);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Instructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Emergency Services Directory ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Instructions.ResumeLayout(false);
            this.Instructions.PerformLayout();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Instructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ComboBox cmbOrgType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn County;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

