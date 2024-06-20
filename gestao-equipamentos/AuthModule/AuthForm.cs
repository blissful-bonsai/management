using WinFormsApp1;
namespace GestaoEquipamentos.WinFormsApp.AuthModule
{
    public partial class AuthForm : Form
    {
        AuthController AuthController { get; set; }
        public AuthForm()
        {
            InitializeComponent();
            AuthController = new AuthController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            try
            {
                if (AuthController.Auth(login, password))
                {
                    Hide();
                    ManagementForm managementForm = new ManagementForm();
                    managementForm.ShowDialog(this);
                    Close();
                }

            }
            catch (Exception ex) // Catch "catches" the ex, then show it's content (message)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }



        }
    }
}
