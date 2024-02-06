    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia02
{
    internal class Salario
    {
        public int diasLaborados {  get; set; }
        public decimal CalcularSalario(int diasLab, decimal valorDia)
        {
            decimal totalSalario = diasLab * valorDia;
            return totalSalario;
        }
    }
}
