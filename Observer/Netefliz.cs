using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Netfliz
    {
        private List<IObservador> observadores = new List<IObservador>();

        public void AdicionarObservador(IObservador observador) => observadores.Add(observador);

        public void RemoverObservador(string nome)
        {
            var observador = observadores.Find(o => o.nome == nome);
            if (observador != null)
            {
                observadores.Remove(observador);
                Console.WriteLine($"Assinatura de {nome} foi cancelada.");
            }
            else
            {
                Console.WriteLine($"Assinante {nome} não encontrado.");
            }
        }

        public void NotificarObservadores(string mensagem)
        {
            foreach (var observador in observadores)
            {
                observador.Atualizar(mensagem);
            }
        }
    }
}
