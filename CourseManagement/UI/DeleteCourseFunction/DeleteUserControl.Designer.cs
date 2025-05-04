namespace CourseManagement
{
    partial class DeleteUserControl
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
            groupBox2 = new GroupBox();
            dataGridViewDelete = new DataGridView();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            btnSearchDelete = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            radioBtnOnline = new RadioButton();
            radioBtnOffline = new RadioButton();
            label1 = new Label();
            BtnDelete = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDelete).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(dataGridViewDelete);
            groupBox2.Location = new Point(51, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1399, 625);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information";
            // 
            // dataGridViewDelete
            // 
            dataGridViewDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDelete.Location = new Point(40, 49);
            dataGridViewDelete.Name = "dataGridViewDelete";
            dataGridViewDelete.RowHeadersWidth = 62;
            dataGridViewDelete.Size = new Size(1310, 541);
            dataGridViewDelete.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(51, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1399, 192);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(btnSearchDelete);
            flowLayoutPanel1.Controls.Add(BtnDelete);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(40, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1132, 43);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(590, 31);
            textBox1.TabIndex = 0;
            // 
            // btnSearchDelete
            // 
            btnSearchDelete.Location = new Point(599, 3);
            btnSearchDelete.Name = "btnSearchDelete";
            btnSearchDelete.Size = new Size(112, 34);
            btnSearchDelete.TabIndex = 1;
            btnSearchDelete.Text = "Search";
            btnSearchDelete.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(radioBtnOnline);
            flowLayoutPanel2.Controls.Add(radioBtnOffline);
            flowLayoutPanel2.Location = new Point(835, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(193, 39);
            flowLayoutPanel2.TabIndex = 2;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(826, 27);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 2;
            label1.Text = "DELETE COURSE";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(717, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(112, 34);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += button1_Click;
            // 
            // DeleteUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DeleteUserControl";
            Size = new Size(1503, 900);
            Load += DeleteUserControl_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDelete).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private Button btnSearchDelete;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton radioBtnOnline;
        private RadioButton radioBtnOffline;
        private DataGridView dataGridViewDelete;
        private Button BtnDelete;
    }
}
