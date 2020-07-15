using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Estudiante
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public string Nombre {get; set;}

        public string Nombre2 {get; set;}

        [Required]
        public string Apellido {get; set;}

        public string Apellido2 {get; set;}

        [Required]
        public string Telefono {get; set;}
    }
}