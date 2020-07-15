using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class Curso
    {
        // [Key]
        // [Column(Order = 1)]
        // public string Nivel { get; set; }
        // [Key]
        // [Column(Order = 2)]
        // public string Aula { get; set; }

        public int Id { get; set; }
        public ICollection<Estudiante> Estudiantes { get; set; }

        
        [ForeignKey("CursoIdRef")]
        public Profesor Profesor { get; set; }
    }
}