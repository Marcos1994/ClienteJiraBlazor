using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Apontamentos
	{
		public int startAt { get; set; }
		public int maxResults { get; set; }
		public int total { get; set; }
		public List<Apontamento> worklogs { get; set; }
	}
}
