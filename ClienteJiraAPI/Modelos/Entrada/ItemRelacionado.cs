using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class ItemRelacionado
	{
		public string id { get; set; }
		public string self { get; set; }
		public TipoRelacionamento type { get; set; }
		public ItemBase inwardIssue { get; set; }
		public ItemBase outwardIssue { get; set; }
	}
}
