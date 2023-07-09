using Company.Business.Abstract;
using Company.Business.Utilities;
using Company.Business.ValidationRules.FluentValidation;
using Company.DataAccess.Abstract;
using Company.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public List<Employee> GetEmployeesByFirstName(string key)
        {
            return _employeeDal.GetAll(p => p.FirstName.ToLower().Contains(key.ToLower()));
        }

        public List<Employee> GetEmployeesByFullName(string key1, string key2)
        {
            return _employeeDal.GetAll(p => p.FirstName.ToLower().Contains(key1.ToLower()) && p.LastName.ToLower().Contains(key2.ToLower()));
        }

        public List<Employee> GetEmployeesByGenders(string key)
        {
            return _employeeDal.GetAll(p => p.Gender == key);
        }

        public List<Employee> GetEmployeesByLastName(string key)
        {
            return _employeeDal.GetAll(p => p.LastName.ToLower().Contains(key.ToLower()));
        }

        public List<Employee> GetEmployeesByWorkPositions(string key)
        {
            return _employeeDal.GetAll(p => p.WorkPosition == key);
        }

        public List<Employee> GetEmployeesByWorkPositions(string firstName, string lastName, string workPositon)
        {
            return _employeeDal.GetAll(p => (p.WorkPosition == workPositon)
            && (p.FirstName.ToLower().Contains(firstName.ToLower()))
                && (p.LastName.ToLower().Contains(lastName.ToLower())));
        }

        public List<string> GetGenders()
        {
            return _employeeDal.GetAll().Select(p => p.Gender).Distinct().ToList();
        }

        public List<string> GetWorkPositions()
        {
            return _employeeDal.GetAll().Select(p => p.WorkPosition).Distinct().ToList();
        }

        public void Update(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.Update(employee);
        }
    }
}
