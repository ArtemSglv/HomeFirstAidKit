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
    public partial class AddCategoryForm : Form
    {

        public AddCategoryForm()
        {
            InitializeComponent();

        }
        

        private void butAdd_Click(object sender, EventArgs e)
        {
            int cat_id = int.Parse(ConnectionDB.Select("select max(ID_symptom) from symptom"));
            cat_id++;
            string sql="insert into category values('" + cat_id + "','" + textBoxName.Text + "')";
            ConnectionDB.Insert(sql);
            Close();
        }
    }
}
