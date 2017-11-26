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
    public partial class EditCategoryForm : Form
    {
        public EditCategoryForm(string id,string name)
        {
            InitializeComponent();
            textBoxID.Text = id;
            textBoxName.Text = name;
            textBoxID.Enabled = false;
        }

        private void butApply_Click(object sender, EventArgs e)
        {
            
            ConnectionDB.Update("update category set ID_cat= "+textBoxID.Text+", Name= '"+textBoxName.Text+"' where ID_cat= "+textBoxID.Text);
            Close();
        }
    }
}
