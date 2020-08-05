using System;
using System.Collections.Generic;
using System.Text;

namespace This_Deber
{
    class Producto
    {

        public string ProdColor { get; set; }
        public string ProdMarca { get; set; }

        public string ProdModelo { get; set; }

        public string ProductoColor(string Codigo)
        {
            return $"Codigo de producto: {Codigo} codigos de productos :{this.ProdColor}";
        }
        public string ProductoMarca(string Marca)
        {
            return $"Marca de productos: {Marca} diferentes marcas : {this.ProdMarca}";
        }

        public string ProductoModelo(string Modelo)
        {
            return $"Marca de productos: {Modelo} diferentes marcas : {this.ProdModelo}";
        }

    }
}
