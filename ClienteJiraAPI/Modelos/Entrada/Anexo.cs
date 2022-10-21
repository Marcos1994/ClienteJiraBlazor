using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Anexo
	{
		public string id { get; set; }
		public string fileName { get; set; }
		public string mimeType { get; set; }
		public string content { get; set; }
		public string created { get; set; }
	}
}
