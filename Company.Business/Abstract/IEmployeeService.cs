using Company.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> GetEmployeesByFirstName(string key);
        List<Employee> GetEmployeesByLastName(string key);
        List<Employee> GetEmployeesByFullName(string key1, string key2);
        List<Employee> GetEmployeesByWorkPositions(string key);
        List<Employee> GetEmployeesByWorkPositions(string key1, string key2, string key3);
        List<Employee> GetEmployeesByGenders(string key);
        List<String> GetWorkPositions();
        List<String> GetGenders();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee); 
    }
}
