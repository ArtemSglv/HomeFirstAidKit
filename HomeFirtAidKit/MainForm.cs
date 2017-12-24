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
        // symptom вместо id и болезьни по клику новые таблицы лекарства-болезни лекартсава- симптомы
        MySqlDataAdapter mySqlDataAdapter;
        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectionDB.Connect();
            SelectMedicaments();
        }



        void SelectMedicaments()
        {
            string sql = "select med.ID_med, med.Name, cat.Name as 'Category', med.Shelf_life, med.Application " +
                "from medicament med join category cat on med.ID_cat=cat.ID_cat";
            mySqlDataAdapter = new MySqlDataAdapter(sql, ConnectionDB.connection);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dataGridMedicament.DataSource = ds.Tables[0];
            dataGridMedicament.Columns[0].Visible = false;
        }

        void SelectDisease(string med_id)
        {
            string sql = "select dis.Name as 'Disease' from medicament_disease medDis " +
                "join medicament med on med.ID_med = medDis.ID_med " +
                "join disease dis on dis.ID_disease = medDis.ID_disease " +
                "where med.ID_med = " + med_id;
            mySqlDataAdapter = new MySqlDataAdapter(sql, ConnectionDB.connection);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dataGridDisease.DataSource = ds.Tables[0];
        }

        void SelectSymptom(string med_id)
        {
            string sql = "select sym.Name as 'Symptom' from medicament_symptom medSym " +
                "join medicament med on med.ID_med = medSym.ID_medicament " +
                "join symptom sym on sym.ID_symptom = medSym.ID_symptom " +
                "where med.ID_med = " + med_id;
            mySqlDataAdapter = new MySqlDataAdapter(sql, ConnectionDB.connection);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dataGridSymptom.DataSource = ds.Tables[0];
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectionDB.Close();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //if (tabControl.SelectedTab.Name == tabMedicament.Name)
            //{
            //    new AddMedicamentForm(dataGridSymptom.Rows).ShowDialog();
            //    SelectTable("medicament");
            //}
            //else
            //{
            //    new AddCategoryForm().ShowDialog();
            //    SelectTable("category");
            //}
            new ChangeTable().ShowDialog();
            SelectMedicaments();
        }

        private void dataGridMedicament_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = (DataGridView)sender;
            //int curRow = dgv.CurrentCell.RowIndex;
            //new EditCategoryForm(dgv[0, curRow].Value.ToString(), dgv[1, curRow].Value.ToString()).ShowDialog();
            //SelectTable("category");

        }

        private void dataGridMedicament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            string med_id = dgv[0, dgv.CurrentCell.RowIndex].Value.ToString();
            SelectDisease(med_id);
            SelectSymptom(med_id);
        }
    }
}
