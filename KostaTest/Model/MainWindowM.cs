using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace KostaTest.Model {
    public class MainWindowM {

        #region vars
        private Presenter.MainWindowP MainPresenter { get; set; }
        public List<Employee> ListEmployee { get; set; } = new List<Employee>();
        #endregion

        public MainWindowM(Presenter.MainWindowP mainWindowP) {
            MainPresenter = mainWindowP;
            ImportDbData();
        }

        public void ImportDbData() {
            try {
                using (CompanyContext dbContext = new CompanyContext()) {
                    Department root = dbContext.Departments.FirstOrDefault();
                    TreeNode test = new TreeNode {
                        Text = root.Name,
                        Tag = root.ID.ToString()
                    };
                    MainPresenter.StructCompany = CreateHierarchy(root.ID.ToString(), dbContext.Departments, test);
                }           
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);

            }
            return;
        }

        public void GetEmployeeDepartment(string IdDepartment) {
            ListEmployee = new List<Employee>();
            using(CompanyContext compamy = new CompanyContext()) {
                foreach(Employee employee in compamy.Employees) {
                    if(employee.DepartmentID.ToString() == IdDepartment) {
                        ListEmployee.Add(employee);
                    }
                }
            }
        }

        private TreeNode CreateHierarchy(string ID, DbSet<Department> depData, TreeNode root) {
            foreach (Department department in depData) {
                string IdCurrDep = department.ID.ToString();
                string IdParentDep = department.ParentDepartmentID.ToString();
                TreeNode currNode = new TreeNode { Text = department.Name, Tag = IdCurrDep};
                if (IdParentDep == ID) {
                    TreeNode temp = CreateHierarchy(department.ID.ToString(), depData, currNode);
                    root.Nodes.Add(currNode);
                }
            }
            return root;
        }
    }

    class CompanyContext : DbContext {
        public CompanyContext() : base("KostaDBConn") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
