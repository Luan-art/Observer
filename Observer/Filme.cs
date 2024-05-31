using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Filme
    {
        private string titulo;
        private string tipoConteudo;

        public Filme(string titulo, string tipoConteudo)
        {
            this.titulo = titulo;
            this.tipoConteudo = tipoConteudo;

        }

        public override string? ToString()
        {
            return "Novo(a) " + tipoConteudo + " Titulo: " +titulo;
        }
    }
}
