using DarDeAlta.Servicios;
using DarDeAlta.Dtos;
namespace DarDeAlta
{
    /// <summary>
    /// Clase principal del programa donde se encontrará nuestro método Main.
    /// 171123 - chi
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main donde se encontrará la llamada a métodos y el bucle donde el usuario elegirá una opción del menú.
        /// 171123 - chi
        /// </summary>

        static void Main(string[] args)
        {

            List<ClientesDto> listaClientes = new List<ClientesDto>(); //LLamada al método de clientesDto y le hacemos  una copia.

            List<CuentasDto> listaCuentas = new List<CuentasDto>();

            MenuInterfaz menu = new MenuImplementacion(); //Creo una copua menú menú

            NuevoInterfaz banco = new NuevoImplementacion(); //Creo la copia donde el usuario rellenará con sus datos.

            CuentaInterfaz cuentas = new CuentaImplementacion();

            bool cerrarMenu = false; //Menú iniciado en falso

            while (!cerrarMenu) //Le ponemos el simbolo ! para cambiar a true.
            {
                int opcionElegida = menu.menu(); //Llamada al método

                switch (opcionElegida)
                {

                    case 0:
                        Console.WriteLine("Se cerrará el menú");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Darse de Alta en el Banco");
                        banco.darAltaCliente(listaClientes); //El método banco en el que está darAltaCliente

                        break;
                    case 2:
                        Console.WriteLine("Dar de Alta una cuenta");
                        cuentas.nuevaCuenta(listaCuentas);

                        break;
                    case 3:
                        Console.WriteLine("Modificar un cliente");

                        break;
                    case 4:
                        Console.WriteLine("Eliminar un cliente");
                        banco.borrarCliente(listaClientes);

                        break;
                    case 5:
                        Console.WriteLine("Ver Clientes");
                        foreach (ClientesDto clientes in listaClientes)
                        {
                            Console.WriteLine(clientes.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("[INFO - Ninguna opcion valida]");
                        break;

                }

                while (!cerrarMenu)
                {
                    int opcion = menu.seleccion();

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Se cerrará el menú");
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("Modificar Nombre");
                            
                            break;
                    }
                }

            }

        }
    }
}
