using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL.Modelo
{
    class Jogo
    {
        public int Id { get; set; }
        public int ValorPago { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
