using System;
using EmployeeAPI.Data.Entities;

namespace EmployeeAPI.Services;

public class EmployeeService:IEmployeeService
{
    public IQueryable<Employee> Get()
    {
        throw new NotImplementedException();
    }
    public IQueryable<Employee> GetByName()
    {
        throw new NotImplementedException();
    }
    public Employee GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
