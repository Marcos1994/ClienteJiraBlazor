using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Tarefa : Item
	{
		public Tarefa()
			: base()
		{

		}

		public Tarefa(int id, string chave, string nome, EnumStatus status, Usuario reportado, Usuario atribuido, DateTime dataInicio, DateTime dataLimite, string descricao, Projeto projeto, Epico epico, Etapa etapa, int estimativa, int storypoints, EnumPrioridade prioridade, EnumTarefa tipoTarefa, Sprint sprint)
			: base(id, chave, nome, status, reportado, atribuido, dataInicio, dataLimite, descricao, projeto)
		{
			Epico = epico;
			Etapa = etapa;
			Estimativa = estimativa;
			Storypoints = storypoints;
			Prioridade = prioridade;
			TipoTarefa = tipoTarefa;
			Sprint = sprint;
		}

		public Epico Epico { get; private set; }
		public Etapa Etapa { get; private set; }
		public int Estimativa { get; private set; }
		public int Storypoints { get; private set; }
		public EnumPrioridade Prioridade { get; private set; }
		public EnumTarefa TipoTarefa { get; private set; }
		public Sprint Sprint { get; private set; }
		public List<Subtarefa> Subtarefas { get; private set; } = new List<Subtarefa>();
		public List<Relacionamento> Relacionamentos { get; private set; } = new List<Relacionamento>();
		public List<Agendamento> Agendamentos { get; private set; } = new List<Agendamento>();
		public List<Apontamento> Apontamentos { get; private set; } = new List<Apontamento>();
	}
}
