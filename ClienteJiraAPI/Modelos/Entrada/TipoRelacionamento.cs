using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class TipoRelacionamento
	{
		public string id { get; set; }
		public string name { get; set; }
		public string inward { get; set; }
		public string outward { get; set; }
	}
}
