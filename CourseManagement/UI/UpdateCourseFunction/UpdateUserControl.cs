using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagement.UpdateCourseFunction
{
    public partial class UpdateUserControl : UserControl
    {
        public UpdateUserControl()
        {
            InitializeComponent();
            SetupUpdateEvents();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SetupUpdateEvents()
        {
            if (this.radioBtnOnlineUpdate.Checked)
            {
                radioBtnOnlineUpdate_CheckedChanged(this, EventArgs.Empty);
            }
            if (this.radioBtnOnlineUpdate.Checked)
            {
                radioBtnOfflineUpdate_CheckedChanged(this, EventArgs.Empty);
            }
            btnReset_Click_1(this, EventArgs.Empty);
        }


        private void radioBtnOnlineUpdate_CheckedChanged(object sender, EventArgs e)
        {
            this.tableLayoutPanelOfflineUpdate.Enabled = false;
            if (this.tableLayoutPanelOnlineUpdate.Enabled == false)
            {
                this.tableLayoutPanelOnlineUpdate.Enabled = true;
            }
        }

        private void radioBtnOfflineUpdate_CheckedChanged(object sender, EventArgs e)
        {
            this.tableLayoutPanelOnlineUpdate.Enabled = false;
            if (this.tableLayoutPanelOfflineUpdate.Enabled == false)
            {
                this.tableLayoutPanelOfflineUpdate.Enabled = true;
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            this.txtID.ResetText();
            this.txtNameCourse.ResetText();
            this.txtDescription.ResetText();
            this.txtDuration.ResetText();
            this.txtLecturer.ResetText();
            this.txtPriceCourse.ResetText();
            this.dateTimePickerStartDate.ResetText();
            if (this.radioBtnOnlineUpdate.Checked == true)
            {
                this.radioBtnOnlineUpdate.Checked = false;
                this.tableLayoutPanelOfflineUpdate.Enabled = true;
                this.txtPLatform.ResetText();
                this.txtContactInformation.ResetText();
                this.txtRecording.ResetText();
            }
            if (this.radioBtnOfflineUpdate.Checked == true)
            {
                this.radioBtnOfflineUpdate.Checked = false;
                this.tableLayoutPanelOnlineUpdate.Enabled = true;
                this.txtClassroom.ResetText();
                this.txtLocation.ResetText();
                this.txtSchedule.ResetText();
            }
        }
    }
}
