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
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnCreate = new Button();
            btnReset = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblID = new Label();
            lblNameCourse = new Label();
            textBox2 = new TextBox();
            lblDescription = new Label();
            textBox3 = new TextBox();
            lblLecturer = new Label();
            textBox4 = new TextBox();
            lblPrice = new Label();
            textBox5 = new TextBox();
            lblCategory = new Label();
            lblDuration = new Label();
            textBox7 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
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
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(50, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1298, 504);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
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
            flowLayoutPanel2.Location = new Point(715, 350);
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.348484F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.65151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 329F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.Controls.Add(lblID, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNameCourse, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDescription, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(lblLecturer, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel1.Controls.Add(lblPrice, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox5, 3, 1);
            tableLayoutPanel1.Controls.Add(lblCategory, 2, 2);
            tableLayoutPanel1.Controls.Add(lblDuration, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox7, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 2, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 3, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 3, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(80, 109);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.60241F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(1181, 159);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
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
            // textBox2
            // 
            textBox2.Location = new Point(116, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(388, 31);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(116, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(388, 31);
            textBox3.TabIndex = 5;
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
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(618, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 31);
            textBox4.TabIndex = 7;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
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
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(618, 45);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(323, 31);
            textBox5.TabIndex = 9;
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
            // textBox7
            // 
            textBox7.Location = new Point(116, 125);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(388, 31);
            textBox7.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(512, 122);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 14;
            label1.Text = "Start Date:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(618, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(323, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioButton1);
            flowLayoutPanel1.Controls.Add(radioButton2);
            flowLayoutPanel1.Location = new Point(618, 86);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(317, 33);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Online";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(97, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Offline";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 31);
            textBox1.TabIndex = 1;
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
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblID;
        private TextBox textBox1;
        private Label lblNameCourse;
        private TextBox textBox2;
        private Label lblDescription;
        private TextBox textBox3;
        private Label lblLecturer;
        private TextBox textBox4;
        private Label lblPrice;
        private TextBox textBox5;
        private Label lblCategory;
        private Label lblDuration;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
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
    }
}
