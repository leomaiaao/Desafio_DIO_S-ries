using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaAnime = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			listaAnime[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaAnime[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaAnime.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaAnime;
		}

		public int ProximoId()
		{
			return listaAnime.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaAnime[id];
		}
	}
}