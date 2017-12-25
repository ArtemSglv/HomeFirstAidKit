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
    public partial class ChangeTable2 : Form
    {
        public ChangeTable2()
        {
            InitializeComponent();
        }

        private void ChangeTable2_Load(object sender, EventArgs e)
        {
            comboBoxTable.Items.AddRange(new[] { "Medicaments", "Disease", "Symptom","Category" });
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTable.SelectedItem.ToString())
            {
                case "Medicaments": { new EditMedicamentForm().ShowDialog();  break; }
                case "Disease": { new EditDiseaseForm().ShowDialog(); break; }
                case "Symptom": { new EditSymptomForm().ShowDialog(); break; }
                case "Category": { new EditCategoryForm().ShowDialog(); break; }
            }
            Close();
        }
    }
}
