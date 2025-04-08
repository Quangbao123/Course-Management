namespace CourseManagement
{
    public partial class ManagerForm : Form
    {
        private Panel contentPanel;
        public ManagerForm()
        {
            InitializeComponent();
            InitializeContentPanel();
            SetupEvents();
        }
        private void InitializeContentPanel()
        {
            // Tạo và cấu hình panel chứa nội dung
            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill; // Panel sẽ lấp đầy phần còn lại của form
            contentPanel.BackColor = Color.White;
            this.Controls.Add(contentPanel);

            // Đảm bảo panel nằm dưới cùng để không che menu
            contentPanel.BringToFront();
        }
        private void SetupEvents()
        {
            addToolStripCreate.Click += MenuItemCreate_Click;
            deleteToolStripMenuItem.Click += MenuItemDelete_Click;
            readToolStripMenuItem.Click += MenuItemRead_Click;
        }
        private void MenuItemCreate_Click(object sender, EventArgs e)
        {
            // Xóa tất cả controls hiện tại trong contentPanel
            contentPanel.Controls.Clear();

            // Tạo instance của CreateUserControl
            CreateUserControl createControl = new CreateUserControl();

            // Cấu hình CreateUserControl
            createControl.Dock = DockStyle.Fill;

            // Thêm nó vào contentPanel
            contentPanel.Controls.Add(createControl);
        }
        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            // Xóa tất cả controls hiện tại trong contentPanel
            contentPanel.Controls.Clear();

            // Tạo instance của DeleteUserControl
            DeleteUserControl deleteControl = new DeleteUserControl();

            deleteControl.Dock = DockStyle.Fill;

            // Thêm nó vào contentPanel
            contentPanel.Controls.Add(deleteControl);
        }
        private void MenuItemRead_Click(object sender, EventArgs e)
        {
            // Xóa tất cả control hiện tại
            contentPanel.Controls.Clear();

            // Tạo instance của ReadUserControl
            ReadUserControl readControl = new ReadUserControl();
            readControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(readControl);
        }
    }
}
