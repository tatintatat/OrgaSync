using OrgaSync_App;
namespace WinFormsApp2
{
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
            this.Load += FrLogin_Load;
            this.Resize += FrLogin_Resize;
        }
        int attempts = 3;
        private void CenterPanel()
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        }

        private void FrLogin_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void FrLogin_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtuser.Text == "admin" && txtpass.Text == "1234")
            {
                lblmessage.Text = "Successfully Logged in!";
                lblmessage.ForeColor = Color.Green;
                Home home = new Home();
                FrLogin login = new FrLogin();
                home.Show();
                FrLogin Login = new FrLogin();
                Login.Hide();
            }
            else
            {
                attempts--;
                lblmessage.Text = $"Wrong! Try Again there are only {attempts} attempts left";
                lblmessage.ForeColor = Color.Red;
            }
            if (attempts == 0)
            {
                btnLogin.Enabled = false;//gagawin nitong false para di gumana yung button
                lblmessage.Text = $"No More Attempts! Login Disabled!";
                txtuser.Enabled = false;
                txtpass.Enabled = false;
                lblmessage.ForeColor = Color.Red;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.BackColor = Color.LightBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.Control;
        }

        private void FrLogin_Load_1(object sender, EventArgs e)
        {

        }

    }
}
