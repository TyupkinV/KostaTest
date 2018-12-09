using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KostaTest.Presenter {
    public class EmployeeP : INotifyPropertyChanged {

        public EmployeeP(View.EmployeeV employeeWindow, decimal id) {
            EmployeeViewObj = employeeWindow;
            EmployeeModelObj = new Model.EmployeeM(this, id);
            foreach(Control control in EmployeeViewObj.Controls) {
                if (control is TextBox) {
                    ((TextBox)control).ReadOnly = true;
                }
                else if(control is DateTimePicker) {
                    ((DateTimePicker)control).Enabled = false;
                }
                else if (control is ComboBox) {
                    ((ComboBox)control).Enabled = false;
                }
            }
        }

        public EmployeeP(View.EmployeeV employeeWindow) {
            EmployeeViewObj = employeeWindow;
            EmployeeModelObj = new Model.EmployeeM(this);
        }

        #region vars

        public View.EmployeeV EmployeeViewObj { get; set; }
        public Model.EmployeeM EmployeeModelObj { get; set; }
        private Model.Employee _selectedEmployee = new Model.Employee { DateOfBirth = DateTime.Today, ID = -1M};
        public Model.Employee SelectedEmployee {
            get { return _selectedEmployee; }
            set { _selectedEmployee = value; NotifyPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Dictionary<Guid, string> ListDepartments { get; set; } = new Dictionary<Guid, string>();
        #endregion

        private void NotifyPropertyChanged([CallerMemberName] string propName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public void SaveEmployee() {
            EmployeeModelObj.SavingNewDataEmployee(SelectedEmployee);
        }

        public void ChangeEmployee() {
            foreach (Control control in EmployeeViewObj.Controls) {
                if (control is TextBox) {
                    ((TextBox)control).ReadOnly = false;
                }
                else if (control is DateTimePicker) {
                    ((DateTimePicker)control).Enabled = true;
                }
                else if (control is ComboBox) {
                    ((ComboBox)control).Enabled = true;
                }
            }
        }

        #region validators
        public bool LenghtValidation(string text, int minLen, int maxLen) {
            if ( text.Length < minLen || text.Length > maxLen) {
                MessageBox.Show("Длина текста должна быть: " + minLen + "-" + maxLen + "("+ text.Length + ")");
                return false;
            }
            return true;
        }

        public bool DigitValidation(string text) {
            if (System.Text.RegularExpressions.Regex.IsMatch(text, "[^0-9]")) {
                MessageBox.Show("Допустимые символы: 0-9");
                return false;
            }
            return true;
        }

        public bool LetterValidation(string text) {
            if (System.Text.RegularExpressions.Regex.IsMatch(text, "[^а-яА-Я]")) {
                MessageBox.Show("Допустимы только символы русского алфавита");
                return false;
            }
            return true;
        }

        public bool DateValidation(DateTime date) {
            if (date.CompareTo(DateTime.Today) >= 0) {
                MessageBox.Show("Некорректная дата!");
                return false;
            }
            return true;
        }
        public bool DepartmentValidation(string text) {
            if (text == "") {
                MessageBox.Show("Департамент не выбран!");
                return false;
            }
            return true;
        }

        #endregion
    }
}
