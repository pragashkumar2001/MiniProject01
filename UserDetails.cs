namespace UserProfile
{
    public partial class UserDetails : Form
    {
        public string FullName { get; set; }

        public UserDetails(string fullName)
        {
            FullName = fullName;
            InitializeComponent();
        }

        private void UserDetails_Load_1(object sender, EventArgs e)
        {
            lblFullName.Text = FullName;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserProfile createUserProfile = new CreateUserProfile();
            createUserProfile.ShowDialog();
        }
    }
}
