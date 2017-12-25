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
    public partial class AddDiseaseForm : Form
    {
        public AddDiseaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dis_id = int.Parse(ConnectionDB.Select("select max(ID_disease) from disease"));
            dis_id++;
            string sql = "insert into disease values('" + dis_id + "','" + textBox1.Text + "')";
            ConnectionDB.Insert(sql);
            Close();
        }
    }
}
