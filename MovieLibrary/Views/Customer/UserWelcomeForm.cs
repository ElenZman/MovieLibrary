using ClassLibrary.Models;
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
    public partial class UserWelcomeForm : Form
    {

        private AuthorizationForm _authorizationForm;
        private RegistrationForm _registrationForm;
        private readonly TableManager _manager;
        private SearchResultForm _userSearchResultform;
        private User _user;
        public UserWelcomeForm(User user, AuthorizationForm formAuth, RegistrationForm formReg)
        {
            _user = user;
            _manager = TableManager.GetManager();
            _authorizationForm = formAuth;
            _registrationForm = formReg;
            InitializeComponent();
        }

        private void UserWelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _authorizationForm.Visible = true;
        }

        private async void UserWelcomeForm_Load_1(object sender, EventArgs e)
        {
            _authorizationForm.Visible = false;
            _registrationForm.Close();
            lbGreetings.Text = "Hi, " + _user.Login + "!";
            lbWelcome.Text = "Welcome to our Film Library." + "\n" + "Choose a movie to your taste and enjoy your time!";
           //combobox autocomplete
            List<Actor> allActors = await _manager.actorTable.GetAll();
            var actorsNames = (from actor in allActors
                          select actor.Name).ToList();
            var autoCompleteActors = new AutoCompleteStringCollection();
            autoCompleteActors.AddRange(actorsNames.ToArray());
            cBoxActors.AutoCompleteCustomSource = autoCompleteActors;
            cBoxActors.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cBoxActors.AutoCompleteMode = AutoCompleteMode.Suggest;

            cBoxActors.DisplayMember = "Name";
            cBoxActors.ValueMember = "Id";
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            cBoxActors.Enabled = true;
            tbUserInput.Text = string.Empty;
            
        }

        private void tbUserInput_Enter(object sender, EventArgs e)
        {
            tbUserInput.Enabled = true;
            cBoxActors.Text = string.Empty;
            
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string filmName = string.Empty;
            string actorName = string.Empty;
            if (tbUserInput.Text == string.Empty && cBoxActors.Text == string.Empty) return;
            if (tbUserInput.Text != string.Empty && cBoxActors.Text == string.Empty)
            {
                filmName = tbUserInput.Text;
                if (filmName == string.Empty)
                {
                    tbUserInput.BackColor = Color.Red;
                    return;
                }

                var allFilms = await _manager.filmTable.GetAll();
                var selectedFilms = allFilms.FindAll(x => x.Name.ToLower().Contains(filmName.ToLower())).ToList();

                if (selectedFilms != null && selectedFilms.Count > 0)
                {
                    _userSearchResultform = new SearchResultForm(selectedFilms, this, _user);
                    _userSearchResultform.Show();
                    this.Visible = false;
                }
                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }
            }

            if (tbUserInput.Text == string.Empty && cBoxActors.Text != string.Empty)
            {
                actorName = cBoxActors.Text;
                var allActors = await _manager.actorTable.GetAll();
                var actorId = allActors.Find(u => u.Name == actorName).Id;


                if (actorId != null)
                {
                    var allFilms = await _manager.filmTable.GetAll();
                    var selectedFilms = allFilms.FindAll(x => x.Id == actorId).ToList();
                    _userSearchResultform = new SearchResultForm(selectedFilms, this, _user);
                    _userSearchResultform.Show();
                    this.Visible = false;
                }
                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }
            }

        }
    }
}