using System;

namespace Negocio.Modelos.Entidades
{
	public class Comentario
	{
		public Usuario Autor { get; private set; }
		public string Conteudo { get; private set; }
		public DateTime DataCriacao { get; private set; }
	}
}