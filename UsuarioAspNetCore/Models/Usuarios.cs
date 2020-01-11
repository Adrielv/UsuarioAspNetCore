using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuarioAspNetCore.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }


        [Required(ErrorMessage = "Usuario esta incorrecto")]
        [StringLength(100, ErrorMessage = "Usuario es muy largo")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Contraseñaa esta incorrecto")]
        [StringLength(100, ErrorMessage = "Contraseña es muy largo")]

        public string Contraseña { get; set; }
    }
}
