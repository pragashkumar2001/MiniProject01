namespace UserProfile
{
    public partial class UserDetails : Form
    {
        public string Message { get; set; }

        public UserDetails(string message)
        {
            Message = message;
            InitializeComponent();
        }

        private void UserDetails_Load_1(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = Message;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserProfile createUserProfile = new CreateUserProfile();
            createUserProfile.ShowDialog();
        }
    }
}
