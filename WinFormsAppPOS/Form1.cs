namespace WinFormsAppPOS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            pnlMaintenance.Visible = true;
            pnlSales.Visible = false;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            pnlMaintenance.Visible = false;
            pnlSales.Visible = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProduct pm = new frmProduct();
            pm.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory category = new frmCategory();
            category.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer cm = new frmCustomer();
            cm.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
        }
    }
}
