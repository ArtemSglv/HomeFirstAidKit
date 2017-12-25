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
        public AddMedicamentForm()
        {
            InitializeComponent();
            //foreach (DataGridViewRow r in rows)
            comboBoxIDCat.Items.AddRange(ConnectionDB.Select("select cat.ID_cat, cat.Name from category cat").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
            comboBoxDis.Items.AddRange(ConnectionDB.Select("select dis.ID_disease, dis.Name from disease dis").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
            comboBoxSym.Items.AddRange(ConnectionDB.Select("select sym.ID_symptom, sym.Name from symptom sym").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            // (1,3,'парацетамол','15/10/19',null)
            string cat_id = comboBoxIDCat.SelectedItem.ToString().Split(' ')[0];
            //int len = comboBoxIDCat.SelectedItem.ToString().Length;
            string sql = "insert into MEDICAMENT values(" + textBoxIDMed.Text + "," +
                cat_id + ",'" + textBoxName.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yy") + "', null)";
            ConnectionDB.Insert(sql);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
