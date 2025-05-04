namespace CourseManagement.UpdateCourseFunction
{
    partial class UpdateUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtSearchUpdate = new TextBox();
            btnSearchUpdate = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnUpdate = new Button();
            btnReset = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            tableLayoutPanelOfflineUpdate = new TableLayoutPanel();
            lblLocation = new Label();
            lblClassroom = new Label();
            lblSchedule = new Label();
            txtLocation = new TextBox();
            txtClassroom = new TextBox();
            txtSchedule = new TextBox();
            tableLayoutPanelOnlineUpdate = new TableLayoutPanel();
            lblPlatform = new Label();
            lblRecording = new Label();
            lblContactInformation = new Label();
            txtPLatform = new TextBox();
            txtRecording = new TextBox();
            txtContactInformation = new TextBox();
            tableLayoutPanelMain = new TableLayoutPanel();
            lblID = new Label();
            lblNameCourse = new Label();
            txtNameCourse = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblLecturer = new Label();
            txtLecturer = new TextBox();
            lblPrice = new Label();
            txtPriceCourse = new TextBox();
            lblCategory = new Label();
            lblDuration = new Label();
            txtDuration = new TextBox();
            lblStartDate = new Label();
            dateTimePickerStartDate = new DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioBtnOnlineUpdate = new RadioButton();
            radioBtnOfflineUpdate = new RadioButton();
            txtID = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            tableLayoutPanelOfflineUpdate.SuspendLayout();
            tableLayoutPanelOnlineUpdate.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1381, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1219, 111);
            dataGridView1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6805344F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.3194656F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtSearchUpdate, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSearchUpdate, 1, 1);
            tableLayoutPanel1.Location = new Point(92, 93);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6280975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3719025F));
            tableLayoutPanel1.Size = new Size(673, 89);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 1;
            label2.Text = "Please enter course id";
            // 
            // txtSearchUpdate
            // 
            txtSearchUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchUpdate.Location = new Point(3, 42);
            txtSearchUpdate.Name = "txtSearchUpdate";
            txtSearchUpdate.Size = new Size(362, 31);
            txtSearchUpdate.TabIndex = 2;
            // 
            // btnSearchUpdate
            // 
            btnSearchUpdate.Location = new Point(371, 42);
            btnSearchUpdate.Name = "btnSearchUpdate";
            btnSearchUpdate.Size = new Size(112, 34);
            btnSearchUpdate.TabIndex = 3;
            btnSearchUpdate.Text = "Search";
            btnSearchUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(792, 27);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 0;
            label1.Text = "UPDATE COURSE";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(32, 360);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1381, 577);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Controls.Add(tableLayoutPanelMain);
            panel1.Location = new Point(37, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1290, 547);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnUpdate);
            flowLayoutPanel2.Controls.Add(btnReset);
            flowLayoutPanel2.Location = new Point(785, 479);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(344, 64);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.Location = new Point(3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 57);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReset.Location = new Point(156, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(147, 57);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(tableLayoutPanelOfflineUpdate);
            flowLayoutPanel3.Controls.Add(tableLayoutPanelOnlineUpdate);
            flowLayoutPanel3.Location = new Point(40, 311);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1211, 162);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanelOfflineUpdate
            // 
            tableLayoutPanelOfflineUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelOfflineUpdate.ColumnCount = 2;
            tableLayoutPanelOfflineUpdate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2579556F));
            tableLayoutPanelOfflineUpdate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.74204F));
            tableLayoutPanelOfflineUpdate.Controls.Add(lblLocation, 0, 0);
            tableLayoutPanelOfflineUpdate.Controls.Add(lblClassroom, 0, 1);
            tableLayoutPanelOfflineUpdate.Controls.Add(lblSchedule, 0, 2);
            tableLayoutPanelOfflineUpdate.Controls.Add(txtLocation, 1, 0);
            tableLayoutPanelOfflineUpdate.Controls.Add(txtClassroom, 1, 1);
            tableLayoutPanelOfflineUpdate.Controls.Add(txtSchedule, 1, 2);
            tableLayoutPanelOfflineUpdate.Location = new Point(3, 3);
            tableLayoutPanelOfflineUpdate.Name = "tableLayoutPanelOfflineUpdate";
            tableLayoutPanelOfflineUpdate.RowCount = 3;
            tableLayoutPanelOfflineUpdate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOfflineUpdate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOfflineUpdate.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelOfflineUpdate.Size = new Size(597, 108);
            tableLayoutPanelOfflineUpdate.TabIndex = 0;
            // 
            // lblLocation
            // 
            lblLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(3, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(83, 39);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Location:";
            // 
            // lblClassroom
            // 
            lblClassroom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblClassroom.AutoSize = true;
            lblClassroom.Location = new Point(3, 39);
            lblClassroom.Name = "lblClassroom";
            lblClassroom.Size = new Size(100, 39);
            lblClassroom.TabIndex = 1;
            lblClassroom.Text = "Classroom:";
            // 
            // lblSchedule
            // 
            lblSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblSchedule.AutoSize = true;
            lblSchedule.Location = new Point(3, 78);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(87, 30);
            lblSchedule.TabIndex = 2;
            lblSchedule.Text = "Schedule:";
            // 
            // txtLocation
            // 
            txtLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocation.Location = new Point(111, 3);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(483, 31);
            txtLocation.TabIndex = 3;
            // 
            // txtClassroom
            // 
            txtClassroom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClassroom.Location = new Point(111, 42);
            txtClassroom.Name = "txtClassroom";
            txtClassroom.Size = new Size(483, 31);
            txtClassroom.TabIndex = 4;
            // 
            // txtSchedule
            // 
            txtSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSchedule.Location = new Point(111, 81);
            txtSchedule.Name = "txtSchedule";
            txtSchedule.Size = new Size(483, 31);
            txtSchedule.TabIndex = 5;
            // 
            // tableLayoutPanelOnlineUpdate
            // 
            tableLayoutPanelOnlineUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelOnlineUpdate.ColumnCount = 2;
            tableLayoutPanelOnlineUpdate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3566437F));
            tableLayoutPanelOnlineUpdate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.64336F));
            tableLayoutPanelOnlineUpdate.Controls.Add(lblPlatform, 0, 0);
            tableLayoutPanelOnlineUpdate.Controls.Add(lblRecording, 0, 1);
            tableLayoutPanelOnlineUpdate.Controls.Add(lblContactInformation, 0, 2);
            tableLayoutPanelOnlineUpdate.Controls.Add(txtPLatform, 1, 0);
            tableLayoutPanelOnlineUpdate.Controls.Add(txtRecording, 1, 1);
            tableLayoutPanelOnlineUpdate.Controls.Add(txtContactInformation, 1, 2);
            tableLayoutPanelOnlineUpdate.Location = new Point(606, 3);
            tableLayoutPanelOnlineUpdate.Name = "tableLayoutPanelOnlineUpdate";
            tableLayoutPanelOnlineUpdate.RowCount = 3;
            tableLayoutPanelOnlineUpdate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOnlineUpdate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOnlineUpdate.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanelOnlineUpdate.Size = new Size(572, 108);
            tableLayoutPanelOnlineUpdate.TabIndex = 2;
            // 
            // lblPlatform
            // 
            lblPlatform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlatform.AutoSize = true;
            lblPlatform.Location = new Point(3, 0);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(84, 38);
            lblPlatform.TabIndex = 0;
            lblPlatform.Text = "Platform:";
            // 
            // lblRecording
            // 
            lblRecording.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblRecording.AutoSize = true;
            lblRecording.Location = new Point(3, 38);
            lblRecording.Name = "lblRecording";
            lblRecording.Size = new Size(96, 38);
            lblRecording.TabIndex = 1;
            lblRecording.Text = "Recording:";
            // 
            // lblContactInformation
            // 
            lblContactInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblContactInformation.AutoSize = true;
            lblContactInformation.Location = new Point(3, 76);
            lblContactInformation.Name = "lblContactInformation";
            lblContactInformation.Size = new Size(77, 32);
            lblContactInformation.TabIndex = 2;
            lblContactInformation.Text = "Contact:";
            // 
            // txtPLatform
            // 
            txtPLatform.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPLatform.Location = new Point(108, 3);
            txtPLatform.Name = "txtPLatform";
            txtPLatform.Size = new Size(461, 31);
            txtPLatform.TabIndex = 3;
            // 
            // txtRecording
            // 
            txtRecording.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRecording.Location = new Point(108, 41);
            txtRecording.Name = "txtRecording";
            txtRecording.Size = new Size(461, 31);
            txtRecording.TabIndex = 4;
            // 
            // txtContactInformation
            // 
            txtContactInformation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContactInformation.Location = new Point(108, 79);
            txtContactInformation.Name = "txtContactInformation";
            txtContactInformation.Size = new Size(461, 31);
            txtContactInformation.TabIndex = 5;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelMain.ColumnCount = 6;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.348484F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.65151F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 329F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanelMain.Controls.Add(lblID, 0, 0);
            tableLayoutPanelMain.Controls.Add(lblNameCourse, 0, 1);
            tableLayoutPanelMain.Controls.Add(txtNameCourse, 1, 1);
            tableLayoutPanelMain.Controls.Add(lblDescription, 0, 2);
            tableLayoutPanelMain.Controls.Add(txtDescription, 1, 2);
            tableLayoutPanelMain.Controls.Add(lblLecturer, 2, 0);
            tableLayoutPanelMain.Controls.Add(txtLecturer, 3, 0);
            tableLayoutPanelMain.Controls.Add(lblPrice, 2, 1);
            tableLayoutPanelMain.Controls.Add(txtPriceCourse, 3, 1);
            tableLayoutPanelMain.Controls.Add(lblCategory, 2, 2);
            tableLayoutPanelMain.Controls.Add(lblDuration, 0, 3);
            tableLayoutPanelMain.Controls.Add(txtDuration, 1, 3);
            tableLayoutPanelMain.Controls.Add(lblStartDate, 2, 3);
            tableLayoutPanelMain.Controls.Add(dateTimePickerStartDate, 3, 3);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanel1, 3, 2);
            tableLayoutPanelMain.Controls.Add(txtID, 1, 0);
            tableLayoutPanelMain.Location = new Point(40, 102);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 4;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50.60241F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanelMain.Size = new Size(1211, 159);
            tableLayoutPanelMain.TabIndex = 5;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(34, 25);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameCourse
            // 
            lblNameCourse.AutoSize = true;
            lblNameCourse.Location = new Point(3, 42);
            lblNameCourse.Name = "lblNameCourse";
            lblNameCourse.Size = new Size(63, 25);
            lblNameCourse.TabIndex = 2;
            lblNameCourse.Text = "Name:";
            lblNameCourse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameCourse
            // 
            txtNameCourse.Location = new Point(123, 45);
            txtNameCourse.Name = "txtNameCourse";
            txtNameCourse.Size = new Size(388, 31);
            txtNameCourse.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(3, 83);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 25);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(123, 86);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(388, 31);
            txtDescription.TabIndex = 5;
            // 
            // lblLecturer
            // 
            lblLecturer.AutoSize = true;
            lblLecturer.Location = new Point(542, 0);
            lblLecturer.Name = "lblLecturer";
            lblLecturer.Size = new Size(78, 25);
            lblLecturer.TabIndex = 6;
            lblLecturer.Text = "Lecturer:";
            lblLecturer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLecturer
            // 
            txtLecturer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLecturer.Location = new Point(648, 3);
            txtLecturer.Name = "txtLecturer";
            txtLecturer.Size = new Size(323, 31);
            txtLecturer.TabIndex = 7;
            txtLecturer.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(542, 42);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 25);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price:";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPriceCourse
            // 
            txtPriceCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPriceCourse.Location = new Point(648, 45);
            txtPriceCourse.Name = "txtPriceCourse";
            txtPriceCourse.Size = new Size(323, 31);
            txtPriceCourse.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(542, 83);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 25);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(3, 122);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(85, 25);
            lblDuration.TabIndex = 12;
            lblDuration.Text = "Duration:";
            lblDuration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(123, 125);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(388, 31);
            txtDuration.TabIndex = 13;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(542, 122);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(94, 25);
            lblStartDate.TabIndex = 14;
            lblStartDate.Text = "Start Date:";
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerStartDate.Location = new Point(648, 125);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(323, 31);
            dateTimePickerStartDate.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioBtnOnlineUpdate);
            flowLayoutPanel1.Controls.Add(radioBtnOfflineUpdate);
            flowLayoutPanel1.Location = new Point(648, 86);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(317, 33);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // radioBtnOnlineUpdate
            // 
            radioBtnOnlineUpdate.AutoSize = true;
            radioBtnOnlineUpdate.Location = new Point(3, 3);
            radioBtnOnlineUpdate.Name = "radioBtnOnlineUpdate";
            radioBtnOnlineUpdate.Size = new Size(88, 29);
            radioBtnOnlineUpdate.TabIndex = 0;
            radioBtnOnlineUpdate.TabStop = true;
            radioBtnOnlineUpdate.Text = "Online";
            radioBtnOnlineUpdate.UseVisualStyleBackColor = true;
            radioBtnOnlineUpdate.CheckedChanged += radioBtnOnlineUpdate_CheckedChanged;
            // 
            // radioBtnOfflineUpdate
            // 
            radioBtnOfflineUpdate.AutoSize = true;
            radioBtnOfflineUpdate.Location = new Point(97, 3);
            radioBtnOfflineUpdate.Name = "radioBtnOfflineUpdate";
            radioBtnOfflineUpdate.Size = new Size(90, 29);
            radioBtnOfflineUpdate.TabIndex = 1;
            radioBtnOfflineUpdate.TabStop = true;
            radioBtnOfflineUpdate.Text = "Offline";
            radioBtnOfflineUpdate.UseVisualStyleBackColor = true;
            radioBtnOfflineUpdate.CheckedChanged += radioBtnOfflineUpdate_CheckedChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(123, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(388, 31);
            txtID.TabIndex = 1;
            // 
            // UpdateUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UpdateUserControl";
            Size = new Size(1452, 951);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            tableLayoutPanelOfflineUpdate.ResumeLayout(false);
            tableLayoutPanelOfflineUpdate.PerformLayout();
            tableLayoutPanelOnlineUpdate.ResumeLayout(false);
            tableLayoutPanelOnlineUpdate.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox txtSearchUpdate;
        private Button btnSearchUpdate;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private TableLayoutPanel tableLayoutPanelOfflineUpdate;
        private Label lblLocation;
        private Label lblClassroom;
        private Label lblSchedule;
        private TextBox txtLocation;
        private TextBox txtClassroom;
        private TextBox txtSchedule;
        private TableLayoutPanel tableLayoutPanelOnlineUpdate;
        private Label lblPlatform;
        private Label lblRecording;
        private Label lblContactInformation;
        private TextBox txtPLatform;
        private TextBox txtRecording;
        private TextBox txtContactInformation;
        private TableLayoutPanel tableLayoutPanelMain;
        private Label lblID;
        private Label lblNameCourse;
        private TextBox txtNameCourse;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblLecturer;
        private TextBox txtLecturer;
        private Label lblPrice;
        private TextBox txtPriceCourse;
        private Label lblCategory;
        private Label lblDuration;
        private TextBox txtDuration;
        private Label lblStartDate;
        private DateTimePicker dateTimePickerStartDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioBtnOnlineUpdate;
        private RadioButton radioBtnOfflineUpdate;
        private TextBox txtID;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnUpdate;
        private Button btnReset;
    }
}
