using ClassLibrary.DataAccess;
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

namespace MovieLibrary.Views.Admin
{
    public partial class ActorForm : Form
    {
        private Table _table;
        private readonly TableManager _manager;
        public ActorForm(Table table)
        {
            _table = table;
            _manager = TableManager.GetManager();
            InitializeComponent();
            lbTableName.Text = lbTableName.Text + " " + _table.TableName;
        }

        //функции добавления и редактирования объеденинены в одной кнопке
        //_manager.ModelProvider.GetModel() считывает из выбранного ряда DataGridView
        //и возвращает объект, если у объекта id = null, то будует выполнено добавление в базу данных,
        //если нет - то вызовется метод Update
        
        private async void btnUpsert_Click(object sender, EventArgs e)
        {
            int index = grid.CurrentRow.Index;
           
            var model = (Actor)_manager.modelProvider.GetModel(index, grid, _table.TableName);
            if (model.Id == null)
            {
                if (_manager.actorTable.Add(model))
                {
                    lbInfo.Text = "Item added successfully!";
                }
                else
                {
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
            }
            else
            {
                if (_manager.actorTable.Update(model))
                {
                    lbInfo.Text = "Item updated successfully!";
                }
                else
                {
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
            }

            grid.DataSource = await _table.ShowTableAsync();
            grid.CurrentCell = grid[0, grid.Rows.Count - 1];
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            int index = (int)grid.Rows[grid.CurrentRow.Index].Cells["id"].Value;
            var actorManager = _manager.actorTable;
            if (actorManager.Delete(index))
            {
                lbInfo.Text = "Item was deleted successfully!";
            }
            else
            {
                lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            grid.DataSource = await _table.ShowTableAsync();
            grid.CurrentCell = grid[0, grid.Rows.Count - 1];
        }

        
        //обновляет DataGridView, выводит всю таблицу
        private async void btnAll_Click_1(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.DataSource = await _table.ShowTableAsync();
            grid.CurrentCell = grid[0, grid.Rows.Count - 1];
        }

        private async void btnFind_Click_1(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;            
            //grid.DataSource = await _table.ShowTableAsync();
            grid.ClearSelection();

            string enteredValue = textBoxEnterValue.Text;
            string searchOption = comboBoxSearchOption.Text;

            if (searchOption == string.Empty)
            {
                lbInfo.Text = "Please choose a search option.";
                return;
            }
            if (enteredValue == string.Empty)
            {
                lbInfo.Text = "Please enter a value.";
                return;
            }

            var allActors = await _manager.actorTable.GetAll();
            if (allActors.Count > 0)
            {
                if (searchOption == "Actor's ID")
                {
                    int id;
                    if (int.TryParse(enteredValue, out id))
                    {
                        var actor = allActors.FirstOrDefault(x => x.Id == id);
                        if (actor != null)
                        {
                            //если перед поском по id вызывался поиск по имени, 
                            // то для него формировался новый DataGridView, так как результаты 
                            //поиска представляют собой список
                            //при поиске по id, так как он уникальный, ряд, содержащий, необходимые данныу
                            //подсвечивается и к нему скролится все содержимое
                            //Как проверить, что источником данных явялется именно эта таблица, 
                            //воизбежании повторного обращения к базе данных?????
                            grid.DataSource = null;
                            grid.Columns.Clear();
                            grid.DataSource = await _table.ShowTableAsync();
                            if (grid.Rows.Count > 0)
                            {
                                foreach (DataGridViewRow row in grid.Rows)
                                {
                                    if (row.Cells["id"].Value.ToString() == actor.Id.ToString())
                                    {

                                        grid.FirstDisplayedScrollingRowIndex = row.Index;
                                        grid.Rows[row.Index].Selected = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            lbInfo.Text = "ID was not found.";
                            return;
                        }
                    }

                    else
                    {
                        lbInfo.Text = "ID must be a number.";
                        return;
                    }
                }

                if (searchOption == "Actor's Name")
                {
                    var listOfActors = allActors.Where(x => x.Name.ToLower().Contains(enteredValue.ToLower())).ToList();

                    if (listOfActors.Count > 0)
                    {
                            //так как результатом поиска зачастую является список,
                            //именно он является источником данных для DataGridView 
                            grid.DataSource = null;
                            grid.Columns.Clear();
                            grid.Columns.Add("id", "Id");
                            grid.Columns.Add("value", "Name");
                            foreach (var actor in listOfActors)
                            {
                                grid.Rows.Add(new object[] { actor.Id, actor.Name });
                            } 
                        
                    }
                    else
                    {
                        lbInfo.Text = "Actor not found.";
                        return;
                    }
                }
            }
            else
            {
                lbInfo.Text = "Opps! Something went wrong!";
            }
            enteredValue = string.Empty;
            searchOption = string.Empty;
        }

        private async void ActorForm_Load(object sender, EventArgs e)
        {
            comboBoxSearchOption.Items.Add("Actor's Name");
            comboBoxSearchOption.Items.Add("Actor's ID");
            lbInfo.Text = string.Empty;
            grid.DataSource = await _table.ShowTableAsync();
            grid.CurrentCell = grid[0, grid.Rows.Count - 1];
        }
    }
}


