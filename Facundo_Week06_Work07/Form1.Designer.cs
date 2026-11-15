namespace Facundo_Week06_Work07
{
    partial class frmManager
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmbItemStatus = new System.Windows.Forms.ComboBox();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblAddEquipment = new System.Windows.Forms.Label();
            this.lblAssetTag = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.AssetTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(537, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearch.Size = new System.Drawing.Size(115, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(103, 78);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(413, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Navy;
            this.lblSearch.Location = new System.Drawing.Point(17, 78);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 19);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblHeader.Location = new System.Drawing.Point(0, -1);
            this.lblHeader.MinimumSize = new System.Drawing.Size(800, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(15);
            this.lblHeader.Size = new System.Drawing.Size(800, 59);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Equipment Manager";
            // 
            // cmbItemStatus
            // 
            this.cmbItemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemStatus.FormattingEnabled = true;
            this.cmbItemStatus.Location = new System.Drawing.Point(241, 298);
            this.cmbItemStatus.Name = "cmbItemStatus";
            this.cmbItemStatus.Size = new System.Drawing.Size(290, 24);
            this.cmbItemStatus.TabIndex = 6;
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.AutoSize = true;
            this.lblItemStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblItemStatus.Location = new System.Drawing.Point(17, 305);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(174, 19);
            this.lblItemStatus.TabIndex = 7;
            this.lblItemStatus.Text = "Selected item status:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnShow.Location = new System.Drawing.Point(661, 73);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(2);
            this.btnShow.Size = new System.Drawing.Size(115, 33);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateStatus.Location = new System.Drawing.Point(607, 293);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Padding = new System.Windows.Forms.Padding(2);
            this.btnUpdateStatus.Size = new System.Drawing.Size(115, 33);
            this.btnUpdateStatus.TabIndex = 10;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // lblAddEquipment
            // 
            this.lblAddEquipment.AutoSize = true;
            this.lblAddEquipment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblAddEquipment.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEquipment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddEquipment.Location = new System.Drawing.Point(17, 340);
            this.lblAddEquipment.MinimumSize = new System.Drawing.Size(760, 0);
            this.lblAddEquipment.Name = "lblAddEquipment";
            this.lblAddEquipment.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblAddEquipment.Size = new System.Drawing.Size(760, 25);
            this.lblAddEquipment.TabIndex = 11;
            this.lblAddEquipment.Text = "Add Equipment";
            // 
            // lblAssetTag
            // 
            this.lblAssetTag.AutoSize = true;
            this.lblAssetTag.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetTag.ForeColor = System.Drawing.Color.Navy;
            this.lblAssetTag.Location = new System.Drawing.Point(17, 377);
            this.lblAssetTag.Name = "lblAssetTag";
            this.lblAssetTag.Size = new System.Drawing.Size(92, 19);
            this.lblAssetTag.TabIndex = 12;
            this.lblAssetTag.Text = "Asset Tag:";
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipment.ForeColor = System.Drawing.Color.Navy;
            this.lblEquipment.Location = new System.Drawing.Point(214, 377);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(99, 19);
            this.lblEquipment.TabIndex = 13;
            this.lblEquipment.Text = "Equipment:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Navy;
            this.lblCategory.Location = new System.Drawing.Point(408, 377);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(87, 19);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Category:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Navy;
            this.lblLocation.Location = new System.Drawing.Point(603, 377);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 19);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location:";
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetTag,
            this.Equipment,
            this.Category,
            this.Location,
            this.Status});
            this.dgvEquipment.Location = new System.Drawing.Point(21, 133);
            this.dgvEquipment.MultiSelect = false;
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.ReadOnly = true;
            this.dgvEquipment.RowHeadersWidth = 51;
            this.dgvEquipment.RowTemplate.Height = 24;
            this.dgvEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipment.Size = new System.Drawing.Size(755, 147);
            this.dgvEquipment.TabIndex = 0;
            // 
            // AssetTag
            // 
            this.AssetTag.HeaderText = "Asset Tag";
            this.AssetTag.MinimumWidth = 6;
            this.AssetTag.Name = "AssetTag";
            this.AssetTag.ReadOnly = true;
            // 
            // Equipment
            // 
            this.Equipment.HeaderText = "Equipment";
            this.Equipment.MinimumWidth = 6;
            this.Equipment.Name = "Equipment";
            this.Equipment.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddEquipment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddEquipment.Location = new System.Drawing.Point(636, 452);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddEquipment.Size = new System.Drawing.Size(140, 33);
            this.btnAddEquipment.TabIndex = 16;
            this.btnAddEquipment.Text = "+ Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Location = new System.Drawing.Point(21, 411);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(170, 22);
            this.txtAssetTag.TabIndex = 17;
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(214, 411);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(170, 22);
            this.txtEquipment.TabIndex = 18;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(412, 411);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(170, 22);
            this.txtCategory.TabIndex = 19;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(607, 411);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(170, 22);
            this.txtLocation.TabIndex = 20;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.txtAssetTag);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.lblAssetTag);
            this.Controls.Add(this.lblAddEquipment);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblItemStatus);
            this.Controls.Add(this.cmbItemStatus);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvEquipment);
            this.Name = "frmManager";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Text = "Equipment Manager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cmbItemStatus;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblAddEquipment;
        private System.Windows.Forms.Label lblAssetTag;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

