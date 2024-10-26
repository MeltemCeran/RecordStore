namespace RecordStore.PL
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
        }
    }
}
