using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Apontamento
	{
		public string self { get; set; }
		public MembroEquipe author { get; set; }
		public MembroEquipe updateAuthor { get; set; }
		public string timeSpent { get; set; }
		public int timeSpentSeconds { get; set; }
		public string id { get; set; }
		public string issueId { get; set; }
	}
}
