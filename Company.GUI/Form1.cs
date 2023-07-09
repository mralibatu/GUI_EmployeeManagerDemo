using Company.Business.Abstract;
using Company.Business.Concrete;
using Company.Business.DependencyResolvers.Ninject;
using Company.DataAccess.Abstract;
using Company.DataAccess.Concrete.EntityFramework;
using Company.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company.GUI
{
    public partial class Form1 : Form
    {

        IEmployeeService _employeeService;
        public Form1()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadComboxes();
        }

        private void LoadComboxes()
        {
            LoadWorkPositions();
            LoadGenders();
        }

        private void LoadEmployees()
        {
            dgwEmployee.DataSource = _employeeService.GetAll();
        }
        private void LoadWorkPositions()
        {
            var workPositionsData = _employeeService.GetWorkPositions();
            workPositionsData.Insert(0, "All");
            cbxWorkPositions.DataSource = workPositionsData;

            var addWorkPositionsData = _employeeService.GetWorkPositions();
            cbxAddEmployeeWorkPosition.DataSource = addWorkPositionsData;
            cbxAddEmployeeWorkPosition.SelectedItem = addWorkPositionsData[0];

            cbxUpdateEmployeeWorkPosition.DataSource = _employeeService.GetWorkPositions();
        }
        private void LoadGenders()
        {
            cbxAddEmployeeGender.DataSource = _employeeService.GetGenders();
        }
        private bool isNameBoxesEmpty()
        {
            return String.IsNullOrEmpty(tbxSearchFirstName.Text) && String.IsNullOrEmpty(tbxSearchLastName.Text);
        }
        private bool isCbxWorkPoisitonEmpty()
        {
            return cbxWorkPositions.SelectedIndex == 0;
        }

        private void tbxSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            Search(tbxSearchFirstName,tbxSearchLastName);
        }

        private void tbxSearchLastName_TextChanged(object sender, EventArgs e)
        {
            Search(tbxSearchFirstName, tbxSearchLastName);
        }

        private void Search(TextBox textBox1, TextBox textBox2)
        {
            if(isNameBoxesEmpty() && isCbxWorkPoisitonEmpty())      //If there is no filter, get all
            {
                dgwEmployee.DataSource= _employeeService.GetAll();
            }
            else if (!isNameBoxesEmpty() && isCbxWorkPoisitonEmpty())      //If just using search box
            {
                if (!String.IsNullOrEmpty(tbxSearchFirstName.Text) && String.IsNullOrEmpty(tbxSearchLastName.Text))             //If just using firstName
                {
                    dgwEmployee.DataSource = _employeeService.GetEmployeesByFirstName(tbxSearchFirstName.Text);
                }else if (!String.IsNullOrEmpty(tbxSearchLastName.Text) && String.IsNullOrEmpty(tbxSearchLastName.Text))        //If just using lastName
                {
                    dgwEmployee.DataSource = _employeeService.GetEmployeesByLastName(tbxSearchLastName.Text);
                }
                else                                                                                                            //Using fullName
                {
                    dgwEmployee.DataSource = _employeeService.GetEmployeesByFullName(tbxSearchFirstName.Text, tbxSearchLastName.Text);
                }                    
            }
            else if (!isCbxWorkPoisitonEmpty() && isNameBoxesEmpty())    //If just using combobox                            
            {
                dgwEmployee.DataSource = _employeeService.GetEmployeesByWorkPositions(cbxWorkPositions.Text);
            }
            else                                                         //Use all of the filters
            {
                dgwEmployee.DataSource = _employeeService.GetEmployeesByWorkPositions(tbxSearchFirstName.Text, tbxSearchLastName.Text, cbxWorkPositions.Text);
            }
        }

        private void cbxWorkPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxWorkPositions.SelectedIndex == 0)
            {
                dgwEmployee.DataSource = _employeeService.GetAll();
                tbxSearchFirstName.Text = "";
                tbxSearchLastName.Text = "";
            }
            else
            {
                Search(tbxSearchFirstName, tbxSearchLastName);

            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                Employee employee = new Employee
                {
                    FirstName = tbxAddEmployeeFirstName.Text,
                    LastName = tbxAddEmployeeLastName.Text,
                    WorkPosition = cbxAddEmployeeWorkPosition.Text,
                    Gender = cbxAddEmployeeGender.Text,
                };

                _employeeService.Add(employee);
                MessageBox.Show("Employee Added!");
                LoadEmployees();
            });

        }

        private void gbxUpdateEmployee_Enter(object sender, EventArgs e)
        {
            tbxUpdateEmployeeFirstName.Text = dgwEmployee.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateEmployeeLastName.Text = dgwEmployee.CurrentRow.Cells[2].Value.ToString();
            cbxUpdateEmployeeWorkPosition.Text = dgwEmployee.CurrentRow.Cells[3].Value.ToString();
        }

        private void gbxUpdateEmployee_Leave(object sender, EventArgs e)
        {
            tbxUpdateEmployeeFirstName.Text = "";
            tbxUpdateEmployeeLastName.Text = "";
            cbxUpdateEmployeeWorkPosition.Text = "";
        }

        private void gbxDeleteEmployee_Enter(object sender, EventArgs e)
        {
            tbxDeleteEmployeeFirstName.Text = dgwEmployee.CurrentRow.Cells[1].Value.ToString();
            tbxDeleteEmployeeLastName.Text = dgwEmployee.CurrentRow.Cells[2].Value.ToString();
        }

        private void gbxDeleteEmployee_Leave(object sender, EventArgs e)
        {
            tbxDeleteEmployeeFirstName.Text = "";
            tbxDeleteEmployeeLastName.Text = "";
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                Employee employee = new Employee
                {
                    id = Convert.ToInt32(dgwEmployee.CurrentRow.Cells[0].Value),
                    FirstName = tbxUpdateEmployeeFirstName.Text,
                    LastName = tbxUpdateEmployeeLastName.Text,
                    WorkPosition = cbxUpdateEmployeeWorkPosition.Text,
                    Gender = dgwEmployee.CurrentRow.Cells[4].Value.ToString()
                };

                _employeeService.Update(employee);
                MessageBox.Show("Employee Updated!");
                LoadEmployees();
            });
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                id = Convert.ToInt32(dgwEmployee.CurrentRow.Cells[0].Value)
            };

            _employeeService.Delete(employee);
            MessageBox.Show("Employee Deleted!");
            LoadEmployees();
        }

        private void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
