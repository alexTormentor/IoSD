using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employees
{
    internal class DBM : IDB
    {
        private SQLiteConnection cnn;
        public void Connect()
        {
            cnn = new SQLiteConnection("Data Source=TEST.doc");
            cnn.Open();
        }

        public void Disconnect()
        {
            cnn.Close();
        }

        public void Create()
        {
            SQLiteCommand command = cnn.CreateCommand();
            command.CommandText = "create table if not exists Persons (id integer primary key, lastname text not null, firstname text not null, middlename text not null, birthdate text not null, worksfrom text not null, gender text not null);";
            command.ExecuteNonQuery();
        }

        public void Write(DataGridView dataGridView1)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select id, lastname, firstname, middlename,gender," +
                "birthdate, worksfrom from Persons", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void Insert(System.Windows.Forms.TextBox family,
            System.Windows.Forms.TextBox name,
            System.Windows.Forms.TextBox lastname,
            DateTimePicker birthdate,
            DateTimePicker worksfrom,
            System.Windows.Forms.ComboBox gender) 
        {
            SQLiteCommand cmd = new SQLiteCommand(
                    "insert into Persons (lastname, firstname, middlename," +
            "birthdate, worksfrom, gender) values ('" +
            family.Text + "','" + name.Text + "','" + lastname.Text + "','" +
            birthdate.Value.ToShortDateString() + "','" +
                    worksfrom.Value.ToShortDateString() + "','" +
                    gender.Text + "')", cnn);

            cmd.ExecuteNonQuery();
        }

        public void Delete(string id)
        {
            SQLiteCommand cmd = new SQLiteCommand(
                "delete from Persons where id = " + id, cnn);
            cmd.ExecuteNonQuery();
        }

        public void Update(string id,
            System.Windows.Forms.TextBox family,
            System.Windows.Forms.TextBox name,
            System.Windows.Forms.TextBox lastname,
            DateTimePicker birthdate,
            DateTimePicker worksfrom,
            System.Windows.Forms.ComboBox gender)
        {
            SQLiteCommand cmd = new SQLiteCommand(
                "update Persons set lastname = '" + family.Text + "'," +
                               "firstname = '" + name.Text + "'," +
                               "middlename = '" + lastname.Text + "'," +
                               "birthdate = '" + birthdate.Value.ToShortDateString() + "'," +
                               "worksfrom = '" + worksfrom.Value.ToShortDateString() + "', " +
                               "gender = '" + gender.Text + "' " +
                               "where id = " + id, cnn);
            cmd.ExecuteNonQuery();
        }
    }
}
