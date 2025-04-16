using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class CreateUserControl : UserControl
    {
        public CreateUserControl()
        {
            InitializeComponent();
            SetupEvents();
        }
        private void SetupEvents()
        {
            if (this.radioBtnOnline.Checked)
            {
                radioBtnOnline_CheckedChanged(this, EventArgs.Empty);
            }
            if (this.radioBtnOnline.Checked)
            {
                radioBtnOffline_CheckedChanged(this, EventArgs.Empty);
            }
            btnReset_Click(this, EventArgs.Empty);
        }

        private void CreateUserControl_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioBtnOnline_CheckedChanged(object sender, EventArgs e)
        {
            this.tableLayoutPanelOffline.Enabled = false;
            if (this.tableLayoutPanelOnline.Enabled == false)
            {
                this.tableLayoutPanelOnline.Enabled = true;
            }
        }

        private void radioBtnOffline_CheckedChanged(object sender, EventArgs e)
        {
            this.tableLayoutPanelOnline.Enabled = false;
            if (this.tableLayoutPanelOffline.Enabled == false)
            {
                this.tableLayoutPanelOffline.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtID.ResetText();
            this.txtNameCourse.ResetText();
            this.txtDescription.ResetText();
            this.txtDuration.ResetText();
            this.txtLecturer.ResetText();
            this.txtPriceCourse.ResetText();
            this.dateTimePickerStartDate.ResetText();
            if (this.radioBtnOnline.Checked == true)
            {
                this.radioBtnOnline.Checked = false;
                this.tableLayoutPanelOffline.Enabled = true;
                this.txtPLatform.ResetText();
                this.txtContactInformation.ResetText();
                this.txtRecording.ResetText();
            }
            if (this.radioBtnOffline.Checked == true)
            {
                this.radioBtnOffline.Checked = false;
                this.tableLayoutPanelOnline.Enabled = true;
                this.txtClassroom.ResetText();
                this.txtLocation.ResetText();
                this.txtSchedule.ResetText();
            }
        }
    }
}
