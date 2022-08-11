using ClassLibrary.Models;
using MovieLibrary.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Views.Customer
{
    public partial class AuthorizationForm : Form
    {

        private RegistrationForm _registrationForm;
        public AuthorizationForm()
        {
            InitializeComponent();
            tbLogin.AutoSize = true;
            tbPassword.AutoSize = false;
            tbPassword.Size = new Size(tbPassword.Width, 27);
            _registrationForm = new RegistrationForm(this);
        }

      

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            lbPassEmpty.Text = string.Empty;
            lbLoginEmpty.Text = string.Empty;
            lbInfo.Text = string.Empty;

            if (tbPassword.Text == string.Empty && tbLogin.Text == string.Empty)
            {
                lbPassEmpty.Text = "Empty";
                lbLoginEmpty.Text = "Empty";
                return;
            }
            else if (tbLogin.Text == string.Empty)
            {
                lbLoginEmpty.Text = "Empty";
                return;
            }
            else if (tbPassword.Text == string.Empty)
            {
                lbPassEmpty.Text = "Empty";
                return;
            }

            Entry entry = new Entry();
            User user = await entry.Enter(tbLogin.Text, tbPassword.Text);
            if (user != null)
            {
                if (user.Role == 1)
                {
                    UserWelcomeForm userWelcomeForm = new UserWelcomeForm(user, this, _registrationForm);
                    userWelcomeForm.Show();

                }

                else
                {
                    AdminForm form = new AdminForm(user, this);
                    form.Show();
                    this.Visible = false;
                }
            }
            else
                lbInfo.Text = "Wrong user name or password.";
            return;

        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            _registrationForm = new RegistrationForm(this);
            _registrationForm.ShowDialog();
        }
    }
}





