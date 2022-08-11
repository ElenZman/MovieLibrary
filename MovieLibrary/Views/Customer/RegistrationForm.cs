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
    public partial class RegistrationForm : Form
    {
        private TableManager _manager;
        private AuthorizationForm _authorizationForm;

        public RegistrationForm(AuthorizationForm form)
        {
            InitializeComponent();
            _authorizationForm = form;
            _manager = TableManager.GetManager();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == string.Empty && tbLogin.Text == string.Empty)
            {
                lbPassEmpty.Text = "Empty";
                lbLoginEmpty.Text = "Empty";
                return;
            }
            else if (tbLogin.Text == string.Empty && tbPassword.Text != string.Empty)
            {
                lbLoginEmpty.Text = "Empty";
                return;
            }
            else if (tbPassword.Text == string.Empty && tbLogin.Text != string.Empty)
            {
                lbPassEmpty.Text = "Empty";
                return;
            }

            Registration registration = new Registration();
            if (registration.AddNewUsers(tbLogin.Text, tbPassword.Text))
            {
                lbInfo.Text = "User added successfully!";
                btnSignUp.Enabled = false;
                var userList = await _manager.userTable.GetAll();
                var user = (from users in userList
                            where users.Login == tbLogin.Text
                            select users).FirstOrDefault();
                if (user != null)
                {
                    UserWelcomeForm userWelcomeForm = new UserWelcomeForm(user, _authorizationForm, this);
                    userWelcomeForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    lbInfo.Text = "User not found.";
                }
            }
            else
                lbInfo.Text = "User already exists" +
                    Environment.NewLine + "or login is less than 4 characters.";
            //this.Close();

        }
    }
}

