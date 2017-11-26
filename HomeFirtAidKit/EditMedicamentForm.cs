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
    public partial class EditMedicamentForm : Form
    {
        public EditMedicamentForm()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into MEDICAMENT values('" + textBoxIDMed.Text + "','" + textBoxName.Text + "')";
            ConnectionDB.Insert(sql);
            Close();
        }
    }
}
