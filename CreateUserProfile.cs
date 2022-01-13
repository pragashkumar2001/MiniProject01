using System.Globalization;
using System.Text.RegularExpressions;

namespace UserProfile
{
    public partial class CreateUserProfile : Form
    {
        public CreateUserProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create button on click event
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                this.Hide(); // hide the current form
                UserDetails userDetails = new UserDetails(this.GetFullName(), this.GetAge());
                userDetails.ShowDialog();
            }
        }

        /// <summary>
        /// Verify form fields' validations
        /// </summary>
        private bool IsValid()
        {
            // empty fields validation
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

            // fullname field validation
            if (!this.CheckLetterWithSpaceValidation(txtFullName.Text))
            {
                MessageBox.Show("Please enter letters only", "Full Name Validation Error");
                txtFullName.Focus();
                return false;
            }

            // phone number field validations
            if (!this.CheckNumberValidation(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter numbers only", "Phone Number Validation Error");
                txtPhoneNumber.Focus();
                return false;
            }

            if (txtPhoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Phone Number format is invalid. Please enter 10 digits only", "Phone Number Validation Error");
                txtPhoneNumber.Focus();
                return false;
            }


            // birth day field validation
            if (!this.CheckNumberValidation(txtDay.Text))
            {
                MessageBox.Show("Please enter numbers only", "Day Field Validation Error");
                txtDay.Focus();
                return false;
            }

            if (int.Parse(txtDay.Text) < 01 || int.Parse(txtDay.Text) > 31)
            {
                MessageBox.Show("Day field format is invalid", "Day Field Validation Error");
                txtDay.Focus();
                return false;
            }

            // birth month field validation
            if (!this.CheckNumberValidation(txtMonth.Text))
            {
                MessageBox.Show("Please enter numbers only", "Month Field Validation Error");
                txtMonth.Focus();
                return false;
            }

            if (int.Parse(txtMonth.Text) < 01 || int.Parse(txtMonth.Text) > 12)
            {
                MessageBox.Show("Month field format is invalid", "Month Field Validation Error");
                txtMonth.Focus();
                return false;
            }


            // birth year field validations
            if (!this.CheckNumberValidation(txtYear.Text))
            {
                MessageBox.Show("Please enter numbers only", "Year Field Validation Error");
                txtYear.Focus();
                return false;
            }

            if (txtYear.Text.Length != 4)
            {
                MessageBox.Show("Year field format is invalid. Please enter 4 digits only", "Year Field Validation Error");
                txtYear.Focus();
                return false;
            }

            if (int.Parse(txtYear.Text) >= DateTime.Now.Year)
            {
                MessageBox.Show("Year must in before the current year", "Year Field Validation Error");
                txtYear.Focus();
                return false;
            }

            // favourite color field validations
            if (!this.CheckLetterValidation(txtFavouriteColor.Text))
            {
                MessageBox.Show("Please enter letters only", "Color Name Validation Error");
                txtFavouriteColor.Focus();
                return false;
            }

            return true;
        }


        /// <summary>
        /// Returns true if the fieldName contains letters else returns false
        /// </summary>
        private bool CheckLetterValidation(string fieldName)
        {
            if (Regex.IsMatch(fieldName, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the fieldName contains letters with spaces else returns false
        /// </summary>
        private bool CheckLetterWithSpaceValidation(string fieldName)
        {
            if (Regex.IsMatch(fieldName, @"^[a-zA-Z]+(?:[\s.]+[a-zA-Z]+)*$"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the fieldName contains numbers else returns false
        /// </summary>
        private bool CheckNumberValidation(string fieldName)
        {
            if (Regex.IsMatch(fieldName, @"^[0-9]+$"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Converts string to title case
        /// </summary>
        private string ToTitleCase(string text)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        /// <summary>
        /// Get age
        /// </summary>
        /// <returns></returns>
        private int GetAge()
        {
            int enteredYear = int.Parse(txtYear.Text);
            int currentYear = DateTime.Now.Year;
            int age = currentYear - enteredYear;
            return age;
        }

        /// <summary>
        /// Get fullname with prefix
        /// </summary>
        private string GetFullName()
        {
            // get name prefix
            string namePrefix;

            if (radioFemale.Checked && cmbMaritalStatus.SelectedIndex is 1)
            {
                namePrefix = "Mrs.";
            }
            else if (radioFemale.Checked && cmbMaritalStatus.SelectedIndex is 2)
            {
                namePrefix = "Miss.";
            }
            else
            {
                namePrefix = "Mr.";
            }

            string fullName = namePrefix + " " + this.ToTitleCase(txtFullName.Text);
            return fullName;
        }

        /// <summary>
        /// Clear button on click event
        /// </summary>
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
