using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        private int memoriaram;
        private int discoduro;
        private string placamadre;
        private string microprocesador;
        private string tarjetadevideo;
        private string monitor;
        private string cpu;
        private string teclado;
        private string mouse;

        public int Memoriaram { get => memoriaram; set => memoriaram = value; }
        public int Discoduro { get => discoduro; set => discoduro = value; }
        public string Placamadre { get => placamadre; set => placamadre = value; }
        public string Microprocesador { get => microprocesador; set => microprocesador = value; }
        public string Tarjetadevideo { get => tarjetadevideo; set => tarjetadevideo = value; }
        public string Monitor { get => monitor; set => monitor = value; }
        public string Cpu { get => cpu; set => cpu = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Mouse { get => mouse; set => mouse = value; }
    } /// hola
}
