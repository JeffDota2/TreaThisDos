using System;
using System.Collections.Generic;
using System.Text;

namespace This_Deber
{
    class Cliente
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }

        public string Celular { get; set; }

        public string MiNombre(string Nombre)
        {
            return $"Hola me llamo { Nombre} y tu como te llamas?: {this.Nombre}";
        }
        public string MiApellido(string Apellido)
        {
            return $"Me apellido {Apellido}  Y el tuyo? :{this.Apellido }";
        }
        public string MiCedula(string Cedula)
        {
            return $"Mi cedula es: {Cedula} Cual es tu numero de cdula? :{this.Cedula}";
        }
        public string MiCelular(string Celular)
        {
            return $"Mi numero es :{Celular} cual es su numero de celular :{ this.Celular}";
        }
    }
}
