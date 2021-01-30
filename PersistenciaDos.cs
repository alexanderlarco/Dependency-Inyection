using System.Collections.Generic;
using System.IO;
using Interfaces;
using Entidades;

namespace DatosOtro
{
    class PersistenciaDos : IPersistencia
    {
        public bool Grabar(Estudiantes estudiantes)
        {
            File.AppendAllLines("Estudiantes.txt", new List<string> { estudiantes.Nombre, estudiantes.Apellido });
            return true;
        }
        public bool Grabar(Curso curso)
        {
            File.AppendAllLines("Curso.txt", new List<string> { curso.Nombre });
            return true;
        }
        public bool Grabar(EstudiantesPorCurso estudiantesPorCurso)
        {
            File.AppendAllLines("EstudiantesPorCurso.txt", new List<string> { estudiantesPorCurso.CursoId.ToString() });
            return true;
        }
    }
}
