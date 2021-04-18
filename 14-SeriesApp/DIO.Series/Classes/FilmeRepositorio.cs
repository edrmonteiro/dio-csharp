using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class FilmeRepositorio : iRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();
        public void Atualiza(int id, Filme serie)
        {
            listaFilme[id] = serie;
        }

        public void Excluir(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filme serie)
        {
            listaFilme.Add(serie);
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }
    }
}