using Metrices_psql.datalayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Metrices_psql;
using Metrices_psql.Models;
using Prometheus;

namespace Metrices_psql.datalayer
{
    public class EmployesRepository : IEmployesRepository

    {
        private readonly ApplicationDbContext _context;

        public EmployesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public  bool DeleteEmployes(int id)
        {

            var employee =  _context.Employes.Find(id); ;
            if (employee == null)
                return false;

            _context.Employes.Remove(employee);
            _context.SaveChangesAsync();
            return true;
        }


        public IEnumerable<Employes> GetallEmployes()
        {
            return  _context.Employes.ToList();
        }

        public Employes GetEmployes(int id)
        {
            return _context.Employes.Find(id);

        }

        public  ActionResult<Employes> PostEmployees(Employes employee)
        {
            _context.Employes.Add(employee);
             _context.SaveChanges();
           

            return employee;
        }

        public Employes PutEmployes(int id, Employes employee)
        {
            if (!_context.Employes.Any(e => e.EmployeeId == id))
                return null;

            employee.EmployeeId = id;
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
            return employee;


        }
    }
}