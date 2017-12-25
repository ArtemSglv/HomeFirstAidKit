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

            comboBoxIDCat.Items.AddRange(ConnectionDB.Select("select cat.ID_cat, cat.Name from category cat").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
            comboBoxDis.Items.AddRange(ConnectionDB.Select("select dis.ID_disease, dis.Name from disease dis").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
            comboBoxSym.Items.AddRange(ConnectionDB.Select("select sym.ID_symptom, sym.Name from symptom sym").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            // (1,3,'парацетамол','15/10/19',null)
            string cat_id = comboBoxIDCat.SelectedItem.ToString().Split(' ')[0];
            string sym_id = comboBoxDis.SelectedItem.ToString().Split(' ')[0];
            string dis_id = comboBoxSym.SelectedItem.ToString().Split(' ')[0];

            int med_id = int.Parse(ConnectionDB.SelectOne("select max(ID_med) from medicament"));
            med_id++;
            string sql = "insert into MEDICAMENT values(" + med_id + "," +
                cat_id + ",'" + textBoxName.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yy") + "', null)";
            string sql1 = "insert into medicament_disease values(" + med_id + "," + dis_id +")";
            string sql2 = "insert into MEDICAMENT values(" + med_id + "," +sym_id + ")";
            ConnectionDB.Insert(sql);
            ConnectionDB.Insert(sql1);
            ConnectionDB.Insert(sql2);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
