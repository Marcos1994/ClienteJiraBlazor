using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;

namespace Negocio.Modelos.Entidades
{
	public class Etapa : Item
	{
		public Etapa()
			: base()
		{

		}

		public Etapa(int id, string chave, string nome, EnumStatus status, Usuario reportado, Usuario atribuido, DateTime dataInicio, DateTime dataLimite, string descricao, Projeto projeto, Epico epico, double orcamento)
			: base(id, chave, nome, status, reportado, atribuido, dataInicio, dataLimite, descricao, projeto)
		{
			Epico = epico;
			Orcamento = orcamento;
		}

		public Epico Epico { get; private set; }
		public double Orcamento { get; private set; }
		public List<Tarefa> Tarefas { get; private set; } = new List<Tarefa>();

	}
}