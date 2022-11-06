using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Tarefa : Item
	{
		public Epico Epico { get; private set; }
		public Etapa Etapa { get; private set; }
		public int MyProperty { get; private set; }
		public List<Subtarefa> Subtarefas { get; private set; }
		public List<Relacionamento> Relacionamentos { get; private set; }
		public EnumTarefa TipoTarefa { get; private set; }
		public List<Agendamento> Agendamentos { get; private set; }
		public Sprint Sprint { get; private set; }
		public List<Apontamento> Apontamentos { get; private set; }
	}
}
