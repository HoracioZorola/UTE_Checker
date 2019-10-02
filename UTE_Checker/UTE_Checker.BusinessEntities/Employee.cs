using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTE_Checker.BusinessEntities
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required (ErrorMessage = "El campo Número de empleado es requerido.")]
        public int employeeNumber { get; set; }

        [Required (ErrorMessage = "El campo Nombre es requerido.")]
        [StringLength (30, ErrorMessage = "La longitud del campo Nombre es de 30 caracteres.")]
        [DataType (DataType.Text)]
        public string name { get; set; }

        [Required(ErrorMessage = "El campo Apellidos es requerido.")]
        //[StringLength(60, ErrorMessage = "La longitud del campo Apellido es de 60 caracteres.")]
        [DataType(DataType.Text)]
        public string lastname { get; set; }

    }
}
