using Computadora.Entidades;
using Computadora.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsComputadora clscomputadora = new ClsComputadora();
            NClsComputadora nclscomputadora = new NClsComputadora();
            clscomputadora.Microprocesador = "Intel";
            clscomputadora.Memoriaram = 8;
        }
    }
}
