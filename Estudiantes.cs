﻿using System;

namespace Entidades
{
    public class Estudiantes
    {
        public Estudiantes(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Id = new Random().Next();
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
    }
}
