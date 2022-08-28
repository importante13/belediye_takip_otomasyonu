namespace BelediyePersonelTakip
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kaydol kd = new Kaydol();
            kd.Show();
            this.Hide();
        }
    }
}