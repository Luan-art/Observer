using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Assinante : IObservador
    {
        public string nome { get; }

        public Assinante(string nome)
        {
            this.nome = nome;
        }

        public void Atualizar(string mensagem) => Console.WriteLine($"{nome}: {mensagem}");
    }
}
