using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facundo_Week06_Work07
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            dgvEquipment.Rows.Add("EQ-101", "Laptop", "Computer", "Room 204", "Available");
            dgvEquipment.Rows.Add("EQ-102", "Projector", "Audio-Visual", "Library", "Checked Out");
            dgvEquipment.Rows.Add("EQ-103", "Camera", "Media", "Room 108", "Under Maintenance");

            cmbItemStatus.Items.Add("Available");
            cmbItemStatus.Items.Add("Checked Out");
            cmbItemStatus.Items.Add("Under Maintenance");
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvEquipment != null && cmbItemStatus.SelectedIndex != -1)
            {
                dgvEquipment.CurrentRow.Cells[4].Value = cmbItemStatus.Text;
            }
            else {
                MessageBox.Show("Please select an equipment first.");
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            string assetTag = txtAssetTag.Text;
            string equipment = txtEquipment.Text;
            string category = txtCategory.Text;
            string location = txtLocation.Text;

            if (!string.IsNullOrWhiteSpace(assetTag) && !string.IsNullOrWhiteSpace(equipment) )
            {
                dgvEquipment.Rows.Add(assetTag, equipment, category, location, "Available");
                txtAssetTag.Clear();
                txtEquipment.Clear();
                txtCategory.Clear();
                txtLocation.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an asset tag and equipment name.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEquipment.Rows)
            {
                string assetTag = row.Cells[0].Value.ToString();
                string equipment = row.Cells[1].Value.ToString();

                row.Visible = assetTag.ToLower().Contains(txtSearch.Text.ToLower())
                           || equipment.ToLower().Contains(txtSearch.Text.ToLower());
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEquipment.Rows)
            {
                row.Visible = true;
            }
            txtSearch.Clear();
        }
    }
}
