# What is the purpose of the classes and class libaries ?

## Company.DataAccess

### Abstract

> The IEntityRepository interface specifies what is required in an entity data access. On the other hand, IEmployeeDal indicates that its subclasses are responsible for the Employee Data Access.

### Concrete

> I use EntityFramework in this project.
> 
> CompanyContext class allows to return a DbSet of our database.
> 
> EfEntityRepositoryBase is a generic class that takes TEntity and
> TContext. (TEntity must be a class of IEntity and TContext is the
> DbContext)
> 
> In this class the program do all of the database actions. Furthermore
> I use a class that EfEmployeeDal which inherit from
> EfEntityRepositoryBase. It allows to if we add new table in our
> database, we have to just add new class such as EfNewTableDal.


## Company.Entities

### Abstract

> I create a interface which called IEntity to understand which class is implement this interface. Other words, which class is entity class.

### Concrete

> Employee class keeps the columns of Employee table.


## Company.Business

  

> Business class libary created for controlling data access.

  

### Abstract

> IEmployeeService is a interface that keeps data access methods. Even I change the data access type, I have to just change the I...Dal object.

  

### Concrete

> In this class I have all of the queries. I use dal interfaces methods. I also check validation rules in this area.

  

### DependencyResolvers

> From SOLID rule D, for escape create too much new IDals I use Ninject. In BusineesModule I load all of I use interfaces with NinjectModule. Then I created a InstanceFactory to return BusineesModule's kernel.

### ValidationRules & Utilities

> EmployeeValidator class keeps rule for data access. It allows escape empty inputs or wrong get accesses. On the other hand, ValidationTool throw exceptions when there is a problem in validation of Validator.

## Screenshots and features
### Main page

![main_page](https://github.com/mralibatu/GUI_EmployeeManagerDemo/assets/90419918/36dcbdf2-4a96-4444-93b6-aed9a40b7fef)

### You can search employee with first name, last name, work position or all of them. 
![search](https://github.com/mralibatu/GUI_EmployeeManagerDemo/assets/90419918/92a13e13-63c0-4e1b-85dd-ab68500ed05d)

### Add Employee
![add_employee](https://github.com/mralibatu/GUI_EmployeeManagerDemo/assets/90419918/e01dd2c9-ac42-469d-951b-6930b51ca464)

### Update Employee
>If you click an employee from table and click the "Update Employee" box, full name and work position automatically filled.
>
![update_employee_gif](https://github.com/mralibatu/GUI_EmployeeManagerDemo/assets/90419918/3edf5c1c-9607-409b-a1ff-3a308aaab285)

### Delete Employee
>Filling automatically is also here.
>
![delete_employee_gif](https://github.com/mralibatu/GUI_EmployeeManagerDemo/assets/90419918/5f13c214-0632-498b-8cb3-d1e9cc381f47)
