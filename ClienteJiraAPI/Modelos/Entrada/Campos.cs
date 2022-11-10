using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Campos
	{
		public string summary { get; set; }
		public Status status { get; set; }
		public TipoItem issueType { get; set; }
	}
}
