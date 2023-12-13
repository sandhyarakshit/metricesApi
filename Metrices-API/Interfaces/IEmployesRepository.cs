using Metrices_psql.Models;
using Microsoft.AspNetCore.Mvc;

namespace Metrices_psql.datalayer
{
   

        public interface IEmployesRepository
        {
            IEnumerable<Employes> GetallEmployes();

            Employes GetEmployes(int id);

            Employes PutEmployes(int id, Employes employes);

            ActionResult<Employes> PostEmployees(Employes employee);

            bool DeleteEmployes(int id);


        }
    }

