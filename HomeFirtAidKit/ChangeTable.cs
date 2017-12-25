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
    public partial class ChangeTable : Form
    {
        public ChangeTable()
        {
            InitializeComponent();
        }

        private void ChangeTable_Load(object sender, EventArgs e)
        {
            comboBoxTable.Items.AddRange(new[] { "Medicaments", "Disease", "Symptom","Category" });
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTable.SelectedItem.ToString())
            {
                case "Medicaments": { new AddMedicamentForm().ShowDialog();  break; }
                case "Disease": { new AddDiseaseForm().ShowDialog(); break; }
                case "Symptom": { new AddSymptomForm().ShowDialog(); break; }
                case "Category": { new AddCategoryForm().ShowDialog(); break; }
            }
            Close();
        }
    }
}
