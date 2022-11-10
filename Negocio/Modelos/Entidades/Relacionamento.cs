using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Relacionamento
	{
		public Relacionamento()
		{

		}

		public Relacionamento(Tarefa tarefaRelacionada, EnumRelacionamento tipoRelacionamento)
		{
			TarefaRelacionada = tarefaRelacionada;
			TipoRelacionamento = tipoRelacionamento;
		}

		public Tarefa TarefaRelacionada { get; private set; }
		public EnumRelacionamento TipoRelacionamento { get; private set; }
	}
}
