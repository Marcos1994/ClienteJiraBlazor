using Negocio.Modelos.Entidades.Enum;
using System;

namespace Negocio.Modelos.Entidades
{
	public class Anexo
	{
		public int Id { get; private set; }
		public string Nome { get; private set; }
		public EnumTipoArquivo TipoArquivo { get; private set; }
		public string Conteudo { get; private set; }
		public DateTime DataCriacao { get; private set; }
	}
}