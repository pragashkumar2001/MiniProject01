namespace UserProfile
{
    public partial class UserDetails : Form
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public UserDetails(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
            InitializeComponent();
        }

        private void UserDetails_Load_1(object sender, EventArgs e)
        {
            lblFullName.Text = FullName;
            lblAge.Text = "You are " + Age + " years old.";
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserProfile createUserProfile = new();
            createUserProfile.ShowDialog();
        }

    }
}
