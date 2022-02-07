using Microsoft.EntityFrameworkCore;
using Project.Server.Repository;
using Project.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EmployeeRepository(ApplicationDbContext _applicationDbContext)
        {
            this._applicationDbContext = _applicationDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            try
            {
                //if (employee.Department != null)
                //{
                //    _applicationDbContext.Entry(employee.Department).State = EntityState.Unchanged;
                //}

                var result = await _applicationDbContext.Employees.AddAsync(employee);
                await _applicationDbContext.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var result = await _applicationDbContext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);

            if (result != null)
            {
                _applicationDbContext.Employees.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await _applicationDbContext.Employees
                
                .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await _applicationDbContext.Employees
                .FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _applicationDbContext.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> Search(string name)
        {
            IQueryable<Employee> query = _applicationDbContext.Employees;

            if (name != null)
            {
                query = query.Where(e => e.Name == name);
            }

            

           

            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await _applicationDbContext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);

            if (result != null)
            {
                result.Name = employee.Name;
               
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                
                //if (employee.DepartmentId != 0)
                //{
                //    result.DepartmentId = employee.DepartmentId;
                //}
                //else if (employee.Department != null)
                //{
                //    result.DepartmentId = employee.Department.DepartmentId;
                //}
               

                await _applicationDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
