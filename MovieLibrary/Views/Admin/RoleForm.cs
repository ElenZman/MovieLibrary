using ClassLibrary.DataAccess;
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
    public partial class RoleForm : Form
    {
        private Table _table;
        public RoleForm(Table table)
        {
            _table = table;
            InitializeComponent();
            lbTableName.Text = lbTableName.Text +  " " + _table.TableName;
        }

        private async void btnAll_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.DataSource = await _table.ShowTableAsync();
            grid.CurrentCell = grid[0, grid.Rows.Count - 1];
        }
    }
}
