using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Projeto
	{
		public int Id { get; private set; }
		public string Chave { get; private set; }
		public string Nome { get; private set; }
		public string Foto { get; private set; }
		public string Tipo { get; private set; }
		public string Categoria { get; private set; }
	}
}
