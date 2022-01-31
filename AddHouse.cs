using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;

namespace TestWork2
{
    public partial class AddHouse : Form
    {
        private string ConnString { get; set; }

        private string Command { get; set; }

        public AddHouse(string connString)
        {
            InitializeComponent();

            ConnString = connString;
        }

        private void SetComboBox(ComboBox comboBox, string displayMember, string valueMember)
        {
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        private void AddHouse_Load(object sender, EventArgs e)
        {
            Command = @"select regions.id, typeLocality.prefix || ' ' || region as 'region' from regions
                        inner join typeLocality on (typeLocality.id = regions.type)";

            comboRegion.DataSource = SqliteHelper.SqliteExecuteReader(ConnString, Command, null);

            SetComboBox(comboRegion, "region", "id");
        }

        private void comboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Command = @"select localities.id, typeLocality.prefix||' '||locality as 'locality' from localities
                        inner join typeLocality on (typeLocality.id = localities.type)
                        where localities.region = @region";

            comboLocality.DataSource = SqliteHelper.SqliteExecuteReader(ConnString, 
                Command, new SQLiteParameter("@region", comboRegion.SelectedValue));

            SetComboBox(comboLocality, "locality", "id");

            Command = "select * from typeHouses";

            comboTypesHouses.DataSource = SqliteHelper.SqliteExecuteReader(ConnString, Command, null);

            SetComboBox(comboTypesHouses, "type", "id");
        }

        private void comboLocality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Command = @"select streets.id, typeStreets.prefix||' '||street as 'street' from streets
                        inner join typeStreets on (typeStreets.id = streets.type)
                        where streets.locality = @locality";

            comboStreet.DataSource = SqliteHelper.SqliteExecuteReader(ConnString,
                Command, new SQLiteParameter("@locality", comboLocality.SelectedValue));

            SetComboBox(comboStreet, "street", "id");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Command = $@"pragma recursive_triggers = true;
                            insert into houses(apartments, type, number, street) 
                            values(@apartments, @type, @number, @street)";

                List<SQLiteParameter> parms = new List<SQLiteParameter>()
                {
                    new SQLiteParameter("@apartments", (long)numAparts.Value),
                    new SQLiteParameter("@type", (long)comboTypesHouses.SelectedValue),
                    new SQLiteParameter("@number", (long)numOfHouse.Value),
                    new SQLiteParameter("@street", (long)comboStreet.SelectedValue)
                };

                SqliteHelper.SqliteExecute(ConnString, Command, parms.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
