using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    internal interface IDB
    {
        void Connect();

        void Disconnect();

        void Create();

        void Update(string id,
            System.Windows.Forms.TextBox textBox1,
            System.Windows.Forms.TextBox textBox2,
            System.Windows.Forms.TextBox textBox3,
            DateTimePicker dateTimePicker1,
            DateTimePicker dateTimePicker2,
            System.Windows.Forms.ComboBox comboBox1);

        void Write(DataGridView dataGridView1);

        void Insert(System.Windows.Forms.TextBox textBox1,
            System.Windows.Forms.TextBox textBox2,
            System.Windows.Forms.TextBox textBox3,
            DateTimePicker dateTimePicker1,
            DateTimePicker dateTimePicker2,
            System.Windows.Forms.ComboBox comboBox1);

        void Delete(string id);
    }
}
