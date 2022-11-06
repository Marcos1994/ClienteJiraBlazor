using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Epico : Item
	{
		public List<Tarefa> Tarefas { get; private set; } = new List<Tarefa>();
		public List<Etapa> Etapas { get; private set; } = new List<Etapa>();
	}
}
