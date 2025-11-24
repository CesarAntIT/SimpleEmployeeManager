using System;
using EmployeeAPI.Data;
using EmployeeAPI.Data.Context;
using EmployeeAPI.Data.Entities;

namespace EmployeeAPI.Services;

public class EmployeeService:IEmployeeService
{
    EmployeeDB _context { get; set; }
    public EmployeeService(EmployeeDB db)
    {
        _context = db;
        SeedData.SetSeedData(_context);
    }
    public IEnumerable<Employee> Get()
    {
        var empList = _context.Employees;
        if (empList != null)
            return empList;
        else
            return null!;
    }
    public IEnumerable<Employee> GetByName()
    {
        throw new NotImplementedException();
    }
    public Employee GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
