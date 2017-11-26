using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace HomeFirtAidKit
{
    public partial class MainForm : Form
    {
        
        MySqlDataAdapter mySqlDataAdapter;
        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectionDB.Connect();
            SelectTable("medicament");
            SelectTable("category");
        }

        

        void SelectTable(string tableName)
        {
            string sql = "select * from " + tableName;
            mySqlDataAdapter = new MySqlDataAdapter(sql, ConnectionDB.connection);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            if (tableName == "medicament")
                dataGridMedicament.DataSource = ds.Tables[0];
            else if(tableName=="category")
                dataGridCategory.DataSource = ds.Tables[0];
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectionDB.Close();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == tabMedicament.Name)
            {
                new AddMedicamentForm(dataGridCategory.Rows).ShowDialog();
                SelectTable("medicament");
            }
            else
            {
                new AddCategoryForm().ShowDialog();
                SelectTable("category");
            }
        }

        private void dataGridMedicament_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int curRow = dgv.CurrentCell.RowIndex;
            new EditCategoryForm(dgv[0, curRow].Value.ToString(), dgv[1, curRow].Value.ToString()).ShowDialog();
            SelectTable("category");

        }

        private void dataGridCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int curRow = dgv.CurrentCell.RowIndex;
            new EditCategoryForm(dgv[0,curRow].Value.ToString(), dgv[1, curRow].Value.ToString()).ShowDialog();
            SelectTable("category");
        }
    }
}
