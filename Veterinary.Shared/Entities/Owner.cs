using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El documento es requerido")]

        public string Documento { get; set; } = null;

        [Required(ErrorMessage = "El Nombre es requerido")]

        public string FirstName { get; set; } = null;

        [Required(ErrorMessage = "El Apellido es requerido")]
        public string LastName { get; set; } = null;

        [Required(ErrorMessage = "El Phone es requerido")]

        public string FixedPhone { get; set; } = null;

        public string CellPhone { get; set; } = null;
        public string Adress { get; set; } = null;
        public string FullName => $"{FirstName} {LastName}";


    }
}







