using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Subtarefa : Item
	{
		public Tarefa TarefaPai { get; private set; }
	}
}
