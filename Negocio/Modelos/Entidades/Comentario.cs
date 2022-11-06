using System;

namespace Negocio.Modelos.Entidades
{
	public class Comentario
	{
		public Comentario()
		{

		}

		public Comentario(int id, Usuario autor, string conteudo, DateTime dataCriacao)
		{
			Id = id;
			Autor = autor;
			Conteudo = conteudo;
			DataCriacao = dataCriacao;
		}

		public int Id { get; private set; }
		public Usuario Autor { get; private set; }
		public string Conteudo { get; private set; }
		public DateTime DataCriacao { get; private set; }
	}
}