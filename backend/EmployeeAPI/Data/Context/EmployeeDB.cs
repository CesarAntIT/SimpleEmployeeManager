using System;
using EmployeeAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Data;

public class EmployeeDB : DbContext
{
    public EmployeeDB() { }
    
    public DbSet<Employee> Employees { get; set; }
}
