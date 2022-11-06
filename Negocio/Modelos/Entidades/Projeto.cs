using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Projeto
	{
		public Projeto()
		{

		}

		public Projeto(int id, string chave, string nome, string foto, string tipo, string categoria)
		{
			Id = id;
			Chave = chave;
			Nome = nome;
			Foto = foto;
			Tipo = tipo;
			Categoria = categoria;
		}

		public int Id { get; private set; }
		public string Chave { get; private set; }
		public string Nome { get; private set; }
		public string Foto { get; private set; }
		public string Tipo { get; private set; }
		public string Categoria { get; private set; }
	}
}
