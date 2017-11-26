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
    public partial class AddMedicamentForm : Form
    {
        public AddMedicamentForm(DataGridViewRowCollection rows)
        {
            InitializeComponent();
            foreach (DataGridViewRow r in rows)
                comboBoxIDCat.Items.Add(r.Cells[0].Value+" - "+ r.Cells[1].Value);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            // (1,3,'парацетамол','15/10/19',null)
            int seek = comboBoxIDCat.SelectedItem.ToString().IndexOf("-");
            int len = comboBoxIDCat.SelectedItem.ToString().Length;
            string sql = "insert into MEDICAMENT values(" + textBoxIDMed.Text + "," +
                comboBoxIDCat.SelectedItem.ToString().Remove(seek-1,len+1-seek)+",'"+
                textBoxName.Text+"','"+ dateTimePicker1.Value.ToString("dd/MM/yy")+"',null)";
            ConnectionDB.Insert(sql);
            Close();
        }
    }
}
