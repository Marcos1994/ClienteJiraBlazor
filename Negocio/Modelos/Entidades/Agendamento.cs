using System;

namespace Negocio.Modelos.Entidades
{
	public class Agendamento
	{
		public Tarefa Tarefa { get; private set; }
		public Sprint Sprint { get; private set; }
		public DateTime HorarioInicio { get; private set; }
		public int TempoAlocado { get; private set; }
	}
}