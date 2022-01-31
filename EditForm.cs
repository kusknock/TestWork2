using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestWork2
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            InitializeTables();
        }

        private string ConnString { get; set; }

        private List<string> FilterElements { get; set; }

        private Dictionary<string, string> tables;

        private Dictionary<string, string> sortChar 
            = new Dictionary<string, string>()
            {
                { "↓", "ASC" },
                { "↑", "DESC" },
            };

        private void RefreshDateTable(string connString, string tableName,
            BindingSource bindingSource)
        {
            string command = $"select * from {tableName}";

            bindingSource.DataSource = SqliteHelper.SqliteExecuteReader(connString, command);
        }

        private string FilterExpressionBuilder(string city, int apartFrom, int apartTo)
        {
            string filter = string.Empty;

            if (checkApartNum.Checked)
                FilterElements.Add($"[Кол-во квартир] >= {apartFrom} AND [Кол-во квартир] <= {apartTo}");

            if (!string.IsNullOrWhiteSpace(comboCities.Text))
                FilterElements.Add($"[Населенный пункт] LIKE '{comboCities.Text}'");

            filter = FilterElements[0];

            for (int i = 1; i < FilterElements.Count - 1; i++)
                filter += " AND " + FilterElements[1];

            FilterElements.Clear();

            return filter;
        }

        private void LoadDataTable(string tableName, DataGridView dataGridView,
            BindingSource bindingSource, bool isUseforeignKeys = false)
        {
            dataGridView.DataSource = bindingSource;

            RefreshDateTable(ConnString, tableName, bindingSource);

            if (!isUseforeignKeys)
                return;

            var foreignKeys = SqliteHelper.GetForeignKeysList(ConnString, tableName);

            foreach (string[] key in foreignKeys)
            {
                var dt = SqliteHelper.SqliteExecuteReader(ConnString, string.Format($"select * from {key[0]}"), null);

                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn()
                {
                    Name = dataGridView.Columns[key[1]].Name,
                    HeaderText = dataGridView.Columns[key[1]].HeaderText,
                    DataPropertyName = dataGridView.Columns[key[1]].DataPropertyName,
                    DataSource = new BindingSource(dt, null),
                    DisplayMember = key[1],
                    ValueMember = key[2]
                };

                dataGridView.Columns.Remove(key[1]);

                dataGridView.Columns.Add(column);
            }
        }

        private void UpdateDataTable(string tableName, BindingSource bindingSource)
        {
            string command = $"select * from {tableName}";

            SqliteHelper.UpdateData(ConnString, command, (DataTable)bindingSource.DataSource);
        }

        private void btnOpenDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Data Base File|*.db|All formats|*.*",
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            ConnString = SqliteHelper.SqliteConnectionString(ofd.FileName);

            LoadDataTable("regions", dataGridView1, bindingSource1, true);

            LoadDataTable("houses_view", dataGridView2, bindingSource2);

            FilterElements = new List<string>();

            var cities = (bindingSource2.DataSource as DataTable).AsEnumerable()
                .Select(x => x["Населенный пункт"].ToString()).Distinct().ToList();

            cities.Insert(0, string.Empty);

            comboCities.DataSource = new BindingSource(cities, null);

            bindingNavigator1.Enabled = true;

            contextMenuStrip1.Enabled = true;

            groupFilter.Enabled = true;

            cmbTables.SelectedIndex = 0;
        }

        #region Filter

        private void linkSort_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bindingSource2.Sort = $"Кол-во квартир {sortChar[Regex.Replace(linkSort.Text, "[^↓↑]+", string.Empty)]}";

            linkSort.Text = Regex.Match(linkSort.Text, "[↓↑]").Value == "↓" ? 
                "Сортировать по количеству квартир ↑" : "Сортировать по количеству квартир ↓";
        }

        private void btnAcceptFilter_Click(object sender, EventArgs e)
        {
            bindingSource2.Filter = FilterExpressionBuilder(comboCities.Text, (int)numFrom.Value, (int)numTo.Value);
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            bindingSource2.Filter = string.Empty;
            bindingSource2.Sort = string.Empty;
        }

        private void btnEditOwners_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;

            long value = (long)dataGridView2.Rows[row].Cells[0].Value;

            EditOwners edit = new EditOwners((int)value, ConnString);

            edit.Show();
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            AddHouse add = new AddHouse(ConnString);

            add.Show();
        }

        private void btnDeleteHouse_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;

            long id = (long)dataGridView2.Rows[row].Cells[0].Value;

            string commandString = "delete from houses where id = @id";

            SqliteHelper.SqliteExecute(ConnString, commandString, new SQLiteParameter("@id", id));

            btnRefreshDb.PerformClick();
        }

        #endregion

        #region EditDataBase

        private void InitializeTables()
        {
            tables = new Dictionary<string, string>()
            {
                { "Дома", "houses" },
                { "Улицы", "streets" },
                { "Регионы", "regions" },
                { "Населенные пункты", "localities" },
                { "Собственники", "owners" },
            };
        }

        private void btnRefreshDb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;

            if (((DataTable)bindingSource1.DataSource).GetChanges() != null)
                dialogResult = MessageBox.Show("Все неподтвержденные изменения будут утеряны!\nПродолжить?", 
                    "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
                return;

            RefreshDateTable(ConnString, tables[(string)cmbTables.Items[cmbTables.SelectedIndex]], bindingSource1);

            RefreshDateTable(ConnString, "houses_view", bindingSource2);
        }

        private void btnCancelDb_Click(object sender, EventArgs e)
        {
            RefreshDateTable(ConnString, tables[(string)cmbTables.Items[cmbTables.SelectedIndex]], bindingSource1);
        }

        private void btnAcceptDb_Click(object sender, EventArgs e)
        {
            UpdateDataTable(tables[(string)cmbTables.Items[cmbTables.SelectedIndex]], bindingSource1);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                dataGridView1.EndEdit();
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataTable(tables[(string)cmbTables.Items[cmbTables.SelectedIndex]], dataGridView1, bindingSource1, true);
        }


        #endregion


    }
}
