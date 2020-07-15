using System.Collections.Generic;

namespace WebAPI.Models
{
    public class CursoModel
    {
        public int Id { get; set; }
        public ICollection<Estudiante> Estudiantes {get; set;}
    }
}