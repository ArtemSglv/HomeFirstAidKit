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
            this.dataGridMedicament = new System.Windows.Forms.DataGridView();
            this.dataGridSymptom = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.dataGridDisease = new System.Windows.Forms.DataGridView();
            this.butEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSymptom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisease)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMedicament
            // 
            this.dataGridMedicament.AllowUserToAddRows = false;
            this.dataGridMedicament.AllowUserToDeleteRows = false;
            this.dataGridMedicament.AllowUserToResizeColumns = false;
            this.dataGridMedicament.AllowUserToResizeRows = false;
            this.dataGridMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicament.Location = new System.Drawing.Point(9, 8);
            this.dataGridMedicament.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridMedicament.Name = "dataGridMedicament";
            this.dataGridMedicament.RowTemplate.Height = 24;
            this.dataGridMedicament.Size = new System.Drawing.Size(510, 370);
            this.dataGridMedicament.TabIndex = 0;
            this.dataGridMedicament.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicament_CellClick);
            this.dataGridMedicament.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicament_CellDoubleClick);
            // 
            // dataGridSymptom
            // 
            this.dataGridSymptom.AllowUserToAddRows = false;
            this.dataGridSymptom.AllowUserToDeleteRows = false;
            this.dataGridSymptom.AllowUserToResizeColumns = false;
            this.dataGridSymptom.AllowUserToResizeRows = false;
            this.dataGridSymptom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSymptom.Location = new System.Drawing.Point(524, 8);
            this.dataGridSymptom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridSymptom.Name = "dataGridSymptom";
            this.dataGridSymptom.RowTemplate.Height = 24;
            this.dataGridSymptom.Size = new System.Drawing.Size(252, 180);
            this.dataGridSymptom.TabIndex = 1;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(9, 384);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(76, 33);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // dataGridDisease
            // 
            this.dataGridDisease.AllowUserToAddRows = false;
            this.dataGridDisease.AllowUserToDeleteRows = false;
            this.dataGridDisease.AllowUserToResizeColumns = false;
            this.dataGridDisease.AllowUserToResizeRows = false;
            this.dataGridDisease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisease.Location = new System.Drawing.Point(524, 198);
            this.dataGridDisease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridDisease.Name = "dataGridDisease";
            this.dataGridDisease.RowTemplate.Height = 24;
            this.dataGridDisease.Size = new System.Drawing.Size(252, 180);
            this.dataGridDisease.TabIndex = 3;
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(98, 384);
            this.butEdit.Margin = new System.Windows.Forms.Padding(2);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(76, 33);
            this.butEdit.TabIndex = 4;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 427);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.dataGridDisease);
            this.Controls.Add(this.dataGridMedicament);
            this.Controls.Add(this.dataGridSymptom);
            this.Controls.Add(this.butAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "First-Aid Kit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSymptom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisease)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridMedicament;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DataGridView dataGridSymptom;
        private System.Windows.Forms.DataGridView dataGridDisease;
        private System.Windows.Forms.Button butEdit;
    }
}

