using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFirtAidKit
{
    public partial class AddSymptomForm : Form
    {
        public AddSymptomForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sym_id = int.Parse(ConnectionDB.Select("select max(ID_symptom) from symptom"));
            sym_id++;
            string sql = "insert into symptom values('" + sym_id + "','" + textBox1.Text + "')";
            ConnectionDB.Insert(sql);
            Close();
        }
    }
}
