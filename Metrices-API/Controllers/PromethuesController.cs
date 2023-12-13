using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Metrices_psql.Models;
using Prometheus;
using Metrices_psql.datalayer;
using System.Diagnostics;

namespace Metrices_psql.Controllers
{
    [Route("Metrices")]

    [ApiController]

    public class PromethuesController : Controller
    {
        private readonly IPrometheusQueryServices _prometheusQueryServices;
       
       public PromethuesController(IPrometheusQueryServices prometheusQueryServices)
        {
            _prometheusQueryServices = prometheusQueryServices;
        }

        //[HttpGet("CustomQuery")]
        //public async Task<IActionResult> CustomQuery(string customquery)
        //{
        //    try
        //    {
        //        var result = await _prometheusQueryServices.CustomQueryPromethues(customquery);

        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Error querying Promethues: {ex.Message}");
        //    }
        //}

        [HttpGet("TotalEmployees")]

        public async Task<IActionResult> TotalEmployees() 
        {
            try
            {
                var result = await _prometheusQueryServices.TotalEmployees();
                return Ok(result);


            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error querying Promethues: {ex.Message}");
            }
        }

        [HttpGet("TotalIndexReached")]
        public async Task<IActionResult> TotalIndexReached()
        {
            try
            {
                var result = await _prometheusQueryServices.TotalIndexReached();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error querying Promethues: {ex.Message}");
            }
        }

        //[HttpGet("TotalEmployesByDepartment")]
        //public async Task<IActionResult> TotalEmployesByDepartment()
        //{
        //    try
        //    {
        //        var result = await _prometheusQueryServices.TotalEmployesByDepartment();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Error querying Promethues: {ex.Message}");
        //    }
        //}

        [HttpGet("EmployeeAddDuration")]
        public async Task<IActionResult> EmployeeAddDuration()
        {
            try
            {

                var result = await _prometheusQueryServices.EmployeeAddDuration();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error querying Promethues: {ex.Message}");
            }

        }

        }
}
