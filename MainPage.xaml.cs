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
            Notifications.Text = "Witaj";
            if (emailUser != "admin") { Notifications.Text = "Błędny email"; }
            if (passwordUser != "admin") { Notifications.Text = "Błędne hasło"; }
            

            //SemanticScreenReader.Announce(Notifications.Text);
        }
    }

}
