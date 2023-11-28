using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarDeAlta.Dtos;

namespace DarDeAlta.Servicios
{
    internal interface CuentaInterfaz
    {

        public void nuevaCuenta(List<CuentasDto> cuentaAntigua);
    }
}
