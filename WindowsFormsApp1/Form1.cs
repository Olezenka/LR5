using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List <Student>studGroup = new List<Student>();
            studGroup.Add(new Student { Name = "Иванов Саша", Id = 111 });
            studGroup.Add(new Student { Name = "Петров Витя", Id = 222 });
            studGroup.Add(new Student { Name = "Васильева Юля", Id = 333 });
            studGroup.Add(new Student { Name = "Гришин Костя", Id = 444 });
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";
            listBox1.DataSource = studGroup;
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listBox1.SelectedValue;
            MessageBox.Show(id.ToString());
        }
    }
}
