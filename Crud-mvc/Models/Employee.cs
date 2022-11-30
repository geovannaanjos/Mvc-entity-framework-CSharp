using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_mvc.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [Required(ErrorMessage ="Este Campo é de preenchimento obrigatório")]
        [DisplayName("Nome")]

        public string FullName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Matricula")]
        

        public int EmpCode { get; set; }
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Cargo")]

        public string Position { get; set; }
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Localização")]
        public string OfficeLocation { get; set; }


    }
}
