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
        var emp = _context.Employees.Find(id);
        if (emp == null)
            return null;
        return emp;
    }

    public Employee Add(Employee emp)
    {
        if (emp == null)
            return null!;

        if (string.IsNullOrWhiteSpace(emp.FirstName))
            return null!;
        if (string.IsNullOrWhiteSpace(emp.LastName))
            return null!;
        if (DateTime.Compare(emp.BirthDate, new DateTime(2008, 1, 1)) > 0)
            return null!;
        if (emp.Department!.Length > 2 || string.IsNullOrWhiteSpace(emp.Department))
            return null!;

        emp.ID = Guid.NewGuid();
        emp.HireDate = DateTime.Now;

        _context.Employees.Add(emp);
        _context.SaveChanges();

        return emp;
    }

    public bool Remove(Guid ID)
    {
        var emp = GetById(ID);
        if (emp == null)
            return false;
        _context.Employees.Remove(emp);
        _context.SaveChanges();
        return true;
    }
}
