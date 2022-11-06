using System;

namespace Negocio.Modelos.Entidades
{
	public class Agendamento
	{
		public Agendamento()
		{

		}

		public Agendamento(Tarefa tarefa, Sprint sprint, DateTime horarioInicio, int tempoAlocado)
		{
			Tarefa = tarefa;
			Sprint = sprint;
			HorarioInicio = horarioInicio;
			TempoAlocado = tempoAlocado;
		}

		public Tarefa Tarefa { get; private set; }
		public Sprint Sprint { get; private set; }
		public DateTime HorarioInicio { get; private set; }
		public int TempoAlocado { get; private set; }
	}
}