using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;

namespace TestWork2
{
    public partial class EditOwners : Form
    {
        private int House { get; set; }

        private string ConnString { get; set; }

        public EditOwners(int house, string connString)
        {
            House = house;

            ConnString = connString;

            InitializeComponent();
        }

        private void EditOwners_Load(object sender, EventArgs e)
        {
            string cmdText = $@"select 
                apartmentsOwners.owner as id, apartmentsOwners.apartment as apartment, 
                typeLocality.prefix||' '||localities.locality ||' '|| typeStreets.prefix ||' '|| 
                streets.street ||'  д. '|| houses.number ||' кв. '|| apartments.apartment as 'address'
                from apartmentsOwners
                inner join owners on (owners.id = apartmentsOwners.owner)
                inner join apartments on (apartments.id = apartmentsOwners.apartment)
                inner join houses on (houses.id = apartments.house)
                inner join streets on(streets.id = houses.street)
                inner join localities on (localities.id = streets.locality)
                inner join typeLocality on (typeLocality.id= localities.type)
                inner join typeStreets on (typeStreets.id= streets.type)
            where houses.id = @house;";

            dataGridView2.DataSource = SqliteHelper.SqliteExecuteReader(ConnString,
                cmdText, new SQLiteParameter("@house", House));

            var dt = SqliteHelper.SqliteExecuteReader(ConnString, string.Format($"select * from owners"), null);

            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn()
            {
                Name = dataGridView2.Columns["id"].Name,
                HeaderText = dataGridView2.Columns["id"].HeaderText,
                DataPropertyName = dataGridView2.Columns["id"].DataPropertyName,
                DataSource = new BindingSource(dt, null),
                DisplayMember = "owner",
                ValueMember = "id"
            };

            dataGridView2.Columns.Remove("id");

            dataGridView2.Columns.Add(column);
        }

        private void btnAcceptEdit_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();

            var dt = ((DataTable)dataGridView2.DataSource).GetChanges();

            if (dt == null)
                return;

            foreach (DataRow row in ((DataTable)dataGridView2.DataSource).Rows)
            {
                string cmdText = $"update apartmentsOwners set owner = {row["id"]} where apartment = {row["apartment"]}";
                SqliteHelper.SqliteExecute(ConnString, cmdText, null);
            }
        }

        private void btnRefreshBtn_Click(object sender, EventArgs e)
        {
            string cmdText = $@"select 
                apartmentsOwners.owner as id, apartmentsOwners.apartment as apartment, 
                typeLocality.prefix||' '||localities.locality ||' '|| typeStreets.prefix ||' '|| 
                streets.street ||'  д. '|| houses.number ||' кв. '|| apartments.apartment as 'address'
                from apartmentsOwners
                inner join owners on (owners.id = apartmentsOwners.owner)
                inner join apartments on (apartments.id = apartmentsOwners.apartment)
                inner join houses on (houses.id = apartments.house)
                inner join streets on(streets.id = houses.street)
                inner join localities on (localities.id = streets.locality)
                inner join typeLocality on (typeLocality.id= localities.type)
                inner join typeStreets on (typeStreets.id= streets.type)
            where houses.id = @house;";

            dataGridView2.DataSource = SqliteHelper.SqliteExecuteReader(ConnString,
                cmdText, new SQLiteParameter("@house", House));
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;

            long id = (long)dataGridView2.Rows[row].Cells[0].Value;

            string cmdText = $"insert into apartmentsOwners (owner, apartment) values (@owner, @apartment);";

            List<SQLiteParameter> parms = new List<SQLiteParameter>()
            {
                new SQLiteParameter("@owner", 1),
                new SQLiteParameter("@apartment", id)
            };

            SqliteHelper.SqliteExecute(ConnString, cmdText, parms.ToArray());

            btnRefreshBtn.PerformClick();
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.CurrentCell.RowIndex;

            long owner = (long)dataGridView2.Rows[row].Cells["id"].Value;

            long apartment = (long)dataGridView2.Rows[row].Cells["apartment"].Value;

            string cmdText = $"delete from apartmentsOwners where owner = @owner and apartment = @apartment;";

            List<SQLiteParameter> parms = new List<SQLiteParameter>()
            {
                new SQLiteParameter("@owner", owner),
                new SQLiteParameter("@apartment", apartment)
            };

            SqliteHelper.SqliteExecute(ConnString, cmdText, parms.ToArray());

            btnRefreshBtn.PerformClick();
        }
    }
}
