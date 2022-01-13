namespace UserProfile
{
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            Variable.Text = CreateUserProfile.setValueVariable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserProfile createUserProfile = new CreateUserProfile();
            createUserProfile.ShowDialog();
        }
    }
}
