namespace KostaTest.View {
    partial class EmployeeV {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbDocSeries = new System.Windows.Forms.TextBox();
            this.tbDocNumber = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.btnSaveNChangeEmployee = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.dtpYearOld = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbYears = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Серия документа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер документа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Отдел:*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Должность:*";
            // 
            // tbFname
            // 
            this.tbFname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFname.Location = new System.Drawing.Point(12, 85);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(313, 27);
            this.tbFname.TabIndex = 9;
            this.tbFname.Leave += new System.EventHandler(this.tbFname_Leave);
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPatronymic.Location = new System.Drawing.Point(12, 146);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(313, 27);
            this.tbPatronymic.TabIndex = 10;
            this.tbPatronymic.Leave += new System.EventHandler(this.tbPatronymic_Leave);
            // 
            // tbDocSeries
            // 
            this.tbDocSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDocSeries.Location = new System.Drawing.Point(12, 259);
            this.tbDocSeries.Name = "tbDocSeries";
            this.tbDocSeries.Size = new System.Drawing.Size(313, 27);
            this.tbDocSeries.TabIndex = 12;
            this.tbDocSeries.Leave += new System.EventHandler(this.tbDocSeries_Leave);
            // 
            // tbDocNumber
            // 
            this.tbDocNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDocNumber.Location = new System.Drawing.Point(12, 312);
            this.tbDocNumber.Name = "tbDocNumber";
            this.tbDocNumber.Size = new System.Drawing.Size(313, 27);
            this.tbDocNumber.TabIndex = 13;
            this.tbDocNumber.Leave += new System.EventHandler(this.tbDocNumber_Leave);
            // 
            // tbPosition
            // 
            this.tbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPosition.Location = new System.Drawing.Point(12, 422);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(313, 27);
            this.tbPosition.TabIndex = 15;
            this.tbPosition.Leave += new System.EventHandler(this.tbPosition_Leave);
            // 
            // btnSaveNChangeEmployee
            // 
            this.btnSaveNChangeEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNChangeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveNChangeEmployee.Location = new System.Drawing.Point(12, 455);
            this.btnSaveNChangeEmployee.Name = "btnSaveNChangeEmployee";
            this.btnSaveNChangeEmployee.Size = new System.Drawing.Size(313, 32);
            this.btnSaveNChangeEmployee.TabIndex = 16;
            this.btnSaveNChangeEmployee.Text = "Изменить";
            this.btnSaveNChangeEmployee.UseVisualStyleBackColor = true;
            this.btnSaveNChangeEmployee.Click += new System.EventHandler(this.btnSaveNChangeEmployee_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(12, 368);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(313, 28);
            this.cbDepartment.TabIndex = 18;
            this.cbDepartment.Leave += new System.EventHandler(this.cbDepartment_Leave);
            // 
            // dtpYearOld
            // 
            this.dtpYearOld.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpYearOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpYearOld.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearOld.Location = new System.Drawing.Point(12, 206);
            this.dtpYearOld.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpYearOld.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpYearOld.Name = "dtpYearOld";
            this.dtpYearOld.Size = new System.Drawing.Size(124, 27);
            this.dtpYearOld.TabIndex = 19;
            this.dtpYearOld.Value = new System.DateTime(2018, 12, 8, 0, 0, 0, 0);
            this.dtpYearOld.Leave += new System.EventHandler(this.dtpYearOld_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(189, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Возраст:";
            // 
            // tbYears
            // 
            this.tbYears.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbYears.Location = new System.Drawing.Point(193, 208);
            this.tbYears.Name = "tbYears";
            this.tbYears.Size = new System.Drawing.Size(132, 27);
            this.tbYears.TabIndex = 21;
            // 
            // tbLname
            // 
            this.tbLname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLname.Location = new System.Drawing.Point(12, 31);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(313, 27);
            this.tbLname.TabIndex = 9;
            this.tbLname.Leave += new System.EventHandler(this.tbLname_Leave);
            // 
            // EmployeeV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 504);
            this.Controls.Add(this.tbYears);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpYearOld);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.btnSaveNChangeEmployee);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbDocNumber);
            this.Controls.Add(this.tbDocSeries);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(660, 551);
            this.MinimumSize = new System.Drawing.Size(360, 551);
            this.Name = "EmployeeV";
            this.Text = "Информация о сотруднике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveNChangeEmployee;
        public System.Windows.Forms.TextBox tbPosition;
        public System.Windows.Forms.ComboBox cbDepartment;
        public System.Windows.Forms.TextBox tbFname;
        public System.Windows.Forms.TextBox tbPatronymic;
        public System.Windows.Forms.TextBox tbDocSeries;
        public System.Windows.Forms.TextBox tbDocNumber;
        private System.Windows.Forms.DateTimePicker dtpYearOld;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbYears;
        public System.Windows.Forms.TextBox tbLname;
    }
}