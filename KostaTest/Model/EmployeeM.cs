

using System.Linq;

namespace KostaTest.Model {
    public class EmployeeM {
        #region constructors
        public EmployeeM(Presenter.EmployeeP employeeP) {
            EmployeeP = employeeP;
            GetDepartments();
        }

        public EmployeeM(Presenter.EmployeeP employeeP, decimal idEmployee) {
            EmployeeP = employeeP;
            employeeP.SelectedEmployee = GetSelectedEEmployee(idEmployee);
        }
        #endregion

        #region vars
        public Presenter.EmployeeP EmployeeP { get; set; }
        #endregion

        #region methods

        private void GetDepartments() {
            using (CompanyContext cContext = new CompanyContext()) {
                foreach (Department department in cContext.Departments) {
                    EmployeeP.ListDepartments.Add(department.ID, department.Name);
                }
            }
        }

        private Employee GetSelectedEEmployee(decimal guid) {
            using (CompanyContext cContext = new CompanyContext()) {
                GetDepartments();
                foreach (Employee employee in cContext.Employees) {
                    if (guid == employee.ID) {
                        return employee;
                    }
                }
            }
            return null;
        }

        public void SavingNewDataEmployee(Employee dataEmployee) {
            using (CompanyContext companyContext = new CompanyContext()) {
                if (dataEmployee.ID == -1M) {
                    companyContext.Employees.Add(dataEmployee);
                }
                else {
                    companyContext.Employees
                        .Where(x => x.ID == dataEmployee.ID)
                        .ToList()
                        .ForEach(y => {
                            y.FirstName = dataEmployee.FirstName;
                            y.SurName = dataEmployee.SurName;
                            y.Patronymic = dataEmployee.Patronymic;
                            y.DateOfBirth = dataEmployee.DateOfBirth;
                            y.DocSeries = dataEmployee.DocSeries;
                            y.DocNumber = dataEmployee.DocNumber;
                            y.DepartmentID = dataEmployee.DepartmentID;
                            y.Position = dataEmployee.Position;
                        });
                }
                companyContext.SaveChanges();
            }
        }
        #endregion

    }
}
