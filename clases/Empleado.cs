using System;

namespace Voluntariado
{
    abstract class Empleado
    {

        public string nombre;
        public string apellido;

        public Empleado(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public abstract void MostrarInfo();
    }
}
