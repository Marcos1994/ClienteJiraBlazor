using System.Collections.Generic;

namespace Negocio.Modelos.Entidades
{
	public class Etapa : Item
	{
		public Epico Epico { get; private set; }
		public double Orcamento { get; private set; }
		public List<Tarefa> Tarefas { get; private set; } = new List<Tarefa>();

	}
}