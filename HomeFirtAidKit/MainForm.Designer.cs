namespace HomeFirtAidKit
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMedicament = new System.Windows.Forms.TabPage();
            this.dataGridMedicament = new System.Windows.Forms.DataGridView();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.dataGridCategory = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabMedicament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).BeginInit();
            this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMedicament);
            this.tabControl.Controls.Add(this.tabCategory);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(890, 466);
            this.tabControl.TabIndex = 1;
            // 
            // tabMedicament
            // 
            this.tabMedicament.Controls.Add(this.dataGridMedicament);
            this.tabMedicament.Location = new System.Drawing.Point(4, 25);
            this.tabMedicament.Name = "tabMedicament";
            this.tabMedicament.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicament.Size = new System.Drawing.Size(882, 437);
            this.tabMedicament.TabIndex = 0;
            this.tabMedicament.Text = "Medicaments";
            this.tabMedicament.UseVisualStyleBackColor = true;
            // 
            // dataGridMedicament
            // 
            this.dataGridMedicament.AllowUserToAddRows = false;
            this.dataGridMedicament.AllowUserToDeleteRows = false;
            this.dataGridMedicament.AllowUserToResizeColumns = false;
            this.dataGridMedicament.AllowUserToResizeRows = false;
            this.dataGridMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicament.Location = new System.Drawing.Point(0, 0);
            this.dataGridMedicament.Name = "dataGridMedicament";
            this.dataGridMedicament.RowTemplate.Height = 24;
            this.dataGridMedicament.Size = new System.Drawing.Size(882, 434);
            this.dataGridMedicament.TabIndex = 0;
            this.dataGridMedicament.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicament_CellDoubleClick);
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.dataGridCategory);
            this.tabCategory.Location = new System.Drawing.Point(4, 25);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(882, 437);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Category";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridCategory
            // 
            this.dataGridCategory.AllowUserToAddRows = false;
            this.dataGridCategory.AllowUserToDeleteRows = false;
            this.dataGridCategory.AllowUserToResizeColumns = false;
            this.dataGridCategory.AllowUserToResizeRows = false;
            this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategory.Location = new System.Drawing.Point(0, 1);
            this.dataGridCategory.Name = "dataGridCategory";
            this.dataGridCategory.RowTemplate.Height = 24;
            this.dataGridCategory.Size = new System.Drawing.Size(882, 434);
            this.dataGridCategory.TabIndex = 1;
            this.dataGridCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategory_CellDoubleClick);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 472);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(101, 41);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 525);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "First-Aid Kit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMedicament.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).EndInit();
            this.tabCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMedicament;
        private System.Windows.Forms.DataGridView dataGridMedicament;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DataGridView dataGridCategory;
    }
}

