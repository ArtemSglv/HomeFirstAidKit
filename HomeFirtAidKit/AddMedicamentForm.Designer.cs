namespace HomeFirtAidKit
{
    partial class AddMedicamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIDMed = new System.Windows.Forms.Label();
            this.textBoxIDMed = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.labelIDCat = new System.Windows.Forms.Label();
            this.comboBoxIDCat = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelShelfLife = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxApp = new System.Windows.Forms.TextBox();
            this.labelApplic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIDMed
            // 
            this.labelIDMed.AutoSize = true;
            this.labelIDMed.Location = new System.Drawing.Point(12, 9);
            this.labelIDMed.Name = "labelIDMed";
            this.labelIDMed.Size = new System.Drawing.Size(52, 17);
            this.labelIDMed.TabIndex = 0;
            this.labelIDMed.Text = "ID Med";
            // 
            // textBoxIDMed
            // 
            this.textBoxIDMed.Location = new System.Drawing.Point(70, 6);
            this.textBoxIDMed.Name = "textBoxIDMed";
            this.textBoxIDMed.Size = new System.Drawing.Size(59, 22);
            this.textBoxIDMed.TabIndex = 1;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(249, 12);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(85, 138);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // labelIDCat
            // 
            this.labelIDCat.AutoSize = true;
            this.labelIDCat.Location = new System.Drawing.Point(12, 41);
            this.labelIDCat.Name = "labelIDCat";
            this.labelIDCat.Size = new System.Drawing.Size(46, 17);
            this.labelIDCat.TabIndex = 3;
            this.labelIDCat.Text = "ID Cat";
            // 
            // comboBoxIDCat
            // 
            this.comboBoxIDCat.FormattingEnabled = true;
            this.comboBoxIDCat.Location = new System.Drawing.Point(70, 38);
            this.comboBoxIDCat.Name = "comboBoxIDCat";
            this.comboBoxIDCat.Size = new System.Drawing.Size(99, 24);
            this.comboBoxIDCat.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(70, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(99, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelShelfLife
            // 
            this.labelShelfLife.AutoSize = true;
            this.labelShelfLife.Location = new System.Drawing.Point(12, 103);
            this.labelShelfLife.Name = "labelShelfLife";
            this.labelShelfLife.Size = new System.Drawing.Size(67, 17);
            this.labelShelfLife.TabIndex = 7;
            this.labelShelfLife.Text = "Shel fLife";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBoxApp
            // 
            this.textBoxApp.Location = new System.Drawing.Point(95, 131);
            this.textBoxApp.Name = "textBoxApp";
            this.textBoxApp.Size = new System.Drawing.Size(99, 22);
            this.textBoxApp.TabIndex = 10;
            // 
            // labelApplic
            // 
            this.labelApplic.AutoSize = true;
            this.labelApplic.Location = new System.Drawing.Point(12, 134);
            this.labelApplic.Name = "labelApplic";
            this.labelApplic.Size = new System.Drawing.Size(77, 17);
            this.labelApplic.TabIndex = 9;
            this.labelApplic.Text = "Application";
            // 
            // AddMedicamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 162);
            this.Controls.Add(this.textBoxApp);
            this.Controls.Add(this.labelApplic);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelShelfLife);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxIDCat);
            this.Controls.Add(this.labelIDCat);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.textBoxIDMed);
            this.Controls.Add(this.labelIDMed);
            this.Name = "AddMedicamentForm";
            this.Text = "New Medicament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDMed;
        private System.Windows.Forms.TextBox textBoxIDMed;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label labelIDCat;
        private System.Windows.Forms.ComboBox comboBoxIDCat;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelShelfLife;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxApp;
        private System.Windows.Forms.Label labelApplic;
    }
}