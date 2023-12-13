using Metrices_psql.datalayer;

using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

using System.ComponentModel;



namespace Metrices_psql.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class ChartDataController : ControllerBase

    {

        private readonly IPrometheusQueryServices _prometheusQueryServices;



        public ChartDataController(IPrometheusQueryServices prometheusQueryServices)

        {

            _prometheusQueryServices = prometheusQueryServices;

        }





        //[HttpGet("ChartTotalEmployesByDepartment")]

        //public async Task<IActionResult> ChartTotalEmployesByDepartment(string? timeRange = "1h")

        //{

        //    try

        //    {

        //        var result = await _prometheusQueryServices.ChartDataTotalEmployeesByDepartment(timeRange);

        //        return Ok(result);

        //    }

        //    catch (Exception ex)

        //    {

        //        return StatusCode(500, $"Error querying Promethues: {ex.Message}");

        //    }

        //}





        //[HttpGet("ChartDataFindRequestDuration")]

        //public async Task<IActionResult> ChartDataFindRequestDuration(string? timeRange = "1h")

        //{

        //    try

        //    {

        //        var result = await _prometheusQueryServices.ChartDataFindRequestDuration(timeRange);

        //        return Ok(result);

        //    }

        //    catch (Exception ex)

        //    {

        //        return StatusCode(500, $"Error querying Promethues: {ex.Message}");

        //    }

        //}

        //[HttpGet("ChartDataTotalEmployes")]

        //public async Task<IActionResult> ChartDataTotalEmployes(string? timeRange="1h")

        //{

        //    try

        //    {

        //        var result = await _prometheusQueryServices.ChartDataTotalEmployes(timeRange);

        //        return Ok(result);

        //    }

        //    catch (Exception ex)

        //    {

        //        return StatusCode(500, $"Error querying Promethues: {ex.Message}");

        //    }

        //}





        //[HttpGet("ChartDataIndexCount")]

        //public async Task<IActionResult> ChartDataIndexCount(string? timeRange = "1h")

        //{

        //    try

        //    {

        //        var result = await _prometheusQueryServices.ChartDataIndexCount(timeRange);

        //        return Ok(result);

        //    }

        //    catch (Exception ex)

        //    {

        //        return StatusCode(500, $"Error querying Promethues: {ex.Message}");

        //    }

        //}

    }

}
