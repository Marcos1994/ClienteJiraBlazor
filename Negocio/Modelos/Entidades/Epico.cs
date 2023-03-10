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

		public Epico(int id, string chave, string nome, EnumStatus status, Usuario reportado, Usuario atribuido, DateTime dataInicio, DateTime dataLimite, string descricao, Projeto projeto, decimal orcamentoTotal, string pep, string solicitante)
			: base(id, chave, nome, status, reportado, atribuido, dataInicio, dataLimite, descricao, projeto)
		{
			OrcamentoTotal = orcamentoTotal;
			Pep = pep;
			Solicitante = solicitante;
		}

		public List<Tarefa> Tarefas { get; private set; } = new List<Tarefa>();
		public List<Etapa> Etapas { get; private set; } = new List<Etapa>();
		public decimal OrcamentoTotal { get; set; }
		public string Pep { get; set; }
		public string Solicitante { get; set; }
	}
}
