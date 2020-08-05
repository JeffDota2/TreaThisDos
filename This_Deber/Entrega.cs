using System;
using System.Collections.Generic;
using System.Text;

namespace This_Deber
{
    class Entrega
    {
        public string EntregaCantidad { get; set; }
        public string CiudadDeLlegada { get; set; }

        //comportamientos de la clases

        public string CantidadDeProducto(string EntregaCantidad)
        {
            return $"numero de pedido o envio : {EntregaCantidad} codigo del envio : {this.EntregaCantidad}";
        }
        public string llega(string CiudadDeLlegada)
        {
            return $"ciudad de donde sale el producto : {CiudadDeLlegada} ciudad de destino de los productos : {this.CiudadDeLlegada}";
        }
    }
}
