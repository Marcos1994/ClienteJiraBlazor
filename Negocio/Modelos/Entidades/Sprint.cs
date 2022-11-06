using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;

namespace Negocio.Modelos.Entidades
{
	public class Sprint
	{
		public Sprint()
		{

		}

		public Sprint(int id, string nome, DateTime inicio, DateTime fim, EnumSprint estado)
		{
			Id = id;
			Nome = nome;
			Inicio = inicio;
			Fim = fim;
			Estado = estado;
		}

		public int Id { get; private set; }
		public string Nome { get; private set; }
		public DateTime Inicio { get; private set; }
		public DateTime Fim { get; private set; }
		public EnumSprint Estado { get; private set; }
		public List<Tarefa> TarefasAlocadas { get; private set; } = new List<Tarefa>();
		public List<Agendamento> TarefasAgendadas { get; private set; } = new List<Agendamento>();
	}
}