using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocios
{
    class NClsComputadora
    {

        public string Apagar(ClsComputadora computadora)
        {
            return "El equipo " + computadora.Cpu + "Se esta apagando.";
        }
        public string microprocesador(ClsComputadora computadora)
        {
            return "El Microprocesador " + computadora.Microprocesador + " funciona perfectamente.";
        }
        public string placamadre(ClsComputadora computadora)
        {
            return "la placa madre " + computadora.Placamadre + " esta en perfecto estado.";
        }
        public string pant(ClsComputadora computadora)
        {
            return "El Mouse " + computadora.Mouse + " se conectó con éxito.";
        }
    }
}
