using System.Collections.Generic;
using System.IO;
using Interfaces;
using Entidades;
namespace PersistenciaXD
{
    class PersistenciaXD : IPersistencia
    {
        public bool Grabar(Estudiantes estudiantes)
        {
            File.AppendAllLines("Estudiantes.txt", new List<string> { estudiantes.ToString() });
            return true;
        }
        public bool Grabar(Curso curso)
        {
            File.AppendAllLines("Curso.txt", new List<string> {curso.ToString() });
            return true;
        }
        public bool Grabar(EstudiantesPorCurso estudiantesPorCurso)
        {
            File.AppendAllLines("EstudiantesPorCurso.txt", new List<string> { estudiantesPorCurso.ToString() });
            return true;
        }
    }
}
