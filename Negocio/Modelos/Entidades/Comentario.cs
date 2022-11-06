using System;

namespace Negocio.Modelos.Entidades
{
	public class Comentario
	{
		public Comentario()
		{

		}

		public Comentario(Usuario autor, string conteudo, DateTime dataCriacao)
		{
			Autor = autor;
			Conteudo = conteudo;
			DataCriacao = dataCriacao;
		}

		public Usuario Autor { get; private set; }
		public string Conteudo { get; private set; }
		public DateTime DataCriacao { get; private set; }
	}
}