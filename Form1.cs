using ClassesGradeApp.Models;
using ClassesGradeApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesGradeApp
{
    public partial class Form1 : Form
    {
        // repository instantiated once
        private readonly IGradeRepository _gradeRepo;

        private bool isPanelVisible = false;
        private int panelWidth;
        private int hiddenXPosition;
        private int shownXPosition;
        private int selectedGradeId = -1;
        public Form1()
        {
            InitializeComponent();

            datagridviewgrades.ReadOnly = true; // Make DataGridView read-only
            datagridviewgrades.RowHeadersVisible = false; // Hide row headers
            datagridviewgrades.AllowUserToAddRows = false; // Disable adding new rows
            datagridviewgrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridviewgrades.MultiSelect = true;
            datagridviewgrades.DataBindingComplete += dataGridViewGrades_DataBindingComplete;

            cmbFilter.Items.Add("GradeName");
            cmbFilter.Items.Add("Description");
            cmbFilter.SelectedIndex = 0;

            _gradeRepo = new SqlGradeRepository();

            panelWidth = panelshowgrades.Width;
            hiddenXPosition = this.Width; // panel starts hidden off screen
            shownXPosition = this.Width - panelWidth;


            datagridviewgrades.SelectionChanged += dataGridViewGrades_SelectionChanged; // it is for displaying selected row data in textboxes
            // Initial position - hidden
            panelshowgrades.Left = hiddenXPosition;
            panelshowgrades.Top = 0;

            timerslide.Tick += timerSlide_Tick;

            checkBoxgetalldata.CheckedChanged += checkBoxgetalldata_CheckedChanged; // to show/hide all data in DataGridView

            txtsearch.TextChanged += txtSearch_TextChanged; // to search by GradeName and Descrioption in DataGridView
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // Basic validation (optional)
            if (string.IsNullOrWhiteSpace(txtgradename.Text))
            {
                MessageBox.Show("Grade Name is required.");
                return;
            }

            // no validation as per your preference; you can add if needed
            var grade = new Grade
            {
                GradeName = txtgradename.Text.Trim(),
                Description = txtdescription.Text.Trim(),
                ActiveStatus = checkboxactiveststus.Checked,
                IsDeleted = checkboxisdeleted.Checked,
                CreatedBy = txtcreatedby.Text.Trim(),
                ModifiedBy = txtmodifiedby.Text.Trim()
            };

            try
            {
                _gradeRepo.AddGrade(grade);
                MessageBox.Show("Record added successfully.");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtgradename.Clear();
            txtdescription.Clear();
            checkboxactiveststus.Checked = false;
            checkboxisdeleted.Checked = false;
            txtcreatedby.Clear();
            txtmodifiedby.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (!isPanelVisible)
            {
                // Slide in from right
                if (panelshowgrades.Left > shownXPosition)
                {
                    panelshowgrades.Left -= 20;
                }
                else
                {
                    panelshowgrades.Left = shownXPosition;
                    timerslide.Stop();
                    isPanelVisible = true;
                    btnshow.Enabled = false; // Disable show button when panel is visible
                }
            }
            else
            {
                // Slide out to right
                if (panelshowgrades.Left < hiddenXPosition)
                {
                    panelshowgrades.Left += 20;
                }
                else
                {
                    panelshowgrades.Left = hiddenXPosition;
                    timerslide.Stop();
                    isPanelVisible = false;
                    btnshow.Enabled = true; // Enable show button when panel is hidden
                }
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            timerslide.Start();
            var dt = _gradeRepo.GetAll();
            datagridviewgrades.DataSource = dt;
            // Only show these columns
            datagridviewgrades.Columns["GradeId"].Visible = true;
            datagridviewgrades.Columns["GradeName"].Visible = true;
            datagridviewgrades.Columns["Description"].Visible = true;

            // Hide these columns
            datagridviewgrades.Columns["ActiveStatus"].Visible = false;
            datagridviewgrades.Columns["CreatedBy"].Visible = false;
            datagridviewgrades.Columns["ModifiedBy"].Visible = false;
            datagridviewgrades.Columns["IsDeleted"].Visible = false;
            datagridviewgrades.Columns["CreatedDate"].Visible = false;
            datagridviewgrades.Columns["ModifiedDate"].Visible = false;
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            panelshowgrades.Visible = true;
            timerslide.Start();

        }

        //private void LoadGrades()
        //{
        //    string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT GradeID, GradeName, Description, ActiveStatus, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate FROM dbo.MstGrades";

        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);

        //        datagridviewgrades.DataSource = table;

        //        // Only show these columns
        //        datagridviewgrades.Columns["GradeId"].Visible = true;
        //        datagridviewgrades.Columns["GradeName"].Visible = true;
        //        datagridviewgrades.Columns["Description"].Visible = true;

        //        // Hide these columns
        //        datagridviewgrades.Columns["ActiveStatus"].Visible = false;
        //        datagridviewgrades.Columns["CreatedBy"].Visible = false;
        //        datagridviewgrades.Columns["ModifiedBy"].Visible = false;
        //        datagridviewgrades.Columns["IsDeleted"].Visible = false;
        //        datagridviewgrades.Columns["CreatedDate"].Visible = false;
        //        datagridviewgrades.Columns["ModifiedDate"].Visible = false;


        //    }
        //}
        private void dataGridViewGrades_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridviewgrades.SelectedRows.Count == 0)
                return;

            var row = datagridviewgrades.SelectedRows[0];
            if (row.Cells["GradeID"].Value == null)
                return;

            selectedGradeId = Convert.ToInt32(row.Cells["GradeID"].Value);
            txtgradename.Text = row.Cells["GradeName"].Value?.ToString() ?? "";
            txtdescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
            checkboxactiveststus.Checked = row.Cells["ActiveStatus"].Value is bool b && b;

            txtcreatedby.Text = row.Cells["CreatedBy"].Value?.ToString() ?? "";

            txtmodifiedby.Text = row.Cells["ModifiedBy"].Value?.ToString() ?? "";

            checkboxisdeleted.Checked = row.Cells["IsDeleted"].Value is bool a && a;
        }

        private void SelectLastRealRow()
        {
            if (datagridviewgrades.Rows.Count == 0) return;

            int lastIndex = datagridviewgrades.Rows.Count - 1;

            // If the last row is the placeholder new row, step back
            if (datagridviewgrades.AllowUserToAddRows && datagridviewgrades.Rows[lastIndex].IsNewRow)
            {
                lastIndex--;
            }

            if (lastIndex < 0) return;

            datagridviewgrades.ClearSelection();
            datagridviewgrades.Rows[lastIndex].Selected = true;
            datagridviewgrades.FirstDisplayedScrollingRowIndex = lastIndex;
        }
        private void dataGridViewGrades_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SelectLastRealRow();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectedGradeId < 0)
            {
                MessageBox.Show("Please select a grade to update.");
                return;
            }
            var grade = new Grade
            {
                GradeID = selectedGradeId,
                GradeName = txtgradename.Text.Trim(),
                Description = txtdescription.Text.Trim(),
                ActiveStatus = checkboxactiveststus.Checked,
                IsDeleted = checkboxisdeleted.Checked,
                CreatedBy = txtcreatedby.Text.Trim(),
                ModifiedBy = txtmodifiedby.Text.Trim()
            };
            try
            {
                _gradeRepo.UpdateGrade(grade);
                MessageBox.Show("Record updated successfully.");
                ClearForm();
                selectedGradeId = -1; // Reset selected ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedGradeId < 0)
            {
                MessageBox.Show("Please select a grade to delete.");
                return;
            }
            try
            {
                _gradeRepo.DeleteGrade(selectedGradeId);
                MessageBox.Show("Record deleted successfully.");
                ClearForm();
                selectedGradeId = -1; // Reset selected ID
                //LoadGrades(); // Refresh the grid after deletion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBoxgetalldata_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBoxgetalldata.Checked;

            if (datagridviewgrades.Columns.Contains("ActiveStatus"))
                datagridviewgrades.Columns["ActiveStatus"].Visible = show;
            if (datagridviewgrades.Columns.Contains("CreatedBy"))
                datagridviewgrades.Columns["CreatedBy"].Visible = show;
            if (datagridviewgrades.Columns.Contains("ModifiedBy"))
                datagridviewgrades.Columns["ModifiedBy"].Visible = show;
            if (datagridviewgrades.Columns.Contains("IsDeleted"))
                datagridviewgrades.Columns["IsDeleted"].Visible = show;
            if (datagridviewgrades.Columns.Contains("CreatedDate"))
                datagridviewgrades.Columns["CreatedDate"].Visible = show;
            if (datagridviewgrades.Columns.Contains("ModifiedDate"))
                datagridviewgrades.Columns["ModifiedDate"].Visible = show;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)datagridviewgrades.DataSource;
            if (dt != null)
            {
                string filterColumn = cmbFilter.SelectedItem.ToString();
                string searchValue = txtsearch.Text.Replace("'", "''"); // Escape quotes

                if (!string.IsNullOrEmpty(searchValue))
                    dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterColumn, searchValue);
                else
                    dt.DefaultView.RowFilter = ""; // Show all if empty
            }
        }

    }
}