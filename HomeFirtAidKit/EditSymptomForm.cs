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
    public partial class EditSymptomForm : Form
    {
        string sym_id = "";
        public EditSymptomForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(ConnectionDB.Select("select sym.ID_symptom, sym.Name from symptom sym").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
            sym_id = comboBox1.SelectedItem.ToString().Split(' ')[0];
            textBoxName.Text = ConnectionDB.SelectOne("select Name from symptom where ID_symptom=" + sym_id);
        }

        private void butApply_Click(object sender, EventArgs e)
        {

            ConnectionDB.Update("update symptom set Name= '" + textBoxName.Text + "' where ID_symptom= " + sym_id);
            Close();
        }
    }
}
