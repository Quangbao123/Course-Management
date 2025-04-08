namespace CourseManagement
{
    partial class ReadUserControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioBtnOnline = new RadioButton();
            radioBtnOffline = new RadioButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioBtnOnline);
            flowLayoutPanel1.Controls.Add(radioBtnOffline);
            flowLayoutPanel1.Location = new Point(742, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(193, 39);
            flowLayoutPanel1.TabIndex = 0;
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
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.Controls.Add(btnSearch);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel2.Location = new Point(47, 92);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1375, 47);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(615, 31);
            textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(624, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(826, 27);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 2;
            label1.Text = "COURSE LIST";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(flowLayoutPanel2);
            groupBox1.Location = new Point(40, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1447, 177);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(40, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1447, 486);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1379, 411);
            dataGridView1.TabIndex = 0;
            // 
            // ReadUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ReadUserControl";
            Size = new Size(1536, 756);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioBtnOnline;
        private RadioButton radioBtnOffline;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBox1;
        private Button btnSearch;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}
