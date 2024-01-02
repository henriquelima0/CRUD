using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatrixCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string FullName { get; set; }


        [Column(TypeName = "varchar(50)")]
        [DisplayName("Matrícula")]
        [Required(ErrorMessage = "O campo Matrícula é obrigatório")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "O campo de Cargo é obrigatório")]
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Localização")]
        [Required(ErrorMessage = "O campo de Localização é obrigatório")]
        public string OfficeLocation { get; set; }
    }
}
