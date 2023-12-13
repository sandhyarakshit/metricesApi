using System.ComponentModel.DataAnnotations;

namespace Metrices_psql.Models
{
    public class Employes
    {
          

            [Key]
            public int EmployeeId { get; set; }

            [Required]
            public string EmployeeName { get; set; }

            [Required]
            public string Email { get; set; }

            
            [Required]
            public string Department { get; set; }

         

            [Required]
            [Range(0, int.MaxValue, ErrorMessage = "Salary must be a positive number.")]
            public decimal Salary { get; set; } = 25000;
        }

    }

