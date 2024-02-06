using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_DesarrolloHabilidades02.Models
{
    public class Cliente
    {
        public string dui { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoCuenta { get; set; }
        public string nit { get; set; }
        public string numeroCuenta { get; set; }
        public decimal montoDisponible { get; set; }
        public string sucursal { get; set; }

        public Cliente(string dui, string nombre, string apellido, string tipoCuenta, string nit, string numeroCuenta, decimal montoDisponible, string sucursal)
        {
            this.dui = dui;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoCuenta = tipoCuenta;
            this.nit = nit;
            this.numeroCuenta = numeroCuenta;
            this.montoDisponible = montoDisponible;
            this.sucursal = sucursal;
        }

        public static bool IsModelComplete(Cliente model)
        {
            return model != null
                && !string.IsNullOrEmpty(model.dui)
                && !string.IsNullOrEmpty(model.nombre)
                && !string.IsNullOrEmpty(model.apellido)
                && !string.IsNullOrEmpty(model.tipoCuenta)
                && !string.IsNullOrEmpty(model.nit)
                && !string.IsNullOrEmpty(model.numeroCuenta)
                && !string.IsNullOrEmpty(model.sucursal);
        }

    }
}
