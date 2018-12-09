namespace KostaTest {
    partial class MainWindowV {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent() {
            this.tvScructCompany = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.lbListEmployee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tvScructCompany
            // 
            this.tvScructCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvScructCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvScructCompany.Location = new System.Drawing.Point(17, 31);
            this.tvScructCompany.Name = "tvScructCompany";
            this.tvScructCompany.Size = new System.Drawing.Size(208, 468);
            this.tvScructCompany.TabIndex = 0;
            this.tvScructCompany.TabStop = false;
            this.tvScructCompany.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvScructCompany_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Структура отделов:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сотрудники отдела:";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewEmployee.Location = new System.Drawing.Point(238, 464);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(309, 34);
            this.btnNewEmployee.TabIndex = 4;
            this.btnNewEmployee.Text = "Добавить сотрудника";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // lbListEmployee
            // 
            this.lbListEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbListEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbListEmployee.FormattingEnabled = true;
            this.lbListEmployee.ItemHeight = 20;
            this.lbListEmployee.Location = new System.Drawing.Point(238, 31);
            this.lbListEmployee.Name = "lbListEmployee";
            this.lbListEmployee.Size = new System.Drawing.Size(309, 424);
            this.lbListEmployee.TabIndex = 6;
            this.lbListEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbListEmployee_MouseDoubleClick);
            // 
            // MainWindowV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 508);
            this.Controls.Add(this.tvScructCompany);
            this.Controls.Add(this.lbListEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(575, 555);
            this.Name = "MainWindowV";
            this.Text = "БД пользователей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView tvScructCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnNewEmployee;
        public System.Windows.Forms.ListBox lbListEmployee;
    }
}

