using System.Windows.Forms;

namespace KostaTest {
    public partial class MainWindowV : Form {

        public Presenter.MainWindowP MainPresenter { get; set; }

        private BindingSource _bindListEmployee = new BindingSource();

        public MainWindowV() {
            InitializeComponent();
            MainPresenter = new Presenter.MainWindowP(this);
            _bindListEmployee.DataSource = MainPresenter.ListEmployee;
            lbListEmployee.DataSource = _bindListEmployee;
   
        }

        private void tvScructCompany_AfterSelect(object sender, TreeViewEventArgs e) {
            MainPresenter.ClickOnDepartment((string)e.Node.Tag);  
        }

        private void lbListEmployee_MouseDoubleClick(object sender, MouseEventArgs e) {
            int index = lbListEmployee.IndexFromPoint(e.Location);
            if(index != ListBox.NoMatches) {
                ListBox selectItem = sender as ListBox;
                Presenter.EmployeeBasicInfo item = selectItem.SelectedValue as Presenter.EmployeeBasicInfo;

                View.EmployeeV employeeForm = new View.EmployeeV(item.ID) {
                    Owner = this
                };
                employeeForm.Show();
            }
        }

        private void btnNewEmployee_Click(object sender, System.EventArgs e) {
            View.EmployeeV employeeForm = new View.EmployeeV {
                Owner = this
            };
            employeeForm.Show();
        }

    }
}
