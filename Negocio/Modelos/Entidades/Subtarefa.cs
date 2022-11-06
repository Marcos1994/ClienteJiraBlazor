using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Subtarefa : Item
	{
		public Subtarefa()
			: base()
		{
			
		}

		public Subtarefa(int id, string chave, string nome, EnumStatus status, Usuario reportado, Usuario atribuido, DateTime dataInicio, DateTime dataLimite, string descricao, Projeto projeto, Tarefa tarefaPai)
			: base(id, chave, nome, status, reportado, atribuido, dataInicio, dataLimite, descricao, projeto)
		{
			TarefaPai = tarefaPai;
		}

		public Tarefa TarefaPai { get; private set; }
	}
}
