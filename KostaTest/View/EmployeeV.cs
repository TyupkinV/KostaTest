using System;
using System.Windows.Forms;

namespace KostaTest.View {
    public partial class EmployeeV : Form {

        #region vars
        public Presenter.EmployeeP EmployeePObj { get; set; }
        #endregion

        public EmployeeV(decimal id = -1M) {
            InitializeComponent();
            if(id == -1M) {
                EmployeePObj = new Presenter.EmployeeP(this);
                btnSaveNChangeEmployee.Text = "Добавить";
            }
            else {
                EmployeePObj = new Presenter.EmployeeP(this, id);
            }
            tbFname.DataBindings.Add("Text", EmployeePObj.SelectedEmployee, "FirstName", false);
            tbLname.DataBindings.Add("Text", EmployeePObj.SelectedEmployee, "SurName", false);
            tbPatronymic.DataBindings.Add("Text", EmployeePObj.SelectedEmployee, "Patronymic", false);
            dtpYearOld.DataBindings.Add("Value", EmployeePObj.SelectedEmployee, "DateOfBirth", false);
            DateTime zeroTime = new DateTime(1, 1, 1);
            tbYears.Text = ((zeroTime + (DateTime.Today - EmployeePObj.SelectedEmployee.DateOfBirth)).Year - 1).ToString();
            tbDocSeries.DataBindings.Add("Text", EmployeePObj.SelectedEmployee, "DocSeries", false);
            tbDocNumber.DataBindings.Add("Text", EmployeePObj.SelectedEmployee, "DocNumber", false);
            tbPosition.DataBindings.Add("Text", EmployeePObj.SelectedEmployee, "Position", false);
            cbDepartment.DataBindings.Add("SelectedValue", EmployeePObj.SelectedEmployee, "DepartmentID", false);
            cbDepartment.DataSource = new BindingSource(EmployeePObj.ListDepartments, null);
            cbDepartment.DisplayMember = "Value";
            cbDepartment.ValueMember = "Key";
        }

        private void btnSaveNChangeEmployee_Click(object sender, EventArgs e) {
            Button button = sender as Button;
            if (button.Text == "Изменить") {
                button.Text = "Сохранить";
                EmployeePObj.ChangeEmployee();
            }
            else {
                button.Text = "Изменить";
                EmployeePObj.SaveEmployee();
                MainWindowV form = Owner as MainWindowV;
                form.MainPresenter.ClickOnDepartment((string)form.tvScructCompany.SelectedNode.Tag);
                Close();
            }
        }

        private void tbLname_Leave(object sender, EventArgs e) {
            TextBox textBox = sender as TextBox;
            if (!EmployeePObj.LenghtValidation(textBox.Text, 2, 50) || !EmployeePObj.LetterValidation(textBox.Text)) {
                ActiveControl = textBox;
            }
        }

        private void tbFname_Leave(object sender, EventArgs e) {
            TextBox textBox = sender as TextBox;
            if (!EmployeePObj.LenghtValidation(textBox.Text, 2, 50) || !EmployeePObj.LetterValidation(textBox.Text)) {
                ActiveControl = textBox;
            }
        }

        private void tbPatronymic_Leave(object sender, EventArgs e) {
            TextBox textBox = sender as TextBox;
            if (!EmployeePObj.LenghtValidation(textBox.Text, 0, 50) || !EmployeePObj.LetterValidation(textBox.Text)) {
                ActiveControl = textBox;
            }
        }

        private void dtpYearOld_Leave(object sender, EventArgs e) {
            DateTimePicker dateTimePicker = sender as DateTimePicker;
            if (!EmployeePObj.DateValidation(dateTimePicker.Value)) {
                ActiveControl = dateTimePicker;
            }
        }

        private void tbDocSeries_Leave(object sender, EventArgs e) {
            TextBox textBox = sender as TextBox;
            if (!EmployeePObj.DigitValidation(textBox.Text)) {
                ActiveControl = textBox;
            }
        }

        private void tbDocNumber_Leave(object sender, EventArgs e) {
            TextBox textBox = sender as TextBox;
            if (!EmployeePObj.DigitValidation(textBox.Text)) {
                ActiveControl = textBox;
            }

        }

        private void cbDepartment_Leave(object sender, EventArgs e) {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedText == "") {
                ActiveControl = comboBox;
                MessageBox.Show("Департамент не выбран");
            }
        }

        private void tbPosition_Leave(object sender, EventArgs e) {
            TextBox textBox = sender as TextBox;
            if (!EmployeePObj.LenghtValidation(textBox.Text, 1, 50) || !EmployeePObj.LetterValidation(textBox.Text)) {
                ActiveControl = textBox;
            }
        }
    }
}
