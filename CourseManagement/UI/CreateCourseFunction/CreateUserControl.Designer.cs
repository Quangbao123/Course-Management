namespace CourseManagement
{
    partial class CreateUserControl
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
            flowLayoutPanel3 = new FlowLayoutPanel();
            tableLayoutPanelOffline = new TableLayoutPanel();
            lblLocation = new Label();
            lblClassroom = new Label();
            lblSchedule = new Label();
            txtLocation = new TextBox();
            txtClassroom = new TextBox();
            txtSchedule = new TextBox();
            tableLayoutPanelOnline = new TableLayoutPanel();
            lblPlatform = new Label();
            lblRecording = new Label();
            lblContactInformation = new Label();
            txtPLatform = new TextBox();
            txtRecording = new TextBox();
            txtContactInformation = new TextBox();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnCreate = new Button();
            btnReset = new Button();
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
            radioBtnOnline = new RadioButton();
            radioBtnOffline = new RadioButton();
            txtID = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnCourseName = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnLecturer = new DataGridViewTextBoxColumn();
            ColumnCategory = new DataGridViewTextBoxColumn();
            ColumnDuration = new DataGridViewTextBoxColumn();
            ColumnPrice = new DataGridViewTextBoxColumn();
            ColumnStartDate = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            tableLayoutPanelOffline.SuspendLayout();
            tableLayoutPanelOnline.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Controls.Add(tableLayoutPanelMain);
            groupBox1.Location = new Point(50, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1298, 504);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(tableLayoutPanelOffline);
            flowLayoutPanel3.Controls.Add(tableLayoutPanelOnline);
            flowLayoutPanel3.Location = new Point(80, 289);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1181, 122);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanelOffline
            // 
            tableLayoutPanelOffline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelOffline.ColumnCount = 2;
            tableLayoutPanelOffline.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2579556F));
            tableLayoutPanelOffline.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.74204F));
            tableLayoutPanelOffline.Controls.Add(lblLocation, 0, 0);
            tableLayoutPanelOffline.Controls.Add(lblClassroom, 0, 1);
            tableLayoutPanelOffline.Controls.Add(lblSchedule, 0, 2);
            tableLayoutPanelOffline.Controls.Add(txtLocation, 1, 0);
            tableLayoutPanelOffline.Controls.Add(txtClassroom, 1, 1);
            tableLayoutPanelOffline.Controls.Add(txtSchedule, 1, 2);
            tableLayoutPanelOffline.Location = new Point(3, 3);
            tableLayoutPanelOffline.Name = "tableLayoutPanelOffline";
            tableLayoutPanelOffline.RowCount = 3;
            tableLayoutPanelOffline.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOffline.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOffline.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelOffline.Size = new Size(597, 108);
            tableLayoutPanelOffline.TabIndex = 0;
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
            // tableLayoutPanelOnline
            // 
            tableLayoutPanelOnline.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelOnline.ColumnCount = 2;
            tableLayoutPanelOnline.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.3566437F));
            tableLayoutPanelOnline.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.64336F));
            tableLayoutPanelOnline.Controls.Add(lblPlatform, 0, 0);
            tableLayoutPanelOnline.Controls.Add(lblRecording, 0, 1);
            tableLayoutPanelOnline.Controls.Add(lblContactInformation, 0, 2);
            tableLayoutPanelOnline.Controls.Add(txtPLatform, 1, 0);
            tableLayoutPanelOnline.Controls.Add(txtRecording, 1, 1);
            tableLayoutPanelOnline.Controls.Add(txtContactInformation, 1, 2);
            tableLayoutPanelOnline.Location = new Point(606, 3);
            tableLayoutPanelOnline.Name = "tableLayoutPanelOnline";
            tableLayoutPanelOnline.RowCount = 3;
            tableLayoutPanelOnline.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOnline.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOnline.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanelOnline.Size = new Size(572, 108);
            tableLayoutPanelOnline.TabIndex = 2;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(735, 44);
            label2.Name = "label2";
            label2.Size = new Size(286, 32);
            label2.TabIndex = 3;
            label2.Text = "CREATE A NEW COURSE";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnCreate);
            flowLayoutPanel2.Controls.Add(btnReset);
            flowLayoutPanel2.Location = new Point(720, 417);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(504, 64);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreate.Location = new Point(3, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(147, 57);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
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
            btnReset.Click += btnReset_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            tableLayoutPanelMain.Location = new Point(80, 109);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 4;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50.60241F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanelMain.Size = new Size(1181, 159);
            tableLayoutPanelMain.TabIndex = 0;
            tableLayoutPanelMain.Paint += tableLayoutPanel1_Paint;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblID.AutoSize = true;
            lblID.Location = new Point(3, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(34, 42);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            lblID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameCourse
            // 
            lblNameCourse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblNameCourse.AutoSize = true;
            lblNameCourse.Location = new Point(3, 42);
            lblNameCourse.Name = "lblNameCourse";
            lblNameCourse.Size = new Size(63, 41);
            lblNameCourse.TabIndex = 2;
            lblNameCourse.Text = "Name:";
            lblNameCourse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameCourse
            // 
            txtNameCourse.Location = new Point(116, 45);
            txtNameCourse.Name = "txtNameCourse";
            txtNameCourse.Size = new Size(388, 31);
            txtNameCourse.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(3, 83);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 39);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(116, 86);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(388, 31);
            txtDescription.TabIndex = 5;
            // 
            // lblLecturer
            // 
            lblLecturer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblLecturer.AutoSize = true;
            lblLecturer.Location = new Point(512, 0);
            lblLecturer.Name = "lblLecturer";
            lblLecturer.Size = new Size(78, 42);
            lblLecturer.TabIndex = 6;
            lblLecturer.Text = "Lecturer:";
            lblLecturer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLecturer
            // 
            txtLecturer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLecturer.Location = new Point(618, 3);
            txtLecturer.Name = "txtLecturer";
            txtLecturer.Size = new Size(323, 31);
            txtLecturer.TabIndex = 7;
            txtLecturer.TextAlign = HorizontalAlignment.Center;
            txtLecturer.TextChanged += textBox4_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(512, 42);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 41);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price:";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPriceCourse
            // 
            txtPriceCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPriceCourse.Location = new Point(618, 45);
            txtPriceCourse.Name = "txtPriceCourse";
            txtPriceCourse.Size = new Size(323, 31);
            txtPriceCourse.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(512, 83);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 39);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            lblDuration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(3, 122);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(85, 37);
            lblDuration.TabIndex = 12;
            lblDuration.Text = "Duration:";
            lblDuration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(116, 125);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(388, 31);
            txtDuration.TabIndex = 13;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(512, 122);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(94, 37);
            lblStartDate.TabIndex = 14;
            lblStartDate.Text = "Start Date:";
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerStartDate.Location = new Point(618, 125);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(323, 31);
            dateTimePickerStartDate.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioBtnOnline);
            flowLayoutPanel1.Controls.Add(radioBtnOffline);
            flowLayoutPanel1.Location = new Point(618, 86);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(317, 33);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // radioBtnOnline
            // 
            radioBtnOnline.AutoSize = true;
            radioBtnOnline.Location = new Point(3, 3);
            radioBtnOnline.Name = "radioBtnOnline";
            radioBtnOnline.Size = new Size(88, 29);
            radioBtnOnline.TabIndex = 0;
            radioBtnOnline.TabStop = true;
            radioBtnOnline.Text = "Online";
            radioBtnOnline.UseVisualStyleBackColor = true;
            radioBtnOnline.CheckedChanged += radioBtnOnline_CheckedChanged;
            // 
            // radioBtnOffline
            // 
            radioBtnOffline.AutoSize = true;
            radioBtnOffline.Location = new Point(97, 3);
            radioBtnOffline.Name = "radioBtnOffline";
            radioBtnOffline.Size = new Size(90, 29);
            radioBtnOffline.TabIndex = 1;
            radioBtnOffline.TabStop = true;
            radioBtnOffline.Text = "Offline";
            radioBtnOffline.UseVisualStyleBackColor = true;
            radioBtnOffline.CheckedChanged += radioBtnOffline_CheckedChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(116, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(388, 31);
            txtID.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(50, 602);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1298, 487);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnCourseName, ColumnDescription, ColumnLecturer, ColumnCategory, ColumnDuration, ColumnPrice, ColumnStartDate });
            dataGridView1.Location = new Point(33, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1225, 405);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 8;
            ColumnID.Name = "ColumnID";
            ColumnID.Width = 150;
            // 
            // ColumnCourseName
            // 
            ColumnCourseName.HeaderText = "CourseName";
            ColumnCourseName.MinimumWidth = 8;
            ColumnCourseName.Name = "ColumnCourseName";
            ColumnCourseName.Width = 150;
            // 
            // ColumnDescription
            // 
            ColumnDescription.HeaderText = "Description";
            ColumnDescription.MinimumWidth = 8;
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.Width = 150;
            // 
            // ColumnLecturer
            // 
            ColumnLecturer.HeaderText = "Lecturer";
            ColumnLecturer.MinimumWidth = 8;
            ColumnLecturer.Name = "ColumnLecturer";
            ColumnLecturer.Width = 150;
            // 
            // ColumnCategory
            // 
            ColumnCategory.HeaderText = "Category";
            ColumnCategory.MinimumWidth = 8;
            ColumnCategory.Name = "ColumnCategory";
            ColumnCategory.Width = 150;
            // 
            // ColumnDuration
            // 
            ColumnDuration.HeaderText = "Duration";
            ColumnDuration.MinimumWidth = 8;
            ColumnDuration.Name = "ColumnDuration";
            ColumnDuration.Width = 150;
            // 
            // ColumnPrice
            // 
            ColumnPrice.HeaderText = "Price";
            ColumnPrice.MinimumWidth = 8;
            ColumnPrice.Name = "ColumnPrice";
            ColumnPrice.Width = 150;
            // 
            // ColumnStartDate
            // 
            ColumnStartDate.HeaderText = "Start Date";
            ColumnStartDate.MinimumWidth = 8;
            ColumnStartDate.Name = "ColumnStartDate";
            ColumnStartDate.Width = 150;
            // 
            // CreateUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CreateUserControl";
            Size = new Size(1403, 1123);
            Load += CreateUserControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            tableLayoutPanelOffline.ResumeLayout(false);
            tableLayoutPanelOffline.PerformLayout();
            tableLayoutPanelOnline.ResumeLayout(false);
            tableLayoutPanelOnline.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanelMain;
        private Label lblID;
        private TextBox txtID;
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
        private DateTimePicker dateTimePickerStartDate;
        private Label lblStartDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioBtnOnline;
        private RadioButton radioBtnOffline;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnCourseName;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnLecturer;
        private DataGridViewTextBoxColumn ColumnCategory;
        private DataGridViewTextBoxColumn ColumnDuration;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnStartDate;
        private Button btnCreate;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnReset;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel3;
        private TableLayoutPanel tableLayoutPanelOffline;
        private Label lblLocation;
        private Label lblClassroom;
        private Label lblSchedule;
        private TextBox txtLocation;
        private TextBox txtClassroom;
        private TextBox txtSchedule;
        private TableLayoutPanel tableLayoutPanelOnline;
        private Label lblPlatform;
        private Label lblRecording;
        private Label lblContactInformation;
        private TextBox txtPLatform;
        private TextBox txtRecording;
        private TextBox txtContactInformation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
