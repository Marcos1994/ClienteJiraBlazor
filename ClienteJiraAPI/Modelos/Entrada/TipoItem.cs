using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	/// <summary>
	/// Ids: 3 = Tarefa; 5 = Epico; 8 = Subtarefa;
	/// </summary>
	public class TipoItem
	{
		public string id { get; set; }
		public string name { get; set; }
		public bool subtask { get; set; }
	}
}
