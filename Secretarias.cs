using Interfaces;
using Entidades;

namespace Negocio
{
    public class Secretaria
    {
        
        public IPersistencia Persistencia { get; set; }

        public Secretaria(IPersistencia persistencia)
        {
            this.Persistencia = persistencia; 
        }
        
        
        public string Matricular(Estudiantes estudiantes, Curso curso)
        {
            
            Persistencia.Grabar(estudiantes);
            Persistencia.Grabar(curso);
            Persistencia.Grabar(new EstudiantesPorCurso { EstudiantesId = estudiantes.Id, CursoId = curso.Id });

            return string.Format("EL ESTUDIANTE {0} {1} SE MATRICULO EN EL CURSO{2}"
                , estudiantes.Nombre
                , estudiantes.Apellido
                , curso.Nombre);
        }
    }
}
