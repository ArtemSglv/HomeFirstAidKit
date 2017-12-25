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
    public partial class EditDiseaseForm : Form
    {
        string dis_id = "";
        public EditDiseaseForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(ConnectionDB.Select("select dis.ID_disease, dis.Name from disease dis").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
            dis_id = comboBox1.SelectedItem.ToString().Split(' ')[0];
            textBoxName.Text = ConnectionDB.SelectOne("select Name from disease where ID_disease=" + dis_id);
        }

        private void butApply_Click(object sender, EventArgs e)
        {

            ConnectionDB.Update("update disease set Name= '" + textBoxName.Text + "' where ID_disease= " + dis_id);
            Close();
        }
    }
}
