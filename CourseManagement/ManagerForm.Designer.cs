using System.Windows.Forms;

namespace CourseManagement
{
    partial class ManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            courseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripCreate = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            reviseToolStripMenuItem = new ToolStripMenuItem();
            readToolStripMenuItem = new ToolStripMenuItem();
            priceToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            readToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { courseToolStripMenuItem, priceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1254, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // courseToolStripMenuItem
            // 
            courseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripCreate, deleteToolStripMenuItem, reviseToolStripMenuItem, readToolStripMenuItem });
            courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            courseToolStripMenuItem.Size = new Size(83, 29);
            courseToolStripMenuItem.Text = "Course";
            // 
            // addToolStripCreate
            // 
            addToolStripCreate.Name = "addToolStripCreate";
            addToolStripCreate.Size = new Size(270, 34);
            addToolStripCreate.Text = "Create";
            addToolStripCreate.Click += this.addToolStripCreate_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(270, 34);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // reviseToolStripMenuItem
            // 
            reviseToolStripMenuItem.Name = "reviseToolStripMenuItem";
            reviseToolStripMenuItem.Size = new Size(270, 34);
            reviseToolStripMenuItem.Text = "Update";
            // 
            // readToolStripMenuItem
            // 
            readToolStripMenuItem.Name = "readToolStripMenuItem";
            readToolStripMenuItem.Size = new Size(270, 34);
            readToolStripMenuItem.Text = "Read";
            // 
            // priceToolStripMenuItem
            // 
            priceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateToolStripMenuItem, readToolStripMenuItem1 });
            priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            priceToolStripMenuItem.Size = new Size(65, 29);
            priceToolStripMenuItem.Text = "Price";
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(172, 34);
            updateToolStripMenuItem.Text = "Update";
            // 
            // readToolStripMenuItem1
            // 
            readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            readToolStripMenuItem1.Size = new Size(172, 34);
            readToolStripMenuItem1.Text = "Read";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 629);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "ManagerForm";
            Text = "Course Management";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void addToolStripCreate_Click(object sender, EventArgs e)
        {
            
            // Tạo instance của form Create
            CreateUserControl createForm = new CreateUserControl();

            // Hiển thị form Create
            createForm.Show(); // Hiển thị dưới dạng dialog (modal)

            // Hoặc nếu bạn muốn hiển thị form không modal
            // createForm.Show();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem priceToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem readToolStripMenuItem1;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem addToolStripCreate;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem reviseToolStripMenuItem;
        private ToolStripMenuItem readToolStripMenuItem; 
    }
}
