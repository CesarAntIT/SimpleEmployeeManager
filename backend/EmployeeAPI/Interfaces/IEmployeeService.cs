using System;
using EmployeeAPI.Data.Entities;

namespace EmployeeAPI.Services;

public interface IEmployeeService
{
    public IQueryable<Employee> Get();
    public IQueryable<Employee> GetByName();
    public Employee GetById(Guid id);
}
