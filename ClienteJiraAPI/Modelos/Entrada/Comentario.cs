using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Comentario
	{
		public string id { get; set; }
		public MembroEquipe author { get; set; }
		public string created { get; set; }
		public string body { get; set; }
		public MembroEquipe updateAuthor { get; set; }
		public string updated { get; set; }
	}
}
