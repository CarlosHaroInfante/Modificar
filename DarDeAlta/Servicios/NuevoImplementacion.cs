using DarDeAlta.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal class NuevoImplementacion : NuevoInterfaz
    {
        public void borrarCliente(List<ClientesDto> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniPedido = mi.pedirDNI();


            //Se elimina por referencia de memoria no por valores.
            ClientesDto clienteABorrar = new ClientesDto();
            foreach (ClientesDto clientes in listaAntigua)
            {
                if (clientes.DniCliente.Equals(dniPedido))
                {
                    clienteABorrar = clientes;
                    break;
                }
            }
        }


            //Posición
            /**  int i;
              bool aBorrar = false;

              for (i = 0; i < listaAntigua.Count(); i++) 
              {

                  if (listaAntigua[i].DniCliente.Equals(dniPedido)) 
                  {
                      aBorrar = true;
                      break;
                  }
              }
              if(aBorrar) 
              { 
                  listaAntigua.RemoveAt(i);
              }
              else
              {
                  Console.WriteLine("El cliente no existe");
              }

              
          }*/

            public void darAltaCliente(List<ClientesDto> listaAntigua)
            {


                ClientesDto cliente = darAlta();
                listaAntigua.Add(cliente);

            }

       

        /// <summary>
        /// Implementación donde se pondrán los datos del usuario y lo añadirá a la lista.
        /// 171123 - chi
        /// </summary>

        private ClientesDto darAlta()
            {

                ClientesDto clienteNuevo = new ClientesDto();

                Console.WriteLine("Datos del usuario");

                Console.WriteLine("ID: ");
                clienteNuevo.IdCliente = Convert.ToInt64(Console.ReadLine());
                long idClient = clienteNuevo.IdCliente;

                Console.WriteLine("Nombre: ");
                clienteNuevo.NombreCliente = Console.ReadLine();

                Console.WriteLine("Apellidos: ");
                clienteNuevo.ApellidosCliente = Console.ReadLine();

                Console.WriteLine("DNI: ");
                clienteNuevo.DniCliente = Console.ReadLine();

                Console.WriteLine("Fecha de nacimiento: ");
                clienteNuevo.FchNacimientoCliente = Console.ReadLine();

                Console.WriteLine("email: ");
                clienteNuevo.EmailCliente = Console.ReadLine();

                Console.WriteLine("Tlf: ");
                clienteNuevo.TlfCliente = Convert.ToInt32(Console.ReadLine());
                //long tlfCliente = clienteNuevo.TlfCliente;

                Console.WriteLine("Fecha de Alta: ");
                clienteNuevo.FchAltaCliente = Console.ReadLine();


                return clienteNuevo;

            }

        public void modificarCliente(List<ClientesDto> listaAntigua)
            {
                ClientesDto modClientes = new ClientesDto();
                for (int i = 0; i < listaAntigua.Count; i++) 
                { 
                listaAntigua[0].NombreCliente = " ";
                Console.WriteLine("Nombre: " + listaAntigua[i].NombreCliente);

                }

                foreach (ClientesDto clientes in listaAntigua)
                {
                if (clientes.NombreCliente == );

                }
            }

        }
    }

