using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KostaTest.Presenter {
    public class MainWindowP : INotifyPropertyChanged{
        public MainWindowP(MainWindowV mainView) {
            MainView = mainView;
            MainModel = new Model.MainWindowM(this);
            MainView.lbListEmployee.DataSource = ListEmployee;
        }
        #region vars
        public MainWindowV MainView { get; set; }
        public Model.MainWindowM MainModel { get; set; }

        private TreeNode _structCompany = new TreeNode();
        public TreeNode StructCompany {
            get { return _structCompany; }
            set { _structCompany = value;
                MainView.tvScructCompany.Nodes.Add(value); }
        }

        private BindingList<EmployeeBasicInfo> _listEmployee = new BindingList<EmployeeBasicInfo>();

        public BindingList<EmployeeBasicInfo> ListEmployee {
            get { return _listEmployee; }
            set { _listEmployee = value; MainView.lbListEmployee.Invalidate(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private void NotifyPropertyChanged([CallerMemberName] string propName ="") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public void ClickOnDepartment(string idDepartment) {
            ListEmployee.Clear();
            MainModel.GetEmployeeDepartment(idDepartment);
            foreach (Model.Employee  empl in MainModel.ListEmployee) {
                ListEmployee.Add(new EmployeeBasicInfo(empl.SurName, empl.FirstName, empl.Patronymic, empl.ID));
            }
        }
    }
    // Класс отображения в ListBox
    public class EmployeeBasicInfo{
        public string FName { get; set; }
        public string LName { get; set; }
        public string Patronymic { get; set; }
        public decimal ID { get; set; }

        public EmployeeBasicInfo(string fname, string lname, string patronymic, decimal id) {
            FName = fname;
            LName = lname;
            Patronymic = patronymic;
            ID = id;
        }

        public override string ToString() {
            return FName + " " + LName + " " + Patronymic; 
        }
    } 
}
