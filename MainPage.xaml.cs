namespace LoginWindow
{
    public partial class MainPage : ContentPage
    {
        string emailUser = "";
        string passwordUser = "";
        string email = "admin";
        string password = "admin";
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            emailUser = emailEntry.Text;
            passwordUser = passwordEntry.Text;
            Notifications.Text = "Witaj "+ emailUser;
            if (!emailUser.Contains("@")) { Notifications.Text = "Nieprawidłowy adres e-mail"; }
            if (passwordUser != "admin") { Notifications.Text = "Hasła się różnią"; }
            

            
        }
    }

}
