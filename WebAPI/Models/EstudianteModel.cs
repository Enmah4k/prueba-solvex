using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Estudiante
    {
        [Key]
        public int ES_ID {get; set;}

        [Required]
        public string Nombre {get; set;}
        public string Nombre2 {get; set;}

        [Required]
        public string Apellido {get; set;}
        public string Apellido2 {get; set;}

        public byte[] Foto {get; set;}

        public string Grado {get; set;}
    }
}