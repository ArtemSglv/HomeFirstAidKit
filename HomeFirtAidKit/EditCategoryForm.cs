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
        string cat_id = "";
        public EditCategoryForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(ConnectionDB.Select("select cat.ID_cat, cat.Name from category cat").Split(new[] { '$' }, StringSplitOptions.RemoveEmptyEntries));
            cat_id = comboBox1.SelectedItem.ToString().Split(' ')[0];
            textBoxName.Text = ConnectionDB.SelectOne("select Name from category where ID_cat="+cat_id);
        }

        private void butApply_Click(object sender, EventArgs e)
        {            
            ConnectionDB.Update("update category set Name= '"+textBoxName.Text+"' where ID_cat= "+cat_id);
            Close();
        }
    }
}
