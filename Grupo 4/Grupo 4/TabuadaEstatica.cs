using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4
{
    public static class TabuadaEstatica
    {
        public static string Calcular(int valor)
        {
            StringBuilder resultado = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                resultado.AppendLine($"{valor} * {i} = {valor * i}");
            }
            return resultado.ToString();
        }
    }
}