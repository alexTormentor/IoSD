using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employees
{
    public partial class Form1 : Form
    {
        DBM dBM = new DBM();
        public Form1()
        {
            InitializeComponent();

            dBM.Connect();

            dBM.Create();
            dBM.Write(dataGrid);
            dBM.Disconnect();

            formSet();
        }

        private int timeValid()
        {
            TimeSpan ts = WorksFrom.Value - BirthDate.Value;

            if ((ts.TotalDays / 365) < 14 || BirthDate.Value.Year < 1900
                || WorksFrom.Value > DateTime.Now)
            {
                MessageBox.Show("Неправильно введены даты!");
                return 0;
            }
            return 1;
        }

        private void formSet()
        {
            dataGrid.Columns[0].Width = 30;
            dataGrid.Columns[1].Width = 100;
            dataGrid.Columns[1].HeaderText = "Фамилия";
            dataGrid.Columns[2].Width = 100;
            dataGrid.Columns[2].HeaderText = "Имя";
            dataGrid.Columns[3].Width = 100;
            dataGrid.Columns[3].HeaderText = "Отчество";
            dataGrid.Columns[4].Width = 40;
            dataGrid.Columns[4].HeaderText = "Пол";
            dataGrid.Columns[5].Width = 100;
            dataGrid.Columns[5].HeaderText = "Д.р.";
            dataGrid.Columns[6].Width = 100;
            dataGrid.Columns[6].HeaderText = "С";
        }

        private void Add(object sender, EventArgs e)
        {
            int valid = timeValid();

            if (valid == 1)
            {
                dBM.Connect();

                dBM.Insert(Family, NameBox, LastName, BirthDate, WorksFrom, Gender);

                dBM.Write(dataGrid);

                dBM.Disconnect();
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            string id = dataGrid.CurrentRow.Cells[0].Value.ToString();

            dBM.Connect();

            dBM.Delete(id);

            dBM.Write(dataGrid);

            dBM.Disconnect();
        }

        private void Update(object sender, EventArgs e)
        {
            TimeSpan ts = WorksFrom.Value - BirthDate.Value;
            if ((ts.TotalDays / 365) < 14 || BirthDate.Value.Year < 1900
                || WorksFrom.Value > DateTime.Now)
            {
                MessageBox.Show("Неправильно введены даты !");
                return;
            }

            string id = dataGrid.CurrentRow.Cells[0].Value.ToString();

            dBM.Connect();

            dBM.Update(id, Family, NameBox, LastName, BirthDate, WorksFrom, Gender);
            dBM.Write(dataGrid);
            dBM.Disconnect();
        }

        private void dataGridSelect(object sender, EventArgs e)
        {
            try
            {
                Family.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
                NameBox.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
                LastName.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
                Gender.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();
                BirthDate.Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
                WorksFrom.Text = dataGrid.CurrentRow.Cells[6].Value.ToString();
            }
            catch { };
        }

        private void dataGridMouseDouble(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGrid.CurrentRow.Cells[0].Value.ToString();
            DateTime now = DateTime.Now;
            DateTime born = DateTime.Parse(dataGrid.CurrentRow.Cells[5].Value.ToString());
            DateTime from = DateTime.Parse(dataGrid.CurrentRow.Cells[6].Value.ToString());
            Boolean man = dataGrid.CurrentRow.Cells[4].Value.ToString() == "М";
            DateTime toPens;
            if (man)
                toPens = born.AddYears(60);
            else
                toPens = born.AddYears(55);
            MessageBox.Show("Возраст : " + 
                (Convert.ToInt32((now - born).TotalDays / 365)).ToString() +
                "\nВыход на пенсию : " + toPens.ToShortDateString() +
                "\nСтаж работы (лет) : " + 
                (Convert.ToInt32((now - from).TotalDays / 365)).ToString() + 
                "\n" + (now > toPens ? "На" : "До") + " пенсии (лет) : " + 
                (Convert.ToInt32((now > toPens ? (now - toPens) :
                    (toPens - now)).TotalDays / 365)).ToString(), 
                dataGrid.CurrentRow.Cells[1].Value.ToString() + " " +
                dataGrid.CurrentRow.Cells[2].Value.ToString().Substring(0,1)+"." +
                dataGrid.CurrentRow.Cells[3].Value.ToString().Substring(0,1)+".");
        }

        private void Statistic(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.dt = (DataTable)dataGrid.DataSource;
            frm.Show();
        }
    }
}
