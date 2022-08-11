using ClassLibrary.DataAccess;
using ClassLibrary.DataAccess.Interfaces;
using ClassLibrary.Models;
using ClassLibrary.Models.Interfaces;
using MovieLibrary.Views.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Views.Admin
{
    public partial class AdminForm : Form
    {
        private AuthorizationForm _authForm;
        private Table _table;
        private readonly TableManager _manager;
        private string _tableName;


        public AdminForm(User user, AuthorizationForm form)
        {
            InitializeComponent();
            _manager = TableManager.GetManager();
            _authForm = form;
            lbUserName.Text = user.Login + "!";

            comboBoxTableNames.Items.Add("Users");
            comboBoxTableNames.Items.Add("Roles");
            comboBoxTableNames.Items.Add("Comments");
            comboBoxTableNames.Items.Add("Films");
            comboBoxTableNames.Items.Add("Films_Actors");
            comboBoxTableNames.Items.Add("Genres");
            comboBoxTableNames.Items.Add("Actors");
            comboBoxTableNames.Items.Add("Countries");
            comboBoxTableNames.Items.Add("Directors");
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _authForm.Visible = true;
        }

        private void comboBoxTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbInfo.Text = string.Empty;
            _tableName = comboBoxTableNames.SelectedItem.ToString();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (_tableName != null)
            {
                string name = _tableName;
                if (name == "Countries")
                {
                    _table = _manager.countryTable;
                    CountryForm form = new CountryForm(_table);
                    form.Show();
                }
                if (name == "Actors")
                {
                    _table = _manager.actorTable;
                    ActorForm form = new ActorForm(_table);
                    form.Show();
                }
                if (name == "Films")
                {
                    _table = _manager.filmTable;
                    FilmForm form = new FilmForm(_table);
                    form.Show();
                    this.Close();
                }
                if (name == "Genres")
                {
                    _table = _manager.genreTable;
                    GenreForm form = new GenreForm(_table);
                    form.Show();
                }
                if (name == "Users")
                {
                    _table = _manager.userTable;
                    UserForm form = new UserForm(_table);
                    form.Show();
                }
                if (name == "Films_Actors")
                {
                    _table = _manager.filmsActorsTable;
                    FilmsActorsForm form = new FilmsActorsForm(_table);
                    form.Show();
                }
                if (name == "Comments")
                {
                    _table = _manager.commentTable;
                    CommentForm form = new CommentForm(_table);
                    form.Show();
                }

                if (name == "Directors")
                {
                    _table = _manager.directorTable;
                    DirectorForm form = new DirectorForm(_table);
                    form.Show();
                }

                if (name == "Roles")
                {
                    _table = _manager.rolesTable;
                    DirectorForm form = new DirectorForm(_table);
                    form.Show();
                }
                else
                {
                    lbInfo.Text = "There's no such table.";
                    return;
                }
            }
        }
    }
}



