using System;

namespace Entidades
{
     public class EstudiantesPorCurso
    {
        public int EstudiantesId { get; set; }

        public int CursoId { get; set; }

        public int Id { get; set; } = new Random().Next();
    }
}
