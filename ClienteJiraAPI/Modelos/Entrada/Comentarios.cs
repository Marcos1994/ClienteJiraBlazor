using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Comentarios
	{
		public int maxResults { get; set; }
		public int total { get; set; }
		public int startAt { get; set; }
		public List<Comentarios> comments { get; set; }
	}
}
