using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public abstract class Item
	{
		public int Id { get; protected set; }
		public string Chave { get; protected set; }
		public string Nome { get; protected set; }
		public EnumStatus Status { get; protected set; }
		public Usuario Reportado { get; private set; }
		public Usuario Atribuido { get; private set; }
		public DateTime DataInicio { get; protected set; }
		public DateTime DataLimite { get; protected set; }
		public string Descricao { get; protected set; }
		public Projeto Projeto { get; protected set; }
		public List<string> Rotulos { get; protected set; }
		public List<Anexo> Anexos { get; protected set; }
		public List<Comentario> Comentarios { get; protected set; }
	}
}
