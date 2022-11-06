using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Epico : Item
	{
		public Epico()
		{

		}

		public Epico(int id, string chave, string nome, EnumStatus status, Usuario reportado, Usuario atribuido, DateTime dataInicio, DateTime dataLimite, string descricao, Projeto projeto)
			: base(id, chave, nome, status, reportado, atribuido, dataInicio, dataLimite, descricao, projeto)
		{

		}

		public List<Tarefa> Tarefas { get; private set; } = new List<Tarefa>();
		public List<Etapa> Etapas { get; private set; } = new List<Etapa>();
	}
}
