using System.Text.RegularExpressions;

namespace UserProfile
{
    public partial class CreateUserProfile : Form
    {
        public static string setValueVariable = "";

        public CreateUserProfile()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Pronoun;
            int Age;

            if (radioFemale.Checked && cmbMaritalStatus.SelectedIndex is 1)
            {
                Pronoun = "Mrs.";
            }
            else if (radioFemale.Checked && cmbMaritalStatus.SelectedIndex is 2)
            {
                Pronoun = "Miss.";
            }
            else
            {
                Pronoun = "Mr.";
            }

            int enteredyear = int.Parse(txtYear.Text);

            var year = DateTime.Now.Year;

            if (year < enteredyear)
            {
                MessageBox.Show("Please check your birth year", "Birth Year Not valid");
                return;

            }

            Age = year - enteredyear;

            setValueVariable = "Welcome: " + Pronoun + " " + txtFullName.Text + ". You are " + Age + " years old";

            if (IsValid())
            {
                this.Hide(); // hide the current form
                UserDetails userDetails = new UserDetails();
                userDetails.ShowDialog();
            }

        }


        private bool IsValid()
        {
            if (Regex.IsMatch(txtFullName.Text, @"[a-zA-Z]") == false)
            {
                MessageBox.Show("Please enter letters only", "Name Validation Error");
                txtFullName.Focus();
                return false;
            }

            if (Regex.IsMatch(txtPhoneNumber.Text, @"[0-9]") == false)
            {
                MessageBox.Show("Please enter numbers only", "Phone Number Validation Error");
                txtPhoneNumber.Focus();
                return false;
            }

            if (txtFullName.Text == string.Empty ||
                txtAddress.Text == string.Empty ||
                txtPhoneNumber.Text == string.Empty ||
                !(radioMale.Checked || radioFemale.Checked) ||
                txtDay.Text == string.Empty ||
                txtMonth.Text == string.Empty ||
                txtYear.Text == string.Empty ||
                cmbMaritalStatus.SelectedIndex == 0 ||
                txtFavouriteColor.Text == string.Empty)
            {
                MessageBox.Show("You have to enter requested fields. Cheack again..!!", "Empty Field Validation");
                return false;
            }


            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            txtDay.Text = string.Empty;
            txtMonth.Text = string.Empty;
            txtYear.Text = string.Empty;
            cmbMaritalStatus.SelectedIndex = 0;
            txtFavouriteColor.Text = string.Empty;

        }
    }
}
