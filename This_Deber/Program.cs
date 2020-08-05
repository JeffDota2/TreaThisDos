using System;

namespace This_Deber
{
    class Program
    {
        public static bool ProdNombre { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hola");

            //llamado a las clases CLIENTES

            string nombre = " Jefferson";
            string apellido = " Cuello";
            string cedula = "1750822338";
            string celular = "0995444216";

            //instancia clases producto

            Producto productoVenta = new Producto
            {
                ProdColor = "Negro ",
                ProdMarca = "  Samsung ",
            };



            string pregunta1 = "Negro ";
            string pregunta2 = "Samsung A20";



            Destino pedido = new Destino
            {
                Producto = " Samsung ",
                Cantidad = " 20",
                Direccion = "Quito"
            };
            string envio = " Samsung ";
            string envio1 = " 20";
            string envio2 = " Tumbaco La tola ";



            Entrega factura = new Entrega
            {
                EntregaCantidad = "  200 ",
                CiudadDeLlegada = " Quito ",
            };
            string producto1 = "200";
            string producto2 = " Quito ";



            Cliente primeraPersona = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                Cedula = cedula,
                Celular = celular
            };
            string pregunto = "Gorky ";
            string pregunto1 = " Estrella ";
            string pregunto2 = " 17508235454";
            string pregunto3 = " 0995444216";



            string MiNombre = primeraPersona.MiNombre(pregunto);
            Console.WriteLine(MiNombre);
            string MiApellido = primeraPersona.MiApellido(pregunto1);
            Console.WriteLine(MiApellido);
            string MiCedula = primeraPersona.MiCedula(pregunto2);
            Console.WriteLine(MiCedula);
            string MiCelular = primeraPersona.MiCelular(pregunto3);
            Console.WriteLine(MiCelular);


            string ProdColor = productoVenta.ProductoColor(pregunta1);
            Console.WriteLine(ProdColor);
            string ProdMarca = productoVenta.ProductoMarca(pregunta2);
            Console.WriteLine(ProdMarca);



            string Producto = pedido.MarcaDeProducto(envio);
            Console.WriteLine(Producto);
            string Cantidad = pedido.NumeroDeProducto(envio1);
            Console.WriteLine(Cantidad);

            string Direccion = pedido.DireccionDondeDelEnvio(envio2);
            Console.WriteLine(Direccion);



            string CantidadDeProducto = factura.CantidadDeProducto(producto1);
            Console.WriteLine(CantidadDeProducto);
            string CiudadDeLlegada = factura.llega(producto2);
            Console.WriteLine(CiudadDeLlegada);


            Console.ReadKey();
            Console.Beep();

        }
    }
}
