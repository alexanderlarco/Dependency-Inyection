using Entidades;
namespace Interfaces
{
     public interface IPersistencia
    {
         bool Grabar(Estudiantes estudiantes);

         bool Grabar(Curso curso);

         bool Grabar(EstudiantesPorCurso estudiantesPorCurso);
       
    }
}
