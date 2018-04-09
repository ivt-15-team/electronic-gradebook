using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ebook
{
    public class Employee : Person
    {
        //переменные
        private string cathedra;
        private string position;

        

        public Employee(string _fname, string _sname, string _mname, DateTime _bdate, string k_cathedra, string k_position) : base(_fname, _sname, _mname, _bdate)
        {
            cathedra = k_cathedra;
            position = k_position;
        }

        public string Cathedra {
            get {
                  return cathedra;
            }

            set {
                cathedra = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }
        //функции


    }

    public class EmployeeRepository : IRepository<Employee>, IDisposable
    {
        private EbookContext context;

        public EmployeeRepository(EbookContext context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> GetEntities()
        {
            return context.Employees.ToList();
        }
        public Employee GetEntityById(int id)
        {
            return context.Employees.Find(id);
        }
        public void InsertEntity(Employee employee)
        {
            context.Employees.Add(employee);
        }
        public void DeleteEntity(int employeeID)
        {
            Employee employee = context.Employees.Find(employeeID);
            context.Employees.Remove(employee);
        }
        public void UpdateEntity(Employee employee)
        {
            context.Entry(employee).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

