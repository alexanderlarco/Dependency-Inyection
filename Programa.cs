using System;
using Interfaces;
using Negocios;
using Entidades;
namespace DependenciasAPP
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOLA MUNDO!");

            IPersistencia persistencia = null; //aqui se deberia instanciarse
           


            Secretarias secretarias = new Secretarias(persistencia);
            Estudiantes estudiantes = new Estudiantes("JHOANNA", "PATRICIO");
            Curso curso = new Curso("Programacion");

            secretarias.Matricular(estudiantes, curso);


        }
    }
}
