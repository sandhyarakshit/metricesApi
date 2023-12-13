using Metrices_psql.Models;



namespace Metrices_psql.datalayer

{

    public interface IPrometheusQueryServices

    {

        //post data

        void TotalEmployesIncBYDepartment(Employes employee);

        void TotalEmployesDecByDepartment(Employes employee);

        void TotalIndexInc();

        void TotalEmployesInSystemIncandDec(double value);

        void RecordEmployeeFindDuration(TimeSpan duration);







        //get data

   //   Task<string> CustomQueryPromethues(string customquery);

        Task<string> TotalIndexReached();

        Task<string> TotalEmployees();

    //  Task<string> TotalEmployesByDepartment();

        Task<string> EmployeeAddDuration();



        //chartdata

        //Task<List<ChartDataPoint>> ChartDataTotalEmployeesByDepartment(string timeRange);

        //Task<List<ChartDataCounters>> ChartDataTotalEmployes(string timeRange);

        //Task<List<ChartDataCounters>> ChartDataIndexCount(string timeRange);

        //Task<List<ChartDataCounter2Class>> ChartDataFindRequestDuration(string timeRange);



    }

}
