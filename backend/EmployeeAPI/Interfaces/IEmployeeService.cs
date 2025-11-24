using System;
using EmployeeAPI.Data.Entities;

namespace EmployeeAPI.Services;

public interface IEmployeeService
{
    public IEnumerable<Employee> Get();
    public IEnumerable<Employee> GetByName();
    public Employee GetById(Guid id);
}
