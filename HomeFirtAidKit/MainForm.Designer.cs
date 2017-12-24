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
            this.dataGridMedicament.Location = new System.Drawing.Point(12, 10);
            this.dataGridMedicament.Name = "dataGridMedicament";
            this.dataGridMedicament.RowTemplate.Height = 24;
            this.dataGridMedicament.Size = new System.Drawing.Size(680, 456);
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
            this.dataGridSymptom.Location = new System.Drawing.Point(698, 10);
            this.dataGridSymptom.Name = "dataGridSymptom";
            this.dataGridSymptom.RowTemplate.Height = 24;
            this.dataGridSymptom.Size = new System.Drawing.Size(336, 222);
            this.dataGridSymptom.TabIndex = 1;
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
            // dataGridDisease
            // 
            this.dataGridDisease.AllowUserToAddRows = false;
            this.dataGridDisease.AllowUserToDeleteRows = false;
            this.dataGridDisease.AllowUserToResizeColumns = false;
            this.dataGridDisease.AllowUserToResizeRows = false;
            this.dataGridDisease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisease.Location = new System.Drawing.Point(698, 244);
            this.dataGridDisease.Name = "dataGridDisease";
            this.dataGridDisease.RowTemplate.Height = 24;
            this.dataGridDisease.Size = new System.Drawing.Size(336, 222);
            this.dataGridDisease.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 525);
            this.Controls.Add(this.dataGridDisease);
            this.Controls.Add(this.dataGridMedicament);
            this.Controls.Add(this.dataGridSymptom);
            this.Controls.Add(this.butAdd);
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
    }
}

